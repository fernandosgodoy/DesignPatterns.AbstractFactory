using AbstractFactoryPattern.BusinessLogic.ConcreteFactory;
using AbstractFactoryPattern.BusinessLogic.Domain;

namespace AbstractFactoryPattern.BusinessLogic.FactoryContracts
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
