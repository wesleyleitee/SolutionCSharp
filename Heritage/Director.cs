using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Director : Employee
    {
        public override double GetBonus()
        {
            return Wage + (Wage * 0.1);
        }
    }
}
