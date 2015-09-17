using AutoMapper;
using ReviewSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewSite.Services {
    public class AutoMapperConfig {
        public static void RegisterMaps() {
            Mapper.CreateMap<ReviewDTO, Review>();
            Mapper.CreateMap<Review, ReviewDTO>();
        }
    }
}