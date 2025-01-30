using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproOopsD4
{
    internal class Department : Employee 
    {

        public string DeptName { get; set; }

        public decimal Salary { get; set; }

        public override void Display()
        {
            base.Display(); 
            Console.WriteLine(DeptName + " " + Salary);
        }
    }
}
