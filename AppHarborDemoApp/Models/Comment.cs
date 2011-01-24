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

        [Required(ErrorMessage="Come on, leave me a message!")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Required, at least make something up it!")]
        [Range(1, 120, ErrorMessage = "Sorry, invalid age!")] // must be between 1 and 120 realistically
        //[RegularExpression(@"^[1-9]+$", ErrorMessage="Sorry, invalid!")] // must be num
        public int Age { get; set; }

        public bool Cool { get; set; }


        public DateTime CreatedOn { get; set; }
    }
}