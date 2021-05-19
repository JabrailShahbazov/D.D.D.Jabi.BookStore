using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Jabi.BookStore.Books
{
    public class UpdateBookDto :Entity<int>
    {
       
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}
