namespace AspStore.ShopUi.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;
        public EfProductRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }
        public List<Product> GetAll()
        {
            return _storeDbContext.Tbl_Products.ToList();
        }
    }
}
