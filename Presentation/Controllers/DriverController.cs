using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DriverController : ControllerBase
{
    private readonly IDriverService _driverService;

    public DriverController(IDriverService driverService)
    {
        _driverService = driverService;
    }

    [Authorize]
    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(DriverDto user)
    {
        var createdDriver = await _driverService.CreateAsync(user);
        if (createdDriver == 0) return BadRequest();

        return Ok(createdDriver);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var driver = await _driverService.GetByIdAsync(id);
        if (driver == null) return NotFound();

        return Ok(driver);
    }
}