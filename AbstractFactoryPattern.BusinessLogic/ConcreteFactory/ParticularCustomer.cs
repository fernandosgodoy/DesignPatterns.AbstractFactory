namespace AbstractFactoryPattern.BusinessLogic.ConcreteFactory
{
    public abstract class ParticularCustomer
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

    }
}
