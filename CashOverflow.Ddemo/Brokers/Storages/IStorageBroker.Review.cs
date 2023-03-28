// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Reviews;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Review> InsertReviewAsync(Review review);
        IQueryable<Review> SelectAllReviews();
    }
}
