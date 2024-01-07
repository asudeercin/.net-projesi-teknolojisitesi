using System;
using System.Threading.Tasks;

namespace shopapp.data.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        
         ICategoryRepository Categories {get;}
        
         IProductRepository Products {get;} 
         void Save();
         Task<int> SaveAsync();

    }
}