using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Character
    {
        private string firstName;
        //No need for last names, it comes from faction

        private Faction faction;

        public Character(string _firstName, Faction _faction)
        {
            firstName = _firstName;
            faction = _faction;
        }

        public override string ToString()
        {
            return firstName + ", " + faction.ToString();
        }


    }
}