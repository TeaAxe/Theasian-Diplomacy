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
        private string firstName; //No need for last names, it comes from faction
        private DateTime birthDate;
        private char [] sex = new char [1];
        private Faction faction;

        //these would vary depending on what every character knows about you...
        int charisma;
        int honor;
        int cruelty;
        #endregion

        #region constructor
        public Character(string _firstName, Faction _faction, DateTime _birthDate)
        {
            firstName = _firstName;
            faction = _faction;
            birthDate = _birthDate;
        }
        #endregion

        #region general methode
        public override string ToString()
        {
            return firstName + ", " + faction.ToString();
        }
        #endregion

        #region properties
        public Faction Faction
        {
            get { return faction; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        #endregion

    }
}