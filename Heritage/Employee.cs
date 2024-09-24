using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Employee
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Wage { get; set; }

        public virtual double GetBonus()
        {
            return Wage * 0.1;
        }
    }
}
