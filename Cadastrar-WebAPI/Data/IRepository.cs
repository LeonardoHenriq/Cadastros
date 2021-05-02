using Cadastrar_WebAPI.Models;
using System.Threading.Tasks;

namespace Cadastrar_WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Pf
        Task<Pf[]> GetAllPfAsync();        
        Task<Pf> GetPfAsyncById(int pfId);
        
        //Pj
        Task<Pj[]> GetAllPjAsync();
        Task<Pj> GetPjAsyncById(int pjId);
    }
}