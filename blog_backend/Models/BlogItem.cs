﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_backend.Models
{
    public class BlogItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
