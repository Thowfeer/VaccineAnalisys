using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineAnalysis.Core.Entites
{
    public  class UserVaccineInfo: ExtentionEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public int VaccineTypeId { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string CenterName { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual VaccineType VaccineType { get; set; }
    }
}
