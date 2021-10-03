using System;
using System.Threading.Tasks;

using AspNetCoreDatabaseLocalizationDemo.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDatabaseLocalizationDemo.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILanguageService languageService, ILocalizationService localizationService)
            : base(languageService, localizationService)
        {
            
        }

        public IActionResult Index()
        {
           // ViewData["Title"] = Localize("customer.page.create.title");

            return View();
        }

        [HttpPost]
        public IActionResult ChangeLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
