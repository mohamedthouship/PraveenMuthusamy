using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPP.Models
{
    public class AuthorInfo
    {

        [Key]

        [Required(ErrorMessage = "AuthorId is required")]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "AuthorFirstName is required")]
        public string AuthorFirstName { get; set; }
        [Required(ErrorMessage = "AuthorLastName is required")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "BookId is required")]
        public int BookId { get; set; }
     
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}

