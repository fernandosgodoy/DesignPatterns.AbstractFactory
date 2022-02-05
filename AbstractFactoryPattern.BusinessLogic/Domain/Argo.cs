using AbstractFactoryPattern.BusinessLogic.ConcreteFactory;

namespace AbstractFactoryPattern.BusinessLogic.Domain
{
    class Argo
        : EnterpriseCustomer
    {
        public override bool TotalInsurance { get; set; }
        public override bool Free { get; set; }

        public override bool FullTank { get; set; }
        public override decimal DailyRates { get; set; }
    }
}
