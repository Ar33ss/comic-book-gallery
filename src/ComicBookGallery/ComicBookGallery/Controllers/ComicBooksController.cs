using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null) {
                return HttpNotFound();
            }
            //ComicBook a = new ComicBook();
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) {
            //    return Redirect("/"); // redirect is an action
            //    //return new RedirectResult("/");
            //}
            //return Content("Hello world");
        }

    }
}