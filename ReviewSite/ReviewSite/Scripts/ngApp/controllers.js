'use strict';

(function () {
    angular
        .module('AngularRouting')
        .controller('HomeController', function ($location, $resource, $http) {
            var self = this;
            self.message = 'Your one stop shop for all your imported Tibetan scarves, hand crafted from the finest Tibetan yak fur by Tibetan monks';

            var reviewApi = $resource('/api/review/:id');
            //to display or not review form
            self.display = function (name) {
                
            }

            //Get list of reviews
            self.reviews = reviewApi.query();

            //Post new review
            self.newReview = function () {
                //turns off dispaly new review form
                self.reviewForm = false;
                var newReview = new reviewApi({
                    Id: -1,
                    Rating: parseFloat(self.Rating),
                    Comment: self.Comment
                });
                newReview.$save(function (result) {
                    self.reviews.push(result);
                });
            }
            update
            self.updateReview = function () {
                self.editReviewForm = true;
            }

            //edit a review
            self.editReview = function () {
                self.editReviewForm = false;
                var originalReview = new reviewApi({
                    Id: self.Id,
                    Rating: parseFloat(self.Rating),
                    Comment: self.Comment
                });
                originalReview.$save();
            }
        });
})();