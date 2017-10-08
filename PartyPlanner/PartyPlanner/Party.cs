
namespace PartyPlanner
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CostOfDecorations;

                if (NumberOfPeople > 12)
                    return totalCost + 100M;
                else
                    return totalCost;
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

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }
    }
}
