using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConsoleApp
{
    /// <summary>
    /// Concrete Factory Class 1
    /// </summary>
    public class SingleContract
        : RentVehicleFactory
    {
        public override EnterpriseCustomer MakeEnterpriseContract()
        {
            var vehicle = new Argo()
            {
                DailyRates = 13,
                FullTank = true,
                Free = true,
                TotalInsurance = true
            };
            Console.WriteLine($"Options to Enterprise Contract \n Vehicle: {vehicle.GetType().Name} \n");
            Console.WriteLine($"Free: {vehicle.Free} \n");
            Console.WriteLine($"Daily Rates: {vehicle.DailyRates} \n");

            return vehicle;
        }

        public override ParticularCustomer MakeParticularContract()
        {
            var vehicle = new Onix()
            {
                DailyRates = 12,
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
