using System.Threading.Tasks;
using shopapp.data.Abstract;

namespace shopapp.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        
     
        private EfCoreCategoryRepository _categoryRepository;
               private EfCoreProductRepository _productRepository;

       
        public ICategoryRepository Categories => 
            _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);             


        public IProductRepository Products => 
            _productRepository = _productRepository ?? new EfCoreProductRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}