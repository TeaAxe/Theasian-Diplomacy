using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Location
    {
        #region variable
        private int defendersAdvantage;
        private string description;
        private string name;
        #endregion

        public Location(string _name, string _description, int _defendersAdvantage = 0)
        {
            defendersAdvantage = _defendersAdvantage;
            description = _description;
            name = _name;
        }

        #region general methods
        //do battle?
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
        }

        public string Description
        {
            get { return description; }
        }
        #endregion
    }
}