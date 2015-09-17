(function () {
    angular
        .module('ExclusiveCarDealership')
        .service('VehicleService', ['$resource', 'routeUrls',
            function ($resource, routeUrls) {
                var self = this;
                var vehicleApi = $resource(routeUrls.vehicleApi, {}, {});

            }]);
})();