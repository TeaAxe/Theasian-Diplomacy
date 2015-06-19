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

        public void Character(string _firstName, Faction _faction)
        {
            firstName = _firstName;
            faction = _faction;
        }


    }
}
