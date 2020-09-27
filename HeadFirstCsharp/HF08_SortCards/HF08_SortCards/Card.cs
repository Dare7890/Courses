using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_SortCards
{
    class Card
    {
        public Suits Suits { get; set; }
        public Value Value { get; set; }

        public Card(Suits suits, Value value)
        {
            Suits = suits;
            Value = value;
        }

        public string Name
        {
            get
            {
                return Value + " of " + Suits;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
