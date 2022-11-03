using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineAnalysis.Service.Dtos.UserInfoDto
{
    public class UserCreationDto
    {
        [Required]
        [RegularExpression("^[a-z -']+$")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("^[a-z -']+$")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("/^ 784 -?[0 - 9]{4}-?[0 - 9]{7}-?[0 - 9]{ 1}$/g")]
        public string EmiratesId { get; set; }
        [Required]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")]
        public string ContactNumber { get; set; }
        [Required]
        [RegularExpression(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}")]
        public string EmailAddress { get; set; }
        [Required]
        public string IsResident { get; set; }
    }
}
