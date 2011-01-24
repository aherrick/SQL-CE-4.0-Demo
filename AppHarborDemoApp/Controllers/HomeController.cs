using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppHarborDemoApp.Models;
using AppHarborDemoApp.Repository;

namespace AppHarborDemoApp.Controllers
{
    public partial class HomeController : Controller
    {
        private IAJRepository _db = new AJRepository();

        #region Constructor

        public HomeController() { }

        #endregion

        #region Index

        public ActionResult Index()
        {
            var vm = new CommentsVM();
            vm.Comments = _db.GetComments();
            vm.Comment = new Comment();
            return View(vm);
        }

        #endregion

        #region Index Post 

        [HttpPost]
        public ActionResult Index(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CreatedOn = DateTime.Now;
                _db.AddComment(comment);
                _db.Save();
                return RedirectToAction("Index");
            }

            // error return view
            var vm = new CommentsVM();
            vm.Comment = comment;
            vm.Comments = _db.GetComments();
            return View("Index", vm);
        }

        #endregion

        #region JSON Delete Comment

        [HttpPost]
        public JsonResult JSONDeleteComment(int id)
        {
            _db.DeleteComment(id);
            _db.Save();
            return Json(null);
        }

        #endregion
    }
}
