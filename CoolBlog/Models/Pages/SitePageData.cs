using EPiServer.Core;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoolBlog.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(GroupName = SystemTabNames.Content,
                 Order = 100)]
        public virtual string MetaTitle { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 200)]
        public virtual string MetaKeyWords { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 300)]
        public virtual string MetaDescription { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 100)]
        public virtual ContentReference PageImage { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 200)]
        public virtual string TeaserText { get; set; }
    }
}