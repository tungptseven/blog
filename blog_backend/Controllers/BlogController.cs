using blog_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
            if (_context.BlogItems.Count() == 0)
            {
                _context.BlogItems.Add(new BlogItem { Title = "Hello World" }); _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<BlogItem>> GetAll()
        {
            return _context.BlogItems.ToList();
        }

        [HttpGet("{id}", Name = "GetBlog")]
        public ActionResult<BlogItem> GetById(long id)
        {
            var item = _context.BlogItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }

    
}
