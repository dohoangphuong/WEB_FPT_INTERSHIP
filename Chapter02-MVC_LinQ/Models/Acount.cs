using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chapter02_MVC_LinQ.Models
{
    public class Acount
    {
        [Required]
        [StringLength(160)]
        public string ACCOUNT { get; set; }
        [Required(ErrorMessage = "Account not validate")]

        public string NAME { get; set; }

       
        public string PASSWORD { get; set; }
         [Required(ErrorMessage = "Password not correct")]

         [RegularExpression(@"[1-9]")]
          public int TYPE { get; set; }
    }
}