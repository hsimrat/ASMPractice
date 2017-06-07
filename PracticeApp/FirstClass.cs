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

        public override string ToString()
        {
                return  Amount +", "+ Description +", "+TimeStamp+" ." + "";
        }

    }
    public enum ExpenseType
    {
        Cash =1,
        Card=2,
        NetBanking=3
        
    };
    class ExpenditureByCash : Expenditure
    {
      
        
    }
    class ExpenditureByCard
    { }

    class ExpenditureByFamily
    {
        
    }
}
