using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly EmployeeContext _context;

    public WeatherForecastController(EmployeeContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        return _context.Employees.ToList();
    }
}
