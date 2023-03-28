// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

namespace CashOverflow.Ddemo.Models.Reviews
{
    public class Review
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public int Stars { get; set; }
        public string Thoughts { get; set; }
    }
}
