﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {

        private IFilmDAL filmDAL;

        public FilmsController(IFilmDAL filmDAL)
        {
            this.filmDAL = filmDAL;
        }
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return null;
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(FilmSearch model)
        {
            /* Call the DAL and pass the values as a model back to the View */
            if (!string.IsNullOrEmpty(model.SelectedGenre))
            {
                IList<Film> films = filmDAL.GetFilmsBetween(model.SelectedGenre, model.MinimumLength, model.MaximumLength);
                model.Results = films;
            }
            else
            {
                model.Results = new List<Film>();
            }

            return View(model);
        }
    }
}