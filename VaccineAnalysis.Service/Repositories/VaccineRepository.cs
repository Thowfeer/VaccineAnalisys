using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core;
using VaccineAnalysis.Core.Entites;
using VaccineAnalysis.Service.Interfaces;

namespace VaccineAnalysis.Service.Repositories
{
    public class VaccineRepository : GenericRepository<UserVaccineInfo>, IVaccineRepository
    {
        private VaccineDbContext _context { get; set; }

        public VaccineRepository(VaccineDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> CreateVaccineTypes(VaccineType model)
        {
            try
            {
                await _context.VaccineTypes.AddAsync(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeleteVaccineTypes(int id)
        {
            try
            {
                var data= await _context.VaccineTypes.FindAsync(id);
                if(data!=null)
                {
                    data.IsActive = false;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { 
                throw;
            }
        }
    }
}
