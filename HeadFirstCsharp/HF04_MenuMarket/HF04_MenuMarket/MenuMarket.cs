using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF04_MenuMarket
{
    class MenuMarket
    {
        public Random Randomizer;
        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yelllow mustard", "brown mustard", "honey mustard",
            "mayo", "relish", "franch dressing"};
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread",
            "a roll"};

        public string GetMenuItem()
        {
            string randomMeats = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeats + " with " + randomCondiments + " with " + randomBreads;
        }
    }
}
