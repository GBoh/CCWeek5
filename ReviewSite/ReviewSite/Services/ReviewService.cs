using AutoMapper;
using ReviewSite.Domain;
using ReviewSite.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewSite.Services {
    public class ReviewService {
        private IRepository _repo;

        public ReviewService(IRepository repo) {
            _repo = repo;
        }

        public void AddReview(ReviewDTO review) {
            var newReview = Mapper.Map<Review>(review);
            _repo.Add<Review>(newReview);
            _repo.SaveChanges();
        }

        public IList<ReviewDTO> ListReviews() {
            var dtoList = new List<ReviewDTO>();
            var reviews = _repo.Query<Review>().ToList();

            foreach (var item in reviews) {
                dtoList.Add(Mapper.Map<ReviewDTO>(item));
            }
            return dtoList as IList<ReviewDTO>;
        }

        public ReviewDTO GetReviewById(int id) {
            var reviews = _repo.Query<Review>();
            return Mapper.Map<ReviewDTO>((from r in reviews
                                   where r.Id == id
                                   select r).SingleOrDefault());
        }

        public void EditReview(ReviewDTO review) {
            var originalReview = _repo.Find<Review>(review.Id);
            originalReview.Rating = review.Rating;
            originalReview.Comment = review.Comment;
            _repo.SaveChanges();
        }
    }
}