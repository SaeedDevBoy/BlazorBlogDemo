using BlazorBlogDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBlogDemo.Client.Services
{
    public class BlogService : IBlogService
    {
        private HttpClient _http;
        public BlogService(HttpClient http)
        {
            _http = http;
        }

        

        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var post =await _http.GetFromJsonAsync<BlogPost>($"api/Blog/{url}");
            return post;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            var posts = await _http.GetFromJsonAsync<List<BlogPost>>("api/Blog");
            return posts;
        }

        
    }
}
