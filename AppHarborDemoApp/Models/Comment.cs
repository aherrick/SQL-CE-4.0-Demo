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

        [Required(ErrorMessage="Come on this field is required!")]
        public string Data { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}