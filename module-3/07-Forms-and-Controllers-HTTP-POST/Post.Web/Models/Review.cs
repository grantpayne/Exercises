using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        public string Username { get; set; }

        public int Rating { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }
    }
}
