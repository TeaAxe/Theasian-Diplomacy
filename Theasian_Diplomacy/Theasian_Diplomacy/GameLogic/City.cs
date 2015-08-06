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
        private Location linkedLocation;
        private int fortificationLevel;
        private int fortificationLevelMax;
<<<<<<< HEAD
        private int satisfaction;
=======
        private CityDB JIZZ;
>>>>>>> origin/master
        #endregion

        public City(string _name, int _income, Location _linkedLocation)
        {
            name = _name;
            income = _income;
            linkedLocation = _linkedLocation;
        }

        #region general methods
        public override string ToString()
        {
            return name + ", " + owner.ToString();
        }
        #endregion

        #region properties
        public Faction Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int Income
        {
            get { return income; }
        }

        public Location LinkedLocation
        {
            get { return linkedLocation; }
        }

        public string Name
        {
            get { return name; }
        }

        public int FortificationLevel
        {
            get { return fortificationLevel; }
        }

        public int FortificationLevelmax
        {
            get { return fortificationLevelMax; }
        }

        public int Satisfaction
        {
            get { return satisfaction; }
        }
        #endregion
    }
}