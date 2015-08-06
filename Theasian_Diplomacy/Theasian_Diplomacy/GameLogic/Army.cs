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
        Location currentLocation;
        #endregion

        #region constructor
        public Army(Faction _faction, int _soldierCount, Character _general, Location _currentLocation)
        {
            owner = _faction;
            soldierCount = _soldierCount;
            general = _general;
            currentLocation = _currentLocation;
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
