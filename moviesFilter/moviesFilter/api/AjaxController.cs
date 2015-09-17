using moviesFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace moviesFilter.api {
    public class AjaxController : ApiController {
        public static IList<Food> Foods = new List<Food> {
                new Food {Id = 1, Name = "Milk", Price = 1.24m },
                new Food {Id = 2, Name = "Eggs", Price = 2.33m },
                new Food {Id = 3, Name = "Orange juice", Price = 5.99m },
                new Food {Id = 4, Name = "Grapes", Price = 3.99m },
                new Food {Id = 5, Name = "Tesla Model S", Price = 89675.00m },
                new Food {Id = 6, Name = "Hats", Price = 19.00m },
                new Food {Id = 7, Name = "Bucket O' Nothing", Price = 9999.99m },
                new Food {Id = 8, Name = "Shirt", Price = 29.99m },
                new Food {Id = 9, Name = "Water", Price = 5.99m },
                new Food {Id = 10, Name = "Scarves made by Tibetan Monks, from the finest Tibetan yak fur", Price = 499999.99m },
                new Food {Id = 11, Name = "Yak Fur", Price = 0.99m },
                new Food {Id = 12, Name = "Marzipan", Price = 9.99m },
        };

        //[Route("api/food/{search}")]
        //public IList<Food> Get(string search) {
        //    return Foods;
        //    var all = new List<Food> {
        //    };
        //    return (from f in all
        //            where f.Name.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0
        //            select f).ToList();
        //}

        [Route("api/food/")]
        public IEnumerable<Food> Get() {
            return Foods;
        }

        [Route("api/food/{id}")]
        public Food Get(int id) {
            return (from f in Foods
                    where f.Id == id
                    select f).SingleOrDefault();
        }

        [Route("api/food/")]
        public HttpResponseMessage Post(Food food) {
            if (ModelState.IsValid) {
                Foods.Add(food);
                return Request.CreateResponse(HttpStatusCode.OK, food);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }
    }
}
