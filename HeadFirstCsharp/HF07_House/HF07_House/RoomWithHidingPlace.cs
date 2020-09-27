using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlace { get; }

        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : 
            base(name, decoration)
        {
            HidingPlace = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Можно спрятаться в " + HidingPlace;
            }
        }
    }
}
