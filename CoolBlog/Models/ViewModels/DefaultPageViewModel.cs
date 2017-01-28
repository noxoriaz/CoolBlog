using CoolBlog.Business;
using CoolBlog.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolBlog.Models.ViewModels
{
    public class DefaultPageViewModel<T>: IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }
        public T CurrentPage { get; set; }

        public IContent Section { get; set; }
    }
}