using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Budget exampleBudget = new Budget();

            //Adding an expense by directing budget.computeTotalExpenses() method to payment type and directory
            Expense exampleCreditCardExpenses = exampleBudget.createExpense(@"D:\expensecsv/test.csv",PaymentType.Cash);

            //executing d expense's method to grab the data from the excel sheet 
            exampleCreditCardExpenses.GrabExpenses();


            Salary objSalary = new Salary();
            objSalary.salaryAmount = 1000;
            objSalary.GrabSalary();

            FinancialInformation hsFinancialInformation = exampleBudget.calculateFinance();

            Console.WriteLine(hsFinancialInformation.ExpenseTotal);
            Console.WriteLine(hsFinancialInformation.SalaryTotal);
            Console.WriteLine(hsFinancialInformation.NetIncome);
            Console.ReadKey();


            //Expenditure objExpen = new Expenditure { Amount = 100, Description = "taxi fare", TimeStamp=DateTime.Now.Day+" "+DateTime.Now.ToString("MMM")+" " + DateTime.Now.Year+""};
           
            //Console.WriteLine("this is amount , Desc and Date time  is : {0} ",objExpen.ToString());
            ////Console.WriteLine("this is description is : {0} ", objExpen.Description);
            ////Console.WriteLine("this is date time is : {0} ", objExpen.TimeStamp);
            //Console.WriteLine(Console.ReadKey());
        }
    }
}
