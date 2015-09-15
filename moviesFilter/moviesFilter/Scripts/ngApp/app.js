'use strict';

(function () {
    angular.module('Filters', []);
})();

(function () {
    angular.module('Filters').filter('unique', function () {
        return function (input) {
     
            console.log(input);
            //input.forEach(function (item) {
            //    console.log(item);
            //});
            //for (var i = 1; i < input.length; i++) {
            //    //console.log(input[i]);
            //    var curr = input[i].toLowerCase();
            //    var prev = input[i - 1].toLowerCase();

            //    if (curr !== prev) {
            //        console.log(curr);
            //        return curr;
            //    }
            //}
            //return input;
        }
    });
})();

//(function () {

//    angular.module('Filters').filter('startsWith', function () {
//        return function (input, expression) {
//            expression = expression.toLowerCase();
//            return input.filter(function (item) {
//                return item.toLowerCase().startsWith(expression);
//            });

//        };
//    });

//})();