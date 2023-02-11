using CalculateHoursForWorkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDBLibrary
{
	public class DataEmployee
	{
		public static EmployeeModel GetCurrentEmployee()
		{
			EmployeeModel output = new EmployeeModel
			{
				FirstName = "Jack",
				LastName = "Peter",
				HourlyRate = 15
			};

			return output;
		}
	}
}
