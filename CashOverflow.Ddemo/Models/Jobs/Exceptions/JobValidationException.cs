// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using Xeptions;

namespace CashOverflow.Ddemo.Models.Jobs.Exceptions
{
    public class JobValidationException : Xeption
    {
        public JobValidationException(Xeption innerException)
            : base(message: "Job validation error occurred, fix the errors and try again.", innerException)
        {}
    }
}
