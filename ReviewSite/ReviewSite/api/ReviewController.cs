using ReviewSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReviewSite.api {
    public class ReviewController : ApiController {
        private ReviewService _service;
        public ReviewController(ReviewService service) {
            _service = service;
        }

        //get all review
        public IEnumerable<ReviewDTO> Get() {
            return _service.ListReviews();
        }

        //update or insert new review
        public HttpResponseMessage Post(ReviewDTO review) {
            if (ModelState.IsValid) {
                if (review.Id >= 0) {
                    _service.EditReview(review);
                }
                else {
                    _service.AddReview(review);
                    return Request.CreateResponse(HttpStatusCode.OK, review);
                }

            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }
    }
}
