using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearch
    {

        [Display(Name = "Minimum Length: ")]
        public int? MinimumLength { get; set; }

        [Display(Name = "Maximum Length: ")]
        public int? MaximumLength { get; set; }

        public string SelectedGenre { get; set; }

        [Display(Name = "Genre: ")]
        public static List<SelectListItem> Genres = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Action", Value = "1" },
            new SelectListItem() { Text = "Animation", Value = "2" },
            new SelectListItem() { Text = "Children", Value = "3" },
            new SelectListItem() { Text = "Classics", Value = "4" },
            new SelectListItem() { Text = "Comedy", Value = "5" },
            new SelectListItem() { Text = "Documentary", Value = "6" },
            new SelectListItem() { Text = "Drama", Value = "7" },
            new SelectListItem() { Text = "Family", Value = "8" },
            new SelectListItem() { Text = "Foreign", Value = "9" },
            new SelectListItem() { Text = "Games", Value = "10" },
            new SelectListItem() { Text = "Horror", Value = "11" },
            new SelectListItem() { Text = "Music", Value = "12" },
            new SelectListItem() { Text = "New", Value = "13" },
            new SelectListItem() { Text = "Sci-Fi", Value = "14" },
            new SelectListItem() { Text = "Sports", Value = "15" },
            new SelectListItem() { Text = "Travel", Value = "16" }


        };




        public IList<Film> Results { get; set; }


    }
}
