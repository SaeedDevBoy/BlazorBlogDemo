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
