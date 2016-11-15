using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Linq;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
 
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(mbox=>mbox.Genre);
            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Please provide movie ID");
            }
            else
            {
                var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

                if (movie == null)
                    return HttpNotFound();

                return View(movie);
            }
        }
    }
}