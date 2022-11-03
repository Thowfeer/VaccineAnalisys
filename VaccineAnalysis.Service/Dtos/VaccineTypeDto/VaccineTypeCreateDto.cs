using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineAnalysis.Service.Dtos.VaccineTypeDto
{
    public class VaccineTypeCreateDto
    {        
        [Required]
        [RegularExpression("^[a-zA-Z0-9_]*$")]
        public string VaccineName { get; set; }
    }
}
