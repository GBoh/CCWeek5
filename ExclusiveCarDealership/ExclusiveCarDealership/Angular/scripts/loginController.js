'use strict';
(function () {
    angular
        .module('ExclusiveCarDealership')
        .controller('LoginController', ['$http', '$location', function ($http, $location) {
            var self = this;
            self.login = function () {
                $http.post('/token', 'grant_type=password&username=' + main.username + '&password=' + main.password, {
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded'
                    }
                })
                .success(function (data) {
                    token = data.access_token;
                    $http.defaults.headers.common.Authorization = 'Bearer ' + token;
                    $location.path('/admin');
                })
                .error(function () {
                    console.error('Error logging in.');
                });
            };
        }]);
})();