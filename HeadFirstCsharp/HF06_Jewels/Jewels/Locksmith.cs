using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenCombination = null;
        public void WriteDownCombination(string combination)
        {
            writtenCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.RecieveConstents(safeContents);
        }
    }
}
