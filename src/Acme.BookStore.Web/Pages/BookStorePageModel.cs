using Acme.BookStore.Localization;
using Microsoft.Extensions.Configuration;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStore.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BookStorePageModel : AbpPageModel
    {

        // private readonly IConfiguration _config;

        //public BookStorePageModel(IConfiguration config)
        //{
        //    _config = config;
        //}
        //protected BookStorePageModel(IConfiguration config)
        protected BookStorePageModel()
        {
            //_config = config;
            var v = ServiceProvider;
            LocalizationResourceType = typeof(BookStoreResource);
        }
    }
}