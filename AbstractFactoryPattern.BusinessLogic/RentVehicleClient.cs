using AbstractFactoryPattern.BusinessLogic.ConcreteFactory;
using AbstractFactoryPattern.BusinessLogic.FactoryContracts;

namespace AbstractFactoryPattern.BusinessLogic
{
    public class RentVehicleClient
    {
        private readonly ParticularCustomer particularCustomer;
        private readonly EnterpriseCustomer enterpriseCustomer;
        // Constructor
        public RentVehicleClient(RentVehicleFactory factory)
        {
            this.particularCustomer = factory.MakeParticularContract();
            this.enterpriseCustomer = factory.MakeEnterpriseContract();
        }
        public void Run()
        {
            this.enterpriseCustomer.Compare(this.particularCustomer);
        }
    }
}
