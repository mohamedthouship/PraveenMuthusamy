using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookApplicationAPP.Models
{
    public class BookInfo
    {
        [Key]
     
        [Required(ErrorMessage = "BookId is required")]
        public int BookId { get; set; }
        [Required(ErrorMessage = "BookName is required")]
        public string Bookname { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


    }
}
