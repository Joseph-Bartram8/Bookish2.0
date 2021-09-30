using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish_dataAccess;
using Microsoft.AspNet.Identity;

namespace Bookish.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryRepository libraryRepository = new LibraryRepository();

        public ActionResult Index()
        {
            var currentUser = User.Identity.GetUserId();
            var copiesBorrowed = libraryRepository.GetCopiesBorrowedByUser(Convert.ToInt32(currentUser));
            return View(copiesBorrowed);
        }

        public ActionResult About()
        {
            ViewBag.Message = "A digital library!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Cantact the Booksih library!";

            return View();
        }
    }
}