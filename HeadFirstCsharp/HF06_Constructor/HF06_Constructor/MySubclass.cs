using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF06_Constructor
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClaseNeedThis, int anothervalue) : base (baseClaseNeedThis)
        {
            MessageBox.Show("This is the subclass: " + baseClaseNeedThis + " and " + 
                anothervalue);
        }
    }
}
