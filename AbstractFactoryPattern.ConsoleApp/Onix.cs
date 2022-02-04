using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConsoleApp
{
    class Onix
        : ParticularCustomer
    {
        public override bool TotalInsurance { get; set; }

        public override bool Free { get; set; }

        public override bool FullTank { get; set; }
        public override decimal DailyRates { get; set; }
    }
}
