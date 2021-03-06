using System.Collections.Generic;
using System.Linq;
using Casper.Domain.Features.BlogPosts;
using CroquetAustralia.Website.App.Infrastructure;

namespace CroquetAustralia.Website.App.admin.home
{
    public class NewsViewModel : AdminViewModel
    {
        public NewsViewModel(string blogDirectoryName, IEnumerable<BlogPost> blogPosts)
        {
            BlogDirectoryName = blogDirectoryName;
            BlogPosts = blogPosts.Select(f => new NavigationItem($"{f.Published.ToString("dd MMM yyyy")} {f.Title}", Urls.Admin.EditNews(blogDirectoryName, f.RelativeUri))).ToArray();
        }

        public string BlogDirectoryName { get; }
        public NavigationItem[] BlogPosts { get; }
    }
}