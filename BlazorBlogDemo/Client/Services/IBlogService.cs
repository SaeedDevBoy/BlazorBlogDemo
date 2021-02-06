using BlazorBlogDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlogDemo.Client.Services
{
    interface IBlogService
    {
        List<BlogPost> GetBlogPosts();

        BlogPost GetBlogPostByUrl(string url);
    }
}
