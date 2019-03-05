using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class ActorSearch
    {

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        public IList<Actor> Results { get; set; }

    }
}
