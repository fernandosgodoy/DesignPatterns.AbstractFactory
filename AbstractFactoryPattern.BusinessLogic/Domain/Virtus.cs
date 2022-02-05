using AbstractFactoryPattern.BusinessLogic.ConcreteFactory;

namespace AbstractFactoryPattern.BusinessLogic.Domain
{
    class Virtus
        : ParticularCustomer
    {
        public override bool TotalInsurance { get; set; }

        public override bool Free { get; set; }

        public override bool FullTank { get; set; }
        public override decimal DailyRates { get; set; }
    }
}
