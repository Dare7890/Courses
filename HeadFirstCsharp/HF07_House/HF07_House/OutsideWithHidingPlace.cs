using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlace { get; }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name,
            hot)
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
