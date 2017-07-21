using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecorations { get; set; }
        public decimal Discount { get; set; }

        public const decimal CostOfFoodPerPerson = 25M;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5M;
                Discount = 0.05M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
                Discount = 0M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public decimal CalculateCost()
        {
            decimal subtotal = (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople
                               + CostOfDecorations;
            return subtotal * (1M - Discount);
        }
    }
}
