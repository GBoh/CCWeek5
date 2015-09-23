'use strict';

(function () {
    angular
        .module('ExclusiveCarDealership')
        .controller('HomeController', ['VehicleService', function (VehicleService) {
            this.allCars = VehicleService.query();
        }]);
})();