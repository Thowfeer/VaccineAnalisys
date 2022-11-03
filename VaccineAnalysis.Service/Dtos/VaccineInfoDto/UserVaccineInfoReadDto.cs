using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;
using VaccineAnalysis.Service.Dtos.UserInfoDto;
using VaccineAnalysis.Service.Dtos.VaccineTypeDto;

namespace VaccineAnalysis.Service.Dtos.VaccineInfoDto
{
    public  class UserVaccineInfoReadDto
    {
        
        public long Id { get; set; }
        
        public long UserId { get; set; }
        
        public int VaccineTypeId { get; set; }
        
        public string Location { get; set; }
        
        public string CenterName { get; set; }
        
        public DateTime IssueDate { get; set; }

        public virtual UserInfoReadDto UserInfo { get; set; }

        public virtual VaccineTypeCreateDto VaccineType { get; set; }
    }
}
