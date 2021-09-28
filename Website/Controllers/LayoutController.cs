using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Localization;

namespace Website.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index(string lang, string returnUrl)
		{
			// Set up the default localization cookie to fr
			Response.Cookies.Append(
				CookieRequestCultureProvider.DefaultCookieName,
				CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(lang)),
				new CookieOptions
				{
					Expires = DateTimeOffset.UtcNow.AddYears(1),
					IsEssential = true,  //critical settings to apply new culture
					Path = "/",
					HttpOnly = false,
				}
			);

			return LocalRedirect(returnUrl);
		}
	}
}
