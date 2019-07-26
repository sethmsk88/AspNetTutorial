using AspNetTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie); // return the movie object to the view
            // return Content("Testing"); // Show only the text I put in the helper method Content
            // return HttpNotFound(); // show a 404 page
            // return new EmptyResult(); // return nothing
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); // redirect to another page with URL arguments
        }
    }
}