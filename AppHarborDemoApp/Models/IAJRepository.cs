using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHarborDemoApp.Models
{
    public interface IAJRepository
    {
        IList<Comment> GetComments();
        int SaveComment(Comment comment);
    }
}