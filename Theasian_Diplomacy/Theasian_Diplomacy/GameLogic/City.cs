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
        private int income;
        #endregion

        #region general methods

        

        public override string ToString()
        {
            return name + ", " + owner.ToString();
        }
        #endregion

        #region properties
        public City(string _name, int _income)
        {
            name = _name;
            income = _income;
        }

        public Faction Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int Income
        {
            get { return income; }
        }
        #endregion
    }
}