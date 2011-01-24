using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppHarborDemoApp.Models;
using AppHarborDemoApp.DB;

namespace AppHarborDemoApp.Repository
{
    public class AJRepository : IAJRepository
    {
        private AJDataContext _ctx = new AJDataContext();

        public AJRepository() {  }

        #region IAJRepository Members

        public IList<Comment> GetComments()
        {
            return _ctx.Comments.ToList();
        }

        public void AddComment(Comment comment)
        {
            _ctx.Comments.Add(comment);
        }

        public void DeleteComment(int id)
        {
            var c = _ctx.Comments.Find(id);
            _ctx.Comments.Remove(c);
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        #endregion
    }
}