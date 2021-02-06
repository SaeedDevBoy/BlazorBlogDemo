using BlazorBlogDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlogDemo.Client.Services
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>() {
            new BlogPost{
            Url="new-tutorial",
            Title="A New Tutorial About Blazor For Everyone",
            Description="This is new tutorial, showing you how to build a blog with blazor",
            Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vitae proin sagittis nisl rhoncus mattis. Ultrices tincidunt arcu non sodales neque sodales. Odio pellentesque diam volutpat commodo sed egestas egestas fringilla. Integer feugiat scelerisque varius morbi enim nunc faucibus. Ultricies mi eget mauris pharetra et ultrices. Ut tortor pretium viverra suspendisse potenti nullam ac tortor vitae. Pretium lectus quam id leo. Sed blandit libero volutpat sed cras ornare arcu dui. Dictum at tempor commodo ullamcorper a lacus vestibulum. Habitasse platea dictumst quisque sagittis purus sit. Egestas pretium aenean pharetra magna. Accumsan tortor posuere ac ut. Dictum non consectetur a erat. Nunc vel risus commodo viverra. Nibh ipsum consequat nisl vel. Vitae proin sagittis nisl rhoncus mattis. Sed ullamcorper morbi tincidunt ornare massa eget. Suscipit tellus mauris a diam. Pharetra vel turpis nunc eget lorem dolor sed viverra ipsum."},
            new BlogPost{
            Url="first-post",
            Title="My First Blog Post" ,
            Description="This is my new shiny blog",
            Content="This is my new Blog post"
            }
            
        };
        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
