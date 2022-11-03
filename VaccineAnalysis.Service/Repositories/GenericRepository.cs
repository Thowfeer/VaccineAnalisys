using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core;
using VaccineAnalysis.Service.Interfaces;

namespace VaccineAnalysis.Service.Repositories
{
    public  class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        private VaccineDbContext _context;

        public GenericRepository(VaccineDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(T Item)
        {
            try
            {
                await _context.Set<T>().AddAsync(Item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<T> GetById(object id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
