using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class City
    {
        #region variable
        private Faction owner;
        private string name;
        #endregion

        #region general methods

        public Faction Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public override string ToString()
        {
            return name + ", " + owner.ToString();
        }
        #endregion

        #region properties
        public City(string _name)
        {
            name = _name;
        }
        #endregion
    }
}