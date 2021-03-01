﻿using BlazorBlogDemo.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlogDemo.Server.Data
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        
    }
}
