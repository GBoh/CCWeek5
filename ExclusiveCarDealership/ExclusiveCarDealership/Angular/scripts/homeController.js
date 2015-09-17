'use strict';

(function () {
    angular
        .module('ExclusiveCarDealership')
        .controller('HomeController', ['$location', 'VehicleService', function ($location, VehicleService) {
            this.allCars = VehicleService.query();
        }]);

})();