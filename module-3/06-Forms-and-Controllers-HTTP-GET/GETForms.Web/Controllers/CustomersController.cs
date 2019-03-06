using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAL customerDAL;

        public CustomersController(ICustomerDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }

        public ActionResult Index(CustomerSearch model)
        {
            return View(model);
        }

        public ActionResult SearchResult(CustomerSearch model)
        {
            model.Results = customerDAL.SearchForCustomers(model.Search, model.SortBy);
            return View(model);
        }
    }
}