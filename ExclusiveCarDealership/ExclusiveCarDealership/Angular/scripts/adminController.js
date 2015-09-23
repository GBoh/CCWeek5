'use strict';
(function () {
    angular
        .module('ExclusiveCarDealership')
        .controller('AdminController', ['VehicleService', function (VehicleService) {
            var self = this;
            self.addCar = function () {
                VehicleService.post(self.newCar);
            }
        }])
})();