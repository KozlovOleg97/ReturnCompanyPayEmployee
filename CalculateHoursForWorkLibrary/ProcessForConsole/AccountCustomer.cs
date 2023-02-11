using CalculateHoursForWorkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHoursForWorkLibrary.ProcessForConsole
{
    public class AccountCustomer
    {
        public static void BillCustomer(List<TimeSheetEntryModel> timeSheets, CustomerModel customer)
        {
            double totalHours = TimeSheetProcessor.GetHoursWorksForCompany(timeSheets, customer.CustomerName);

            Console.WriteLine($"Simulating Sending email to {customer.CustomerName}");
            Console.WriteLine("Your bill is $" + (decimal)totalHours * customer.HourlyRateToBill + " for the hours worked.");
            Console.WriteLine();
        }
    }
}
