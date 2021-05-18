using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Jabi.BookStore.Books
{
    public class BookDto : AuditedEntityDto<int>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }
    }
}
