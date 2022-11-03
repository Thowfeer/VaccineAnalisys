using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;

namespace VaccineAnalysis.Service.Dtos.UserInfoDto
{
    public class UserInfoReadDto
    {

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmiratesId { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }

        public bool IsResident { get; set; }

        public virtual IEnumerable<UserVaccineInfo> UserVaccineInfos { get; set; }
    }
}
