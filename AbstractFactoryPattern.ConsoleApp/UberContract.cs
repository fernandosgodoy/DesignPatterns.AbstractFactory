using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConsoleApp
{
    public class UberContract
        : RentVehicleFactory
    {
        public override EnterpriseCustomer MakeEnterpriseContract()
        {
            var vehicle = new TCross()
            {
                DailyRates = 27,
                FullTank = true,
                Free = false,
                TotalInsurance = true
            };
            Console.WriteLine($"Options to Enterprise Contract \n Vehicle: {vehicle.GetType().Name} \n");
            Console.WriteLine($"Free: {vehicle.Free} \n");
            Console.WriteLine($"Daily Rates: {vehicle.DailyRates} \n");

            return vehicle;
        }

        public override ParticularCustomer MakeParticularContract()
        {
            var vehicle = new Virtus()
            {
                DailyRates = 17,
                FullTank = true,
                Free = true,
                TotalInsurance = true
            };
            Console.WriteLine($"Options to Particular Contract \n Vehicle: {vehicle.GetType().Name} \n");
            Console.WriteLine($"Free: {vehicle.Free} \n");
            Console.WriteLine($"Daily Rates: {vehicle.DailyRates} \n");

            return vehicle;
        }
    }
}
