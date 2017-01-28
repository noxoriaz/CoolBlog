using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CoolBlog.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "9283e651-d1af-4936-bf27-e9289e78fe38", Description = "Cool Blog Start Page")]
    public class StartPage : SitePageData
    {
        [Display(
            Name = "Main body",
            Description = "Main body of the start page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Heading",
            Description = "Heading of the Start Page",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Heading { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}