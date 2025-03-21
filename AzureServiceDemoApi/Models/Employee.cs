﻿namespace AzureServiceDemoApi.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Department { get; set; }
		public string Position { get; set; }
		public decimal Salary { get; set; }
		public DateTime DateOfJoining { get; set; }
	}
}
