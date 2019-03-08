using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {

        private ReviewSqlDal reviewSqlDal;

        public HomeController(ReviewSqlDal reviewSqlDal)
        {
            this.reviewSqlDal = reviewSqlDal;
        }

        // GET: Home
        public ActionResult Index()
        {
            IList<Review> reviews = new List<Review>();
            reviews = reviewSqlDal.GetAllReviews();

            return View(reviews);
        }        


        [HttpGet]
        public ActionResult NewReview()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewReview(Review model)
        {
            if (model.Rating < 0)
            {
                model.Rating = 0;
            }
            else if (model.Rating > 5)
            {
                model.Rating = 5;
            }

            reviewSqlDal.SaveReview(model);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
