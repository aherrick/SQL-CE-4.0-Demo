using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppHarborDemoApp.Models;

namespace AppHarborDemoApp.Repository
{
    public class AJRepository : IAJRepository
    {

        private AppHarborDemoApp.DB.AppHBDataContext _db;

        public AJRepository()
        {
            _db = new AppHarborDemoApp.DB.AppHBDataContext();
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
            var c = new AppHarborDemoApp.DB.Comment();
            c.Data = comment.Data;
            c.CreatedOn = comment.CreatedOn;
            _db.Comments.InsertOnSubmit(c);
            _db.SubmitChanges();

            return c.Id;
        }

        #endregion
    }
}