using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATMMachine.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Account number should be numeric between 6 to 10 digits")]
        [Display(Name ="Account #")]
        public string AccountNo { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0}{1}{2}", FirstName, " ", LastName);
            }
        }
        [DataType(DataType.Currency)]
        public Decimal Balance { get; set; }

    }
}