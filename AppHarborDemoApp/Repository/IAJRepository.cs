using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppHarborDemoApp.Models;

namespace AppHarborDemoApp.Repository
{
    public interface IAJRepository
    {
        IList<AppHarborDemoApp.Models.Comment> GetComments();
        void AddComment(Comment comment);
        void DeleteComment(int id);

        // save
        void Save();
    }
}