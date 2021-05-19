using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Jabi.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Jabi.BookStore.Web.Pages.Books
{
    public class EditModalModel : BookStorePageModel
    {
        [BindProperty]
        public EditBookViewModel Book { get; set; }

        public List<SelectListItem> Authors { get; set; }

        private readonly IBookAppService _bookAppService;

        public EditModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public async Task OnGetAsync(int id)
        {
            var bookDto = await _bookAppService.GetAsync(id);
            Book = ObjectMapper.Map<BookDto, EditBookViewModel>(bookDto);

           
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(
                Book.Id,
                ObjectMapper.Map<EditBookViewModel, UpdateBookDto>(Book)
            );

            return NoContent();
        }

        public class EditBookViewModel
        {
            [HiddenInput]
            public int Id { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime PublishDate { get; set; } = DateTime.Now;
            [StringLength(200)]
            public string Description { get; set; }
        }
    }
}
