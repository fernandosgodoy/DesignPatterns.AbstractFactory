namespace AbstractFactoryPattern.BusinessLogic.ConcreteFactory
{
    public abstract class EnterpriseCustomer
    {
        public abstract bool TotalInsurance { get; set; }
        public abstract bool Free { get; set; }
        public abstract bool FullTank { get; set; }
        public abstract decimal DailyRates { get; set; }

        public virtual void CheckForMalfunctions()
        {
            Console.WriteLine($"Checking Malfunctions OK in {this.GetType().Name}");
        }

        public virtual void CheckEngineOil()
        {
            Console.WriteLine($"Checking Oil OK in {this.GetType().Name}");
        }

        public virtual void Compare(ParticularCustomer particularCustomer)
        {
            Console.WriteLine($"Comparing the difference between daily rates. \n " +
                $"Single Person value: {particularCustomer.DailyRates} | Enterprise value: {this.DailyRates}");
        }
    }
}
