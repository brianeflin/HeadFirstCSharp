namespace PartyPlanner
{
    class DinnerParty : Party
    {
        private const decimal CostOfFoodPerPerson = 25M;

        public bool HealthyOption { get; set; }

        public decimal CostOfBeveragesPerPerson
        {
            get
            {
                if (HealthyOption)
                    return 5M;
                else
                    return 20M;
            }
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost + (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople;

                if (HealthyOption)
                    totalCost *= 0.95M;

                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
            : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }
    }
}
