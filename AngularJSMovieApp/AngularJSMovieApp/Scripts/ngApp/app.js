(function () {
    'use strict';

    angular.module('PetsApp', []);
    angular.module('DataBinding', []);
    angular.module('Calculator', []);
    angular.module('MyApp', ['ngRoute', 'MovieController' ]);
    angular
        .module('AngularRouting', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/', {
                templateUrl: '/ngViews/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'main'
            })
            .when('/viewA', {
                templateUrl: '/ngViews/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'main'
            })
            .when('/viewB/:id', {
                templateUrl: '/ngViews/viewB.html',
                controller: 'ViewBContMovieControllerroller',
                controllerAs: 'main'
            })
            .when('/movies', {
                templateUrl: '/ngViews/movies.html',
                controller: 'MovieController',
                controllerAs: 'main'
            })
            .otherwise({
                templateUrl: '/ngViews/notFound.html'
            });
        });
})();