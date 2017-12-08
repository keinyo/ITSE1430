/*
 * Jacob Lanham
 * ITSE 1430
 * 12-8-2017
 */
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieLib.Data.Sql;
using MovieLib.Web.Models;

namespace MovieLib.Web.Controllers
{
    public class MovieController : Controller
    {
        /// <summary>Initializes the _database field</summary>
        public MovieController() : this(GetDatabase())
        {
        }
        public MovieController( IMovieDatabase database )
        {
            _database = database;
        }

        /// <summary>Creates an empty view model</summary>
        /// <returns>The model.</returns>
        public ActionResult Add()
        {
            var model = new MovieViewModel();

            return View(model);
        }

        /// <summary>Attempts to Add the movie</summary>
        /// <param name="model">Movie to add</param>
        /// <returns>The model used</returns>
        [HttpPost]
        public ActionResult Add( MovieViewModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _database.Add(model.ToDomain());

                    return RedirectToAction("List");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        /// <summary>Creates a view model for the delete action</summary>
        /// <param name="id">ID of the movie to delete</param>
        /// <returns>The model, HttpNotFound if the movie was not found.</returns>
        public ActionResult Delete( int id )
        {
            var movie = _database.Get(id);
            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());
        }

        /// <summary> Attempts to delete a movie</summary>
        /// <param name="model">The movie to delete</param>
        /// <returns>Redirect to list, if failed to delete, error message along with the model</returns>
        [HttpPost]
        public ActionResult Delete( MovieViewModel model )
        {
                try
                {
                    _database.Remove(model.Id);

                    return RedirectToAction("List");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            return View(model);
        }

        /// <summary>Creates a view model for the edit action.</summary>
        /// <param name="id">ID of the movie to edit.</param>
        /// <returns>The model, HttpNotFound if the movie was not found.</returns>
        public ActionResult Edit( int id )
        {
            var movie = _database.Get(id);
            if (movie == null)
                return HttpNotFound();

            return View(movie.ToModel());
        }

        [HttpPost]
        public ActionResult Edit (MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _database.Update(model.ToDomain());

                    return RedirectToAction("List");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };
            return View(model);
        }

        // GET: Movie
        public ActionResult List()
        {
            var movies = _database.GetAll();

            return View(movies.ToModel().OrderBy(x => x.Title));
        }

        private static IMovieDatabase GetDatabase()
        {
            var connstring = ConfigurationManager.ConnectionStrings["MovieDatabase"];

            return new SqlMovieDatabase(connstring.ConnectionString);
        }

        private readonly IMovieDatabase _database;
    }
}