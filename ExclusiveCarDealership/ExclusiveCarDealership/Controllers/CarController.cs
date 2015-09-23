using ExclusiveCarDealership.Domain;
using ExclusiveCarDealership.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExclusiveCarDealership.Controllers
{
    [Route("api/vehicles/", Name = "vehicleApi")]
    public class CarController : ApiController
    {
        private IRepository _repo;

        public CarController(IRepository repo) {
            _repo = repo;
        }

        public IList<Vehicle> Get() {
            return _repo.QueryCar().ToList();
        }

        public Vehicle Get(int id) {
            return (from v in _repo.QueryCar()
                    where v.Id == id
                    select v).SingleOrDefault();
        }
    }
}
