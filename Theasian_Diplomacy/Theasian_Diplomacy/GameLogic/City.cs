using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class City
    {
        Faction owner;
        string name;
        
        public City(string _name)
        {
            name = _name;
        }

        public Faction Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public override string ToString()
        {
            return name + " " + owner.ToString();
        }
    }
}