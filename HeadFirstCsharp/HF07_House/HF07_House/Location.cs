using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_House
{
    abstract class Location
    {
        public string Name { get; private set; }
        public Location[] Exists;

        public Location(string name)
        {
            Name = name;
        }

        public virtual string Description
        {
            get
            {
                string description = "Вы находитесь в " + Name + ". Вы видите двери, ведущие " +
                    "в: ";
                for (int i = 0; i < Exists.Length; i++)
                {
                    description += " " + Exists[i].Name;
                    if (i != Exists.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
