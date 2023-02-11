using CalculateHoursForWorkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDBLibrary
{
	public class DataCompany
	{
		public static List<CustomerModel> GetCompany()
		{
			List<CustomerModel> output = new List<CustomerModel>();

			output.Add(new CustomerModel { CustomerName = "Acme", HourlyRateToBill = 150 });
			output.Add(new CustomerModel { CustomerName = "ABC", HourlyRateToBill = 125 });

			//jjjjjj
			return output;
		}
	}
}
