namespace PartyPlanner
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
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

        public decimal CostOfDecorations
        {
            get
            {
                if (FancyDecorations)
                    return (NumberOfPeople * 15M) + 50M;
                else
                    return (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = 
                    (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople
                    + CostOfDecorations;

                if (HealthyOption)
                    totalCost *= 0.95M;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }

        private const decimal CostOfFoodPerPerson = 25M;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
    }
}
