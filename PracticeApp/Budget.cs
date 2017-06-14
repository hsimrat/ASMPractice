using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Budget
    {
        public static List<decimal> totalExpense = new List<decimal>();
        public static decimal totalSalary;

        decimal totalexpense;
        public Expense createExpense(string csvfileDirectory,PaymentType paymtype)
        {
            Expense e = new Expense();
            e.directory = csvfileDirectory;
            e.PaymentType = paymtype;
            return e;
          
        }

        public FinancialInformation calculateFinance()
        {

            FinancialInformation financialInformation = new FinancialInformation();

            foreach (decimal expense in totalExpense)
            {
                totalexpense = expense + totalexpense;
            }

            financialInformation.ExpenseTotal = totalexpense;


            financialInformation.SalaryTotal = totalSalary;


            financialInformation.NetIncome = totalSalary - totalexpense;

            return financialInformation;



        }
    }
}
