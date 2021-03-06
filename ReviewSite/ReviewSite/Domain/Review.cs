﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Domain {
    public class Review {
        public int Id { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}