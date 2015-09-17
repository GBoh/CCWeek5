using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Services {
    public class ReviewDTO {
        public int Id { get; set; }

        [Required]
        public double Rating { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}