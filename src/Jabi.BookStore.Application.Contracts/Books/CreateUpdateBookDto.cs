using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabi.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [StringLength(200)]
        public string Description { get; set; }
        public int AuthorId { get; set; }
    }
}
