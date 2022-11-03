using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineAnalysis.Core.Entites
{
    public  class VaccineType: ExtentionEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_]*$")]
        public string VaccineName { get; set; }        
    }
}
