using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy
{
    class Faction
    {

        private string factionName;
        List<Character> members;

        public void Faction(string _factionName)
        {
            factionName = _factionName;
            members = new List<Character>();
        }


    }
}
