using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using CoolBlog.Models.Pages;
using System.Web.Security;

namespace CoolBlog.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}