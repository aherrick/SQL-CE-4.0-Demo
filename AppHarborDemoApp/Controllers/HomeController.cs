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
            var comments = _db.GetComments();
            return View(comments);
        }

        [HttpPost]
        public ActionResult Create(AppHarborDemoApp.Models.Comment comment)
        {
            comment.CreatedOn = DateTime.Now;

            _db.SaveComment(comment);

            return RedirectToAction("Index");
        }
    }
}
