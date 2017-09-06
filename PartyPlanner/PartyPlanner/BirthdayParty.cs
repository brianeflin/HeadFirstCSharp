namespace PartyPlanner
{
    class BirthdayParty
    {
        private const decimal costOfFoodPerPerson = 25M;
        private const decimal costOfCakeWritingPerLetter = .25M;
        private const int smallCakeSize = 8;
        private const int largeCakeSize = 16;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public int CakeSize
        {
            get
            {
                if (NumberOfPeople <= 4)
                    return smallCakeSize;
                else
                    return largeCakeSize;
            }
        }

        public int MaxWritingLength
        {
            get
            {
                if (CakeSize == smallCakeSize)
                    return 16;
                else
                    return 40;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength)
                    return true;
                else
                    return false;
            }
        }

        private int ActualWritingLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength)
                    return MaxWritingLength;
                else
                    return CakeWriting.Length;
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
                decimal cakeCost;
                decimal totalCost;

                if (CakeSize == smallCakeSize)
                    cakeCost = 40M + ActualWritingLength * costOfCakeWritingPerLetter;
                else
                    cakeCost = 75M + ActualWritingLength * costOfCakeWritingPerLetter;
                
                totalCost = costOfFoodPerPerson * NumberOfPeople + CostOfDecorations + cakeCost;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
