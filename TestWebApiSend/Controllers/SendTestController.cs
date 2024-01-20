using Microsoft.AspNetCore.Mvc;
using Pix.Models.Pix;
using System.Text.Json;

namespace TestWebApiSend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendTestController : ControllerBase
    {
        private readonly ILogger<SendTestController> _logger;
        private readonly PixApiClient _pix;

        public SendTestController(ILogger<SendTestController> logger, PixApiClient pix)
        {
            _logger = logger;
            _pix = pix;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _pix.Get(); 
            return Ok(await res.Content.ReadAsStringAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PixWebhookModel content)
        {
            var res = await _pix.Post(JsonSerializer.Serialize(content));
            return Ok(await res.Content.ReadAsStringAsync());
        }
    }
}