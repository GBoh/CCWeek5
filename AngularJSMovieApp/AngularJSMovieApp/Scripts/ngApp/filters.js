(function () {

    angular.module('MyApp').filter('startsWith', function () {
        return function (input, expression) {
            expression = expression.toLowerCase();
            return input.filter(function (item) {
                return item.toLowerCase().startsWith(expression);
            });

        };
    });

})();