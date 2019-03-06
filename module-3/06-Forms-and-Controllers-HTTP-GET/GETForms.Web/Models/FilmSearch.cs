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
        public int MinimumLength { get; set; }


        private int? maximumLength;
        [Display(Name = "Maximum Length: ")]
        public int MaximumLength { get; set; }
        
       

        public string SelectedGenre { get; set; }

        [Display(Name = "Genre: ")]
        public List<SelectListItem> Genres = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Action"},
            new SelectListItem() { Text = "Animation"},
            new SelectListItem() { Text = "Children"},
            new SelectListItem() { Text = "Classics"},
            new SelectListItem() { Text = "Comedy"},
            new SelectListItem() { Text = "Documentary"},
            new SelectListItem() { Text = "Drama"},
            new SelectListItem() { Text = "Family"},
            new SelectListItem() { Text = "Foreign"},
            new SelectListItem() { Text = "Games"},
            new SelectListItem() { Text = "Horror"},
            new SelectListItem() { Text = "Music"},
            new SelectListItem() { Text = "New"},
            new SelectListItem() { Text = "Sci-Fi"},
            new SelectListItem() { Text = "Sports"},
            new SelectListItem() { Text = "Travel"}
        };

        public IList<Film> Results { get; set; }


    }
}
