using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateHoursForWorkLibrary.Models;

namespace CalculateHoursForWorkLibrary
{
    public static class TimeSheetProcessor
	{
		public static double GetHoursWorksForCompany(List<TimeSheetEntryModel> timeSheets, string companyName)
		{
			double output = 0;

			for (int i = 0; i < timeSheets.Count; i++)
			{
				if (timeSheets[i].WorkDone.ToLower().Contains(companyName.ToLower()))
				{
					output += timeSheets[i].HoursWorked;
				}
			}
			return output;
		}
	}
}
