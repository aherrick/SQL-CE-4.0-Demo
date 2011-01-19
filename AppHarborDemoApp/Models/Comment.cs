using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppHarborDemoApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Data { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}