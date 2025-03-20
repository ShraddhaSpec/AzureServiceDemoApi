using AzureServiceDemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceDemoApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EmployeeController : Controller
	{
		[HttpGet]
		public IActionResult GetEmployees()
		{
			return Ok(FakeEmployeeData.Employees);
		}

		[HttpGet("{id}")]
		public IActionResult GetEmployeeById(int id)
		{
			var employee = FakeEmployeeData.Employees.FirstOrDefault(e => e.Id == id);
			if (employee == null)
				return NotFound("Employee not found.");
			return Ok(employee);
		}
	}
}
