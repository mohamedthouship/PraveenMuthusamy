using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookApplicationAPP.Models
{
    interface IBookDetailsRespository
    {
        
       Task<BookInfo> GetByBookId(int BookId );
        Task<AuthorInfo> GetByAuthorInfo(int AuthorId);

    }
}
