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
    public class UserRepository:GenericRepository<UserInfo>,IUserRepository
    {
        private VaccineDbContext _context { get; set; }

        public UserRepository(VaccineDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<bool> DeleteUser(long UserId)
        {
            try
            {
                var userInfo= await GetById(UserId);
                if(userInfo!=null)
                {
                    userInfo.IsActive = false;
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
