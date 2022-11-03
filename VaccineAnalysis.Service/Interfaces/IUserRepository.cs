using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;

namespace VaccineAnalysis.Service.Interfaces
{
    public interface IUserRepository: IGenericRepository<UserInfo>
    {
        Task<bool> DeleteUser(long UserId);
        
    }
}
