using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Progi.Test.Contracts.ServiceLibrary.Params;
using Progi.Test.ServiceLibrary.Dto;
using Progi.Test.ServiceLibrary.Enum;
using Progi.Test.ServiceLibrary.Interfaces;

namespace Progi.Test.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarCalculatorController : ControllerBase
    {

        private readonly ICarCalculatorService _carCalculatorService;

        public CarCalculatorController(ICarCalculatorService carCalculatorService) 
        {
            _carCalculatorService = carCalculatorService;
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationProblemDetails))]
        public async Task<ActionResult> Get([FromQuery] CarParameter param)
        {
            if (param is null)
            {
                return BadRequest(ModelState);
            }

            var response = await Task.Run(() => _carCalculatorService.CalculatePrice(param));

            return Ok(response); 
        }

    }
}
