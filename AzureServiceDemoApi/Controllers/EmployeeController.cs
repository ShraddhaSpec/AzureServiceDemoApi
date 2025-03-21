using AzureServiceDemoApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceDemoApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class EmployeeController : Controller
	{
		[HttpGet]
		[AllowAnonymous]
		public IActionResult GetEmployees()
		{
			return Ok(FakeEmployeeData.Employees);
		}

		[HttpGet("{id}")]
		[AllowAnonymous]
		public IActionResult GetEmployeeById(int id)
		{
			var employee = FakeEmployeeData.Employees.FirstOrDefault(e => e.Id == id);
			if (employee == null)
				return NotFound("Employee not found.");
			return Ok(employee);
		}
	}
}
