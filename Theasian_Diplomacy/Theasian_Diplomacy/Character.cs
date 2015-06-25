using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy
{
    class Character
    {
        private string firstName;
        //No need for last names, it comes from faction

        Faction faction;

        public Character(string _firstName, Faction _faction)
        {
            this.firstName = _firstName;
            this.faction = _faction;
        }

        public override string ToString()
        {
            return firstName + " " + faction.ToString();
        }


    }
}