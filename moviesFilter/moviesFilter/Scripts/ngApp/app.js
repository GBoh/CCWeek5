'use strict';

(function () {
    angular.module('Filters', []);
    angular.module('AngularAjax', ['ngResource']);
})();

(function () {
    angular.module('Filters').filter('unique', function () {
        return function (input) {
            var uniqueArr = [];

            for (var i = 0; i < input.length; i++) {
                var curr = input[i].toLowerCase();

                if (input[i - 1] !== undefined) {
                    var prev = input[i - 1].toLowerCase();
                }

                if (curr !== prev) {
                    uniqueArr.push(input[i]);
                }
            }
            return uniqueArr;
        }
    });
})();