using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearch
    {
        [Display(Name = "Name: ")]
        public string Search { get; set; }


        [Display(Name = "Sort By: ")]
        public string SortBy { get; set; }


        public List<SelectListItem> SortByOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Last Name"},
            new SelectListItem() { Text = "email"},
            new SelectListItem() { Text = "active"},
        };

        public IList<Customer> Results { get; set; }
    }
}
