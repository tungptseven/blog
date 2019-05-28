using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace blog_backend.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }

        public DbSet<BlogItem> BlogItems { get; set; }

    }
}
