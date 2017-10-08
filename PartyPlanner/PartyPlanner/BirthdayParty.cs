namespace PartyPlanner
{
    class BirthdayParty : Party
    {
        private const decimal costOfFoodPerPerson = 25M;
        private const decimal costOfCakeWritingPerLetter = .25M;
        private const int smallCakeSize = 8;
        private const int largeCakeSize = 16;

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

        override public decimal Cost
        {
            get
            {
                decimal cakeCost;
                decimal totalCost;

                if (CakeSize == smallCakeSize)
                    cakeCost = 40M + ActualWritingLength * costOfCakeWritingPerLetter;
                else
                    cakeCost = 75M + ActualWritingLength * costOfCakeWritingPerLetter;
                
                totalCost = base.Cost + costOfFoodPerPerson * NumberOfPeople + cakeCost;

                return totalCost;
            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CakeWriting = cakeWriting;
        }
    }
}
