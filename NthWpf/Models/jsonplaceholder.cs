﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthWpf.Models
{
    class Post
    {
        public int Username { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    class Posts
    {
        public List<Post> PostsList { get; set; }
    }
}