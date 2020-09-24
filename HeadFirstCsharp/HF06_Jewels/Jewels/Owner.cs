using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Owner
    {
        private Jewels returnedContents;
        public void RecieveConstents(Jewels safeConstents)
        {
            returnedContents = safeConstents;
            Console.WriteLine("Thank you for returning my jewels! " + safeConstents.Spark());
        }
    }
}
