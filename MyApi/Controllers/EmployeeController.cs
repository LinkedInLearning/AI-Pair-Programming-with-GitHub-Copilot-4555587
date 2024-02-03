using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers;

/// <summary>
/// EmployeeControllerクラスは、従業員のデータを管理します。
/// これは、従業員の情報の取得、更新、削除などの操作を提供します。
/// </summary>
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeContext _context;

    public EmployeeController(EmployeeContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        return _context.Employees.ToList();
    }

    [HttpPost]
    public ActionResult<Employee> Post(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();

        return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
    }
}
