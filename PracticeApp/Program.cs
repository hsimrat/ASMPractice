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
            Expenditure objExpen = new Expenditure { Amount = 100, Description = "taxi fare", TimeStamp=DateTime.Now.Day+" "+DateTime.Now.ToString("MMM")+" " + DateTime.Now.Year+""};
           
            Console.WriteLine("this is amount , Desc and Date time  is : {0} ",objExpen.ToString());
            //Console.WriteLine("this is description is : {0} ", objExpen.Description);
            //Console.WriteLine("this is date time is : {0} ", objExpen.TimeStamp);
            Console.WriteLine(Console.ReadKey());
        }
    }
}
