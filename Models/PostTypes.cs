using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog_Demo.Models
{
    public class PostTypes
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public bool IsBusiness { get; set; }
        public bool IsEntertainment { get; set; }
        public bool IsCasual { get; set; }
        public bool IsEducational { get; set; }

    }
}