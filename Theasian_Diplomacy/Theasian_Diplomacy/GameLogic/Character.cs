using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Character
    {
        #region variable
        private string firstName;
        //No need for last names, it comes from faction

        private Faction faction;
        #endregion

        #region constructor
        public Character(string _firstName, Faction _faction)
        {
            firstName = _firstName;
            faction = _faction;
        }
        #endregion

        #region general methode
        public override string ToString()
        {
            return firstName + ", " + faction.ToString();
        }
        #endregion

        #region properties
        #endregion

    }
}