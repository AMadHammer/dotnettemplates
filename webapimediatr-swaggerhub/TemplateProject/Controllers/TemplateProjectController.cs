using MediatR;
using Microsoft.AspNetCore.Mvc;
using TemplateProject.Queries;

namespace TemplateProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateProjectController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IMediator _mediatr;
        private readonly ILogger<TemplateProjectController> _logger;

        public TemplateProjectController(ILogger<TemplateProjectController> logger, IMediator mediator)
        {
            _mediatr = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}