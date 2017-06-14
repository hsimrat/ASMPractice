using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Expense
    {

            // private int amount=0;
            /// private string description;
            // private DateTime timestamp;
            private static readonly double GSTRate = 0.16;
            private static readonly double CSTRate = 0.00;
            public static readonly double servicechargesforcash = 0.10;

            public string directory { get; set; }
            public PaymentType PaymentType { get; set; }
            public int Amount { get; set; }
            public string Description { get; set; }

            public string TimeStamp { get; set; }

           
            //public Expenditure(int amt,string desc , string timestmp)
            //{
            //    this.Amount = amt;
            //    this.Description = desc;
            //    this.TimeStamp = timestmp;

            //}
            protected double CalculateGST()
            {
                return Amount * GSTRate;
            }

            protected double CalculateCST()
            {
                return Amount * CSTRate;
            }
           
            protected PaymentType CheckPaymentType(ref PaymentType objpt)
            {

                switch (objpt)
                {

                    case PaymentType.Cash:
                        return PaymentType.Cash;
                    case PaymentType.CreditCard:
                        return PaymentType.CreditCard;
                    case PaymentType.NetBanking:
                        return PaymentType.NetBanking;
                    default:
                        return (dynamic)null;
                }

            }

            public void GrabExpenses()
            {
                Console.WriteLine("Grabing your expenses now..");
                string dateToday = DateTime.Now.ToString("yyyy-MM-dd+hh:mm");

                var reader = new StreamReader(File.OpenRead(directory));
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(values[1]);
                }
                listA.RemoveAt(0);

                var intList = listA.Select(x => decimal.Parse(x)).ToList();
                decimal total = intList.Sum();
                Budget.totalExpense.Add(total);

            }
    }

    public enum PaymentType
    {
        Cash = 1,
        CreditCard = 2,
        NetBanking = 3

    };
}
