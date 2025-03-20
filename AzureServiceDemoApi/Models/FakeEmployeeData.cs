namespace AzureServiceDemoApi.Models
{
	public static class FakeEmployeeData
	{
		public static List<Employee> Employees = new List<Employee>
	{
		new Employee
		{
			Id = 1,
			FirstName = "John",
			LastName = "Doe",
			Email = "john.doe@example.com",
			PhoneNumber = "123-456-7890",
			Department = "IT",
			Position = "Software Engineer",
			Salary = 75000,
			DateOfJoining = new DateTime(2020, 6, 15)
		},
		new Employee
		{
			Id = 2,
			FirstName = "Jane",
			LastName = "Smith",
			Email = "jane.smith@example.com",
			PhoneNumber = "987-654-3210",
			Department = "HR",
			Position = "HR Manager",
			Salary = 68000,
			DateOfJoining = new DateTime(2018, 3, 22)
		},
		new Employee
		{
			Id = 3,
			FirstName = "Michael",
			LastName = "Johnson",
			Email = "michael.johnson@example.com",
			PhoneNumber = "555-666-7777",
			Department = "Finance",
			Position = "Financial Analyst",
			Salary = 72000,
			DateOfJoining = new DateTime(2019, 9, 10)
		}
	};
	}

}
