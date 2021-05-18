using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Books
{
    public class AuthorLookupDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
