using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Interfaces;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public IActionResult ProcessValues([FromBody] List<string> values)
        {
            var results = _fizzBuzzService.ProcessValues(values);
            return Ok(results);
        }
    }
}
