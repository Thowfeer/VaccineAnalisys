using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineAnalysis.Service.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Add(T Item);        
        Task<T> GetById(object Id);
        Task<IEnumerable<T>> GetAll();
    }
}
