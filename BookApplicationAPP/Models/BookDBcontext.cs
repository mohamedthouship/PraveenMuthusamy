using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPP.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options)
        : base(options)
        {
        }

        public DbSet<BookInfo> BookInfo { get; set; }
        public DbSet<AuthorInfo> AuthorInfo { get; set; }
    }

}
