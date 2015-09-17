'use strict';

(function () {
    angular
        .module('Filters')
        .controller('MovieController', function () {
            this.movies = [
                'Up',
                'UP',
                'up',
                'Pacific Rim',
                'Pacific rim',
                'Jurassic World',
                'jurassic world',
                'Alien',
                'alien',
                'Mad Max',
                'mad max',
                'Mad max',
            ];
        });
})();

(function () {
    angular
        .module('AngularAjax')
        .controller('AjaxController', function ($http, $resource) {
            var self = this;
            //self.item = $http

            var FoodApi = $resource('/api/food/:id');
            self.items = FoodApi.query();


            self.add = function () {
                var newFood = new FoodApi({
                    Name: self.Name,
                    Price: self.Price,
                });
                newFood.$save(function (result) {
                    self.items.push(result);
                });
            }


            //self.fetch = function () {
            //    if (self.search) {
            //        $http.get('/api/food/' + self.search)
            //            .success(function (data) {
            //                self.items = data;
            //            })
            //            .error(function () {
            //                console.log('There was an error');
            //            });
            //    }
            //}
        });
})();