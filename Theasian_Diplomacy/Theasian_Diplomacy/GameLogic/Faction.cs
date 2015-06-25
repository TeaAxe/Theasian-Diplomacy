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

        public Faction(string _factionName)
        {
            factionName = _factionName;
            members = new List<Character>();
        }

        public void addMember(Character _newMember)
        {
            members.Add(_newMember);
        }

        public string FactionName
        {
            get { return factionName; }
        }

        public override string ToString()
        {
            return factionName;
        }

        public List<Character> Members
        {
            get { return members; }
        }


    }
}