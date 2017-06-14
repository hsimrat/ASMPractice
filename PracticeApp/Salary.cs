using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Salary
    {
        public Salary()
        {

        }
        public decimal salaryAmount { get; set; }
        public void GrabSalary()
        {
            Budget.totalSalary = salaryAmount;
        }

    }
}
