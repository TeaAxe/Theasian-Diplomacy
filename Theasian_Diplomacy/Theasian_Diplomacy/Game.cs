using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy
{
    class Game
    {
        private List<Faction> factions;

        public Game()
        {
            factions = new List<Faction>();

            //Adds factions to the list, needs to come from a list
            Faction newFaction = new Faction("Barbarians");
            newFaction.addMember(new Character("John", newFaction));
            factions.Add(newFaction);

            newFaction = new Faction("Player_House");
            newFaction.addMember(new Character("Generic", newFaction));
            factions.Add(newFaction);

            newFaction = new Faction("People");
            newFaction.addMember(new Character("Yolo", newFaction));
            factions.Add(newFaction);

            newFaction = new Faction("Foreign_Nation");
            newFaction.addMember(new Character("swEG", newFaction));
            factions.Add(newFaction);
        }

        public List<Faction> Factions
        {
            get { return factions; }
        }

    }
}