'use strict';

(function () {
    angular
        .module('AngularRouting', ['ngRoute', 'ngResource'])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/', {
                templateUrl: '/ngViews/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/home', {
                templateUrl: '/ngViews/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            });
        })
})();