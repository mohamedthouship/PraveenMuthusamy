using BookApplicationAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPP.Controllers
{
    public class AuthorDetails :Controller
    {


        private readonly ILogger<AuthorDetails> _logger;

        public AuthorDetails(ILogger<AuthorDetails> logger)
        {
            _logger = logger;
        }
        //private BookDBContext Context { get; }
        //public AuthorDetails(BookDBContext dBContext)
        //{
        //    this.Context = dBContext;
        //}
        [Route("AuthorDetails/AuthorDet")]
        public IActionResult AuthorDet()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult RegisterAuthor(AuthorInfo authorInfo)
        //{
        //    this.Context.AuthorInfo.Add(authorInfo);
        //    this.Context.SaveChanges();
        //    int id = authorInfo.AuthorId;
        //    return View(authorInfo);
        //}
    }
}

