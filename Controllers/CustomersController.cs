using Microsoft.AspNetCore.Mvc;

namespace CRMApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private static readonly string[] Customers = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCustomers")]
    public IEnumerable<string> Get()
    {
        return Customers;
    }
}
