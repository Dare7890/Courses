using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    class Oponent
    {
        private Location myLocation { get; set; }
        private Random random { get; }

        public Oponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }

        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor hasExteriorDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                        myLocation = hasExteriorDoor.DoorLocation;
                }
                int rand = random.Next(myLocation.Exists.Length);
                myLocation = myLocation.Exists[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }
        public bool Check(Location location)
        {
            if (location != myLocation)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
