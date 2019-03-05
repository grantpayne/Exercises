﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    {
        private IActorDAL actorDAL;

        public ActorsController(IActorDAL actorDAL)
        {
            this.actorDAL = actorDAL;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(ActorSearch model)
        {
            /* Call the DAL and pass the values as a model back to the View */
            if (!string.IsNullOrEmpty(model.LastName))
            {
                IList<Actor> actors = actorDAL.FindActors(model.LastName);
                model.Results = actors;
            }
            else
            {
                model.Results = new List<Actor>();
            }

            return View(model);
        }
    }
}