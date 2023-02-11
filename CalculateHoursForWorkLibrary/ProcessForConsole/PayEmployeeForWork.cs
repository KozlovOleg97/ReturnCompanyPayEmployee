using CalculateHoursForWorkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHoursForWorkLibrary.ProcessForConsole
{
    public class PayEmployeeForWork
    {
        public static void PayEmployee(List<TimeSheetEntryModel> timeSheets, EmployeeModel employee)
        {
            decimal totalPay = CalculateEmployeePay.GetCalculateEmployeePay(timeSheets, employee);
            Console.WriteLine($"You will get paid ${totalPay}  for your time.");
            Console.WriteLine();
        }
    }
}
