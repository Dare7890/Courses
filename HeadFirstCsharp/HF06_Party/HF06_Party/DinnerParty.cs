using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF06_Party
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        public const int costOfFoodPerPerson = 25;
        public const decimal discount = 0.95M;

        public DinnerParty(int numberOfPeople, bool fancyDecoration, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            return costOfBeveragesPerPerson = (HealthyOption) ? 5M : 20M;
        }

        public override decimal Cost
        {
            get
            {
                if (HealthyOption)
                {
                    decimal totalCost = base.Cost;
                    totalCost += (CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson)
                        * NumberOfPeople * discount;
                    return totalCost;
                }
                else
                {
                    decimal totalCost = base.Cost;
                    totalCost += (CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson)
                        * NumberOfPeople;
                    return totalCost;
                }
            }
        }
        }
}
