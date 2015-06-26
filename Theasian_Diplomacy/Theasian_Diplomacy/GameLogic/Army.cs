using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Army
    {
        #region variable
        private int soldierCount;
        private Faction owner;
        private Character general;
        private int experienceLevel = 0;
        private int equipmentQuality = 0;
        #endregion

        #region constructor
        public Army(Faction _faction, int _soldierCount, Character _general)
        {
            owner = _faction;
            soldierCount = _soldierCount;
            general = _general;
        }
        #endregion

        #region general methode
        public override string ToString()
        {
            return "Army of " + owner.ToString() + " led by " + general.ToString();
        }
        #endregion

        #region properties

        #endregion
    }
}
