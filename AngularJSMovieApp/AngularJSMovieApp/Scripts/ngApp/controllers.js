(function () {
    'use-strict'
    //petshop
    angular
        .module('PetsApp')
        .controller('PetsController', function () {
            this.petsCat = [
                //array 0 dogs
                {
                    categoryName: 'Dogs', petsArr: [
                      { id: 1, name: 'Rover', imgUrl: 'https://pbs.twimg.com/profile_images/585733410838163457/jusb106_.jpg' },
                      { id: 2, name: 'Fido', imgUrl: 'https://static-s.aa-cdn.net/img/ios/383939191/22094511553bbeefc34943a822e01928?v=1' },
                      { id: 3, name: 'The Dark Lord Snuggles', imgUrl: 'http://barkpost-assets.s3.amazonaws.com/wp-content/uploads/2013/11/grumpy-dog-11.jpg' },
                    ]
                },

                //array 1 bunnies
                {
                    categoryName: 'Bunnies', petsArr: [
                        { id: 1, name: 'Sir Biggles Worth', imgUrl: 'https://pbs.twimg.com/profile_images/3477311286/30acf1d62497337fe1fe5f7d60fe3058.jpeg' },
                        { id: 2, name: 'Fluffzilla', imgUrl: 'http://www.furandfeather.co.uk/uploads/news/id244/REX-Chinrex.jpg' },
                        { id: 3, name: 'Steve', imgUrl: 'http://static.tumblr.com/xqxwexr/yY0lokkjo/skip.png' },
                    ]
                }
            ];
        });

    angular
        .module('DataBinding')
        .controller('FavoriteColorController', function () {
            //default color
            this.color = 'salmon';

            //change color
            this.pickColor = function (color) {
                this.color = color;
            }
        });

    //way two that uses scope
    //angular
    //    .module('Calculator')
    //    .controller('CalculatorController', function ($scope) {
    //        this.total = function () { return parseFloat($scope.num1) + parseFloat($scope.num2); }
    //    });


    //way three
    angular
        .module('Calculator')
        .controller('CalculatorController', function () {

            Object.defineProperty(this, 'total', { get: function () { return this.num1 + this.num2 } });
        });


    //Movies controller
    //angular
    //    .module('MovieApp')
    //    .controller('MovieListController', function () {
    //        this.movies = [
    //            { id: 1, title: 'Batman', director: 'Notal' },
    //            { id: 2, title: 'Alien', director: 'Scott' },
    //            { id: 3, title: 'Star Wars', director: 'Lucas' },
    //            { id: 4, title: 'Transformers', director: 'Bay' },
    //        ];
    //    });
})();


(function () {
    'use-strict'
    angular
        .module('AngularRouting')
        .controller('ViewAController', function ($location) {
            this.message = 'Hello from View A!';

            this.move = function (id) {
                $location.path('viewB/' + id);
            };
        });
    angular
        .module('AngularRouting')
        .controller('ViewBController', function ($routeParams) {
            this.message = 'Hello from View B! you requested id ' + $routeParams.id;
        });

    angular
        .module('AngularRouting')
        .controller('MovieController', function ($location) {
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
            ]
        });

})();