// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

namespace CashOverflow.Ddemo.Models.Jobs
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Level Level { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
