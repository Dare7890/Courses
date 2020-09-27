using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    class Room : Location
    {
        private string Decoration { get; }

        public Room (string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Здесь вы видите " + Decoration;
            }
        }
    }
}
