// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using Xeptions;

namespace CashOverflow.Ddemo.Models.Jobs.Exceptions
{
    public class NullJobexception : Xeption
    {
        public NullJobexception()
            : base(message: "Job is null")
        {}
    }
}
