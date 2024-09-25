using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Director : Employee
    {
        public string Region { get; set; }
        public override double GetBonus()
        {
            return Wage + base.GetBonus();
        }
    }
}
