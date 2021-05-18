using Jabi.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jabi.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}