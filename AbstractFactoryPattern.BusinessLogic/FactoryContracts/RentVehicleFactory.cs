using AbstractFactoryPattern.BusinessLogic.ConcreteFactory;

namespace AbstractFactoryPattern.BusinessLogic.FactoryContracts
{
    public abstract class RentVehicleFactory
    {

        public abstract ParticularCustomer MakeParticularContract();
        public abstract EnterpriseCustomer MakeEnterpriseContract();

    }
}
