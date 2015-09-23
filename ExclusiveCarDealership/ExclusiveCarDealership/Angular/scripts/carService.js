(function () {
    angular
        .module('ExclusiveCarDealership')
        .service('VehicleService', ['$resource', 'routeUrls', function ($resource, routeUrls) {

            var vehicleApi = $resource(routeUrls.vehicleApi);

            self.post = function (vehicle) {
                new vehicleApi(vehicle).$save(function (data) {
                    console.log(data);
                });
            }

            self.query = function () {
                return vehicleApi.query();
            }
        }]);
})();