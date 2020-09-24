using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF06_BirthdayParty
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealthyOption { get; set; }
        private decimal costOfBeveragesPerPerson;
        private decimal costOfDecorations;
        public const int costOfFoodPerPerson = 25;
        public const decimal discount = 0.95M;

        public DinnerParty(int numberOfPeople, bool fancyDecoration, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecoration = fancyDecoration;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return costOfBeveragesPerPerson = (HealthyOption) ? 5M : 20M;
        }

        private decimal CalculateCostOfDecorations()
        {
            return costOfDecorations = (FancyDecoration) ? ((NumberOfPeople * 15.00M) + 50M) : ((NumberOfPeople * 7.50M) + 30M);
        }

        public decimal Cost()
        {
            if (HealthyOption)
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += (CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson)
                    * NumberOfPeople * discount;
                return totalCost;
            }
            else
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += (CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson)
                    * NumberOfPeople;
                return totalCost;
            }
        }
    }
}
