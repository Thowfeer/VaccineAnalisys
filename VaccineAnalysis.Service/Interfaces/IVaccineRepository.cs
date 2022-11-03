using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;

namespace VaccineAnalysis.Service.Interfaces
{
    public  interface IVaccineRepository:IGenericRepository<UserVaccineInfo>
    {
        Task<bool> CreateVaccineTypes(VaccineType model);
        Task<bool> DeleteVaccineTypes(int id);
        
    }
}
