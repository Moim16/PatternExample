using Aplicacion.Contrato;
using Aplicacion.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Patter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAsignacionHheeAplicationService _asignacionHheeAplicationService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAsignacionHheeAplicationService asignacionHheeAplicationService)
        {
            _logger = logger;
            this._asignacionHheeAplicationService = asignacionHheeAplicationService;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<AsignacionHheeDTO>> Get()
        {
            return await _asignacionHheeAplicationService.GetAll();
        }
        [HttpGet("GetById/{Id}")]
        public async Task<AsignacionHheeDTO> GetById(int Id)
        {
            return await _asignacionHheeAplicationService.GetById(Id);
        }
    }
}
