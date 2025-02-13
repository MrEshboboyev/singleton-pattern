using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoggingController(ILoggingService loggingService) : ControllerBase
{
    [HttpGet("log")]
    public IActionResult LogMessage(string message)
    {
        loggingService.Log(message);
        return Ok("Message logged successfully");
    }
}
