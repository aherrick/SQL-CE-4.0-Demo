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
        private IAJRepository _db { get; set; }

        #region Constructor

        public HomeController()
        {
            _db = new AJRepository();
        }

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

        #region Create

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            comment.CreatedOn = DateTime.Now;

            if (ModelState.IsValid)
            {
                _db.SaveComment(comment);
                return RedirectToAction("Index");
            }
            else
            {
                var vm = new CommentsVM();
                vm.Comment = comment;
                vm.Comments = _db.GetComments();
                return View("Index", vm);
            }
        }

        #endregion
    }
}
