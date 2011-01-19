using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHarborDemoApp.Models
{
    public class CommentsVM
    {
        public Comment Comment { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}