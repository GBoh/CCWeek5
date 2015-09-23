'use strict';

(function () {
    angular
        .module('ExclusiveCarDealership', ['ngRoute', 'ngResource'])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/', {
                templateUrl: '/Angular/views/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/home', {
                templateUrl: '/Angular/views/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/login', {
                templateUrl: '/Angular/views/login.html',
                controller: 'LoginController',
                controllerAs: 'main'
            })
            .when('/admin',{
                templateUrl: '/Angular/views/admin.html',
                controller: 'AdminController',
                controllerAs: 'main'
            })
            .otherwise({
                templateUrl: '/Angular/views/notFound.html'
            });
        });
})();