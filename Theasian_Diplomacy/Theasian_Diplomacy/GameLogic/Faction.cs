using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Faction
    {

        private string factionName;
        private List<Character> members;
        private Character leader;

        public Faction(string _factionName)
        {
            factionName = _factionName;
            members = new List<Character>();
        }

        /// <summary>
        /// Adds a member to the list
        /// </summary>
        /// <param name="_newMember"> The member to add </param>
        /// <param name="_isNewLeader"> If the added member should be set as the new leader </param>
        public void addMember(Character _newMember, bool _isNewLeader = false)
        {
            members.Add(_newMember);

            if (_isNewLeader)
            {
                leader = _newMember;
            }
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

        public Character Leader
        {
            get { return leader; }
        }


    }
}