using Microsoft.AspNetCore.Mvc;

namespace Residenthood.Admin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaseController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<LeaseController> _logger;

        public LeaseController(ILogger<LeaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLeases")]
        [Route("GetLeases")]
        public IEnumerable<Lease> Get()
        {
            _logger.LogInformation("Getting leases");
            return Enumerable.Range(1, 5).Select(index => new Lease
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}