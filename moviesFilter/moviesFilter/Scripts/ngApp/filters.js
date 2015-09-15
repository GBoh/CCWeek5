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