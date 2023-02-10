using System;
using CalculateHoursForWorkLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateHoursForWorkLibrary.Models;
using CalculateHoursForWorkLibrary.ProcessForConsole;
using FakeDBLibrary;

namespace ConsoleUI
{
    class Program
	{
		static void Main(string[] args)
		{
			List<TimeSheetEntryModel> timeSheets = LoadTimesSheetsContext.GetLoadTimesSheetsContext();
			List<CustomerModel> customers = DataCompany.GetCompany();
			EmployeeModel currentEmployee = DataEmployee.GetCurrentEmployee();

			customers.ForEach(x => AccountCustomer.BillCustomer(timeSheets, x));

			PayEmployeeForWork.PayEmployee(timeSheets, currentEmployee);
			
			Console.WriteLine();
			Console.Write("Press any key to exit application...");
			Console.ReadKey();
		}
	}
}
