using Cadastrar_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastrar_WebAPI.Data
{
    public class Repository: IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Pf[]> GetAllPfAsync()
        {
            IQueryable<Pf> query = _context.Pf;


            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }
        public async Task<Pf> GetPfAsyncById(int pfId)
        {
            IQueryable<Pf> query = _context.Pf;


            query = query.AsNoTracking()
                         .OrderBy(pf=> pf.id)
                         .Where(pf => pf.id == pfId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Pj[]> GetAllPjAsync()
        {
            IQueryable<Pj> query = _context.Pj;


            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }
        public async Task<Pj> GetPjAsyncById(int pjId)
        {
            IQueryable<Pj> query = _context.Pj;


            query = query.AsNoTracking()
                         .OrderBy(pj => pj.id)
                         .Where(pj => pj.id == pjId);

            return await query.FirstOrDefaultAsync();
        }
    }
}