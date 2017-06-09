using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Expenditure
    {

       // private int amount=0;
       /// private string description;
       // private DateTime timestamp;
        private static readonly double GSTRate =0.16;
        private static readonly double CSTRate = 0.00;
        public static readonly double servicechargesforcash = 0.10;
        public int Amount { get; set; }
        public string Description { get; set; }

        public string TimeStamp { get; set; }

        public Expenditure()
        {
            Console.WriteLine("this is default constructor");
        }
        //public Expenditure(int amt,string desc , string timestmp)
        //{
        //    this.Amount = amt;
        //    this.Description = desc;
        //    this.TimeStamp = timestmp;

        //}
        protected  double CalculateGST()
        {
            return  Amount*GSTRate;
        }

        protected  double CalculateCST()
        {
            return Amount * CSTRate;
        }
        public override string ToString()
        {
                return  Amount +", "+ Description +", "+TimeStamp + "," + ExpenseType.FoodExpense+".";
        }

        protected void CheckPaymentType(ref PaymentType objpt)
        {
            CashExpenses objCashExp = new CashExpenses();

            switch (objpt)
            {

                case PaymentType.Cash:
                    objCashExp.ProcessCashExpenses();
                    break;
                case PaymentType.Card:
                    break;
                case PaymentType.NetBanking:
                    break;
                default:
                    break;
            }

        }

    }
    public enum ExpenseType
    {
        TravelExpense =1,
        FoodExpense=2,
        Misc=3,
        GroceryExpense=4

        
    };

    enum TransactionType
    {
        Payment=1,
        Receipts=2
    };

    public enum PaymentType
    {
        Cash = 1,
        Card = 2,
        NetBanking = 3

    };
    class CashExpenses : Expenditure
    {

        protected double CalculateServiceChrgforCash()
        {
            return Amount * servicechargesforcash;
        
        }

        public double ProcessCashExpenses()
        {

            return Amount + CalculateGST() + CalculateCST() + CalculateServiceChrgforCash();
        }
        
    }
    class CardExpenses : Expenditure
    {

        static readonly double servicechargesforcard = 0.14;

        private double CalculateServiceChrgforCard()
        {
            return Amount * servicechargesforcard;

        }
        protected double ProcessCardExpenses()
        {

            return Amount + CalculateGST() + CalculateCST() + CalculateServiceChrgforCard();
        }
    }

}
