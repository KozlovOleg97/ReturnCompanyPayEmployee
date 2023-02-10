using CalculateHoursForWorkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHoursForWorkLibrary
{
	public class CalculateEmployeePay
	{
		public static decimal GetLoop()
		{
			decimal loop = 0;

			return loop;
		}
		public static decimal GetCalculateEmployeePay(List<TimeSheetEntryModel> timeSheets, EmployeeModel employee)
		{
			decimal output = 0;
			double totalHours = 0;

			for (int i = 0; i < timeSheets.Count; i++)
			{
				totalHours += timeSheets[i].HoursWorked;
			}
			if (totalHours > 40)
			{
				output = (((decimal)(totalHours - 40) * (employee.HourlyRate * 1.5M)) + (40M * employee.HourlyRate));
			}
			else
			{
				output = (decimal)totalHours * employee.HourlyRate;
			}

			return output;
		}
	}
}
