// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace CashOverflow.Ddemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]

        public string Get()
        {

            return "Cash flows...";
        }
    }
}
