using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class BonusManager
    {
        private double _totalBonus { get; set; }

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}
