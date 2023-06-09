﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Reviews;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Review> Review { get; set; }

        public async ValueTask<Review> InsertReviewAsync(Review review) =>
            await InsertAsync<Review>(review);

        public IQueryable<Review> SelectAllReviews() => SelectAll<Review>();
    }
}
