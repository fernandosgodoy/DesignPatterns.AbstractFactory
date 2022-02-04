using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConsoleApp
{
    public abstract class RentVehicleFactory
    {

        public abstract ParticularCustomer MakeParticularContract();
        public abstract EnterpriseCustomer MakeEnterpriseContract();

    }
}
