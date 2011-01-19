using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHarborDemoApp.Models
{
    public class AJRepository : IAJRepository
    {

        private AppHarborDataContext _db;

        public AJRepository()
        {
            _db = new AppHarborDataContext();
        }

        #region IAJRepository Members

        public IList<Comment> GetComments()
        {
            return (from m in _db.Comments
                   select new Comment
                   {
                       Data = m.Data,
                       CreatedOn = m.CreatedOn
                   }).ToList();
        }

        public int SaveComment(Comment comment)
        {
            var c = new AppHarborDemoApp.Comment();
            c.Data = comment.Data;
            c.CreatedOn = comment.CreatedOn;
            _db.Comments.InsertOnSubmit(c);
            _db.SubmitChanges();

            return c.Id;
        }

        #endregion
    }
}