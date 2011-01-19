using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppHarborDemoApp.Models;

namespace AppHarborDemoApp.Controllers
{
    public partial class HomeController : Controller
    {
        private IAJRepository _db = new AJRepository();

        public ActionResult Index()
        {
            var vm = new CommentsVM();
            vm.Comments = _db.GetComments();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(AppHarborDemoApp.Models.Comment comment)
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
    }
}
