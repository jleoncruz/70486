﻿using System;
using OdeToFood.Models;
using System.Linq;

namespace OdeToFood.Tests.Features
{
    public class RestaurantRater
    {
        private Restaurant _restaurant;

        public RestaurantRater(Restaurant restaurant)
        {
            this._restaurant = restaurant;
        }

        public RatingResult ComputeResult(IRatingAlgorithm algorithm, int numberOfReviewsToUse)
        {
            var filteredReviews = _restaurant.Reviews.Take(numberOfReviewsToUse);

            //return algorithm.Compute(_restaurant.Reviews.ToList());
            return algorithm.Compute(filteredReviews.ToList());
        }
    }
}
