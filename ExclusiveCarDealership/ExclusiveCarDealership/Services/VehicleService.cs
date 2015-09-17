using ExclusiveCarDealership.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExclusiveCarDealership.Services {
    public class VehicleService {
        private IRepository _repo;
        public VehicleService(IRepository repo) {
            _repo = repo;
        }

    }
}