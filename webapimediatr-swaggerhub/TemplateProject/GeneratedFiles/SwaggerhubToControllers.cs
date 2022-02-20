


using MediatR;
using Microsoft.AspNetCore.Mvc;
using TemplateProject.Queries;
namespace TemplateProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateProjectGeneratedController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly ILogger<TemplateProjectController> _logger;
        public TemplateProjectGeneratedController(ILogger<TemplateProjectController> logger, IMediator mediator)
        {
            _mediatr = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger;
        }
        [HttpGet(Name = "/pet")]
        public async Task<IActionResult> Pet(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/pet/findByStatus")]
        public async Task<IActionResult> FindByStatus(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/pet/findByTags")]
        public async Task<IActionResult> FindByTags(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/pet/{petId}")]
        public async Task<IActionResult> GetPetId(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/pet/{petId}/uploadImage")]
        public async Task<IActionResult> UploadImage(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/store/inventory")]
        public async Task<IActionResult> Inventory(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/store/order")]
        public async Task<IActionResult> Order(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/store/order/{orderId}")]
        public async Task<IActionResult> GetOrderId(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user")]
        public async Task<IActionResult> User(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user/createWithArray")]
        public async Task<IActionResult> CreateWithArray(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user/createWithList")]
        public async Task<IActionResult> CreateWithList(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user/login")]
        public async Task<IActionResult> Login(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user/logout")]
        public async Task<IActionResult> Logout(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet(Name = "/user/{username}")]
        public async Task<IActionResult> GetUsername(int id)
        {
            List<WeatherForecast> result = await _mediatr.Send(new GetTemplateProjectQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

    } 
}



