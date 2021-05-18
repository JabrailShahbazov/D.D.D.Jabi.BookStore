//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Jabi.BookStore.Books;
//using Volo.Abp.Data;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.Domain.Repositories;

//namespace Jabi.BookStore
//{
//    public class BookStoreDataSeederContributor
//        : IDataSeedContributor, ITransientDependency
//    {
//        private readonly IRepository<Book, int> _bookRepository;

//        public BookStoreDataSeederContributor(IRepository<Book, int> bookRepository)
//        {
//            _bookRepository = bookRepository;
//        }

//        public async Task SeedAsync(DataSeedContext context)
//        {
//            if (await _bookRepository.GetCountAsync() <= 0)
//            {
//                await _bookRepository.InsertAsync(
//                    new Book
//                    {
//                        Name = "1984",
//                        Type = BookType.Dystopia,
//                        PublishDate = new DateTime(1949, 6, 8),
//                        Description = "sssss"
//                    },
//                    autoSave: true
//                );

//                await _bookRepository.InsertAsync(
//                    new Book
//                    {
//                        Name = "The Hitchhiker's Guide to the Galaxy",
//                        Type = BookType.ScienceFiction,
//                        PublishDate = new DateTime(1995, 9, 27),
//                        Description = "sssss"

//                    },
//                    autoSave: true
//                );
//            }
//        }
//    }
//}
