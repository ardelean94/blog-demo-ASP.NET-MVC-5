using Blog_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Demo.ViewModels
{
    public class PostsTypesViewModel
    {
        public IEnumerable<PostTypes> PostTypes { get; set; }

        public Posts Posts { get; set; }
    }
}