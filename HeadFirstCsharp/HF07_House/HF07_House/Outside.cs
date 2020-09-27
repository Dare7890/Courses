using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    class Outside : Location
    {
        private bool Hot { get; }

        public Outside(string name, bool hot) : base(name)
        {
            Hot = hot;
        }

        public override string Description
        {
            get
            {
                string description = base.Description;
                if (Hot)
                    return description + " Тут очень жарко.";
                else
                    return description;
            }
        }
    }
}
