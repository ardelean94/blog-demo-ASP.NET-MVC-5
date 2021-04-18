using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog_Demo.Models
{
    public class Posts
    {
        public long Id { get; set; }

        [Display(Name = "Section")]
        public PostTypes PostType { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Author { get; set; }
        public bool IsPublished { get; set; }
        public int NoOfLikes { get; set; }
    }
}