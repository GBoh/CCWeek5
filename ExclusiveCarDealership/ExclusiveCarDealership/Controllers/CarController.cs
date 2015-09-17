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
    [Route("api/vehicles", Name = "VehicleApi")]
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

        [HttpPost]
        [Route("api/tesla/", Name = "PostTesla")]
        public HttpResponseMessage PostTesla(Tesla tesla) {
            if (ModelState.IsValid) {
                _repo.Add(tesla);
                _repo.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, tesla);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [HttpPost]
        [Route("api/rollsRoyce/", Name = "PostRollsRoyce")]
        public HttpResponseMessage PostRollsRoyce(RollsRoyce rollsRoyce) {
            if (ModelState.IsValid) {
                _repo.Add(rollsRoyce);
                _repo.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, rollsRoyce);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

    }
}
