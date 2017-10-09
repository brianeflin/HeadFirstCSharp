
namespace BeehiveManagementSystem
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightInMg { get; private set; }

        public Bee(double weightInMg)
        {
            WeightInMg = weightInMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return HoneyUnitsConsumedPerMg * WeightInMg;
        }
    }
}
