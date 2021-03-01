using BlazorBlogDemo.Server.Data;
using BlazorBlogDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlogDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogDbContext _context;
        public BlogController(BlogDbContext context)
        {
            _context = context;
        }
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>() {
            new BlogPost{
            Url="new-tutorial",
            Title="A New Tutorial About Blazor For Everyone With Web Api",
            Description="This is new tutorial, showing you how to build a blog with blazor",
            Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vitae proin sagittis nisl rhoncus mattis. Ultrices tincidunt arcu non sodales neque sodales. Odio pellentesque diam volutpat commodo sed egestas egestas fringilla. Integer feugiat scelerisque varius morbi enim nunc faucibus. Ultricies mi eget mauris pharetra et ultrices. Ut tortor pretium viverra suspendisse potenti nullam ac tortor vitae. Pretium lectus quam id leo. Sed blandit libero volutpat sed cras ornare arcu dui. Dictum at tempor commodo ullamcorper a lacus vestibulum. Habitasse platea dictumst quisque sagittis purus sit. Egestas pretium aenean pharetra magna. Accumsan tortor posuere ac ut. Dictum non consectetur a erat. Nunc vel risus commodo viverra. Nibh ipsum consequat nisl vel. Vitae proin sagittis nisl rhoncus mattis. Sed ullamcorper morbi tincidunt ornare massa eget. Suscipit tellus mauris a diam. Pharetra vel turpis nunc eget lorem dolor sed viverra ipsum."},
            new BlogPost{
            Url="first-post",
            Title="My First Blog Post With Web Api" ,
            Description="This is my new shiny blog",
            Content="This is my new Blog post"
            }
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> AllTheBlogPosts() 
        {
            return Ok(_context.BlogPosts);
        }

        [HttpGet("{url}")] 
        public ActionResult<BlogPost> SingleBlogPostByUrl(string url) 
        {
            var post = _context.BlogPosts.FirstOrDefault(p=>p.Url.ToLower().Equals(url.ToLower()));
            if (post==null)
            {
                //return NotFound("The Post Does Not Exist .");
                return NotFound();
            }
            return Ok(post);
        }
    }
}
