using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConsoleApp
{
    internal class Client
    {
        private readonly ParticularCustomer particularCustomer;
        private readonly EnterpriseCustomer enterpriseCustomer;
        // Constructor
        public Client(RentVehicleFactory factory)
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
