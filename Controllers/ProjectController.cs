using Microsoft.AspNetCore.Mvc;

namespace AzureAppSample1.Controllers;

[ApiController]
[Route("projects")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSomeData()
    {
        return Ok("Success");
    }
}