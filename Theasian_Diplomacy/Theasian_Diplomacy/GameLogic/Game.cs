using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Game
    {
        #region variable
        private Character player;
        private List<Faction> factions;
        private List<City> cities;
        #endregion

        #region general methods
        public Game()
        {
            NewGame();
        }

        /// <summary>
        /// Start a completely new game
        /// </summary>
        public void NewGame()
        {
            factions = new List<Faction>();
            cities = new List<City>();

            //Adds factions to the list, needs to come from a list
            Faction newFaction = new Faction("Barbarians");
            newFaction.addMember(new Character("John", newFaction), true);
            City newCity = new City("La ville des chats", 100);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Player_House");
            newFaction.addMember(new Character("Generic", newFaction), true);
            player = newFaction.Members.ElementAt(0);
            newCity = new City("La ville des Souris", 100);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("People");
            newFaction.addMember(new Character("Yolo", newFaction), true);
            newCity = new City("La ville des Marmottes", 100);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Foreign_Nation");
            newFaction.addMember(new Character("swEG", newFaction), true);
            newCity = new City("La ville des chiens", 100);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);
        }

        /// <summary>
        /// Closes everything
        /// </summary>
        public void Close()
        {

        }

        /// <summary>
        /// Ends the turn, simulates AI turns and starts a new turn
        /// </summary>
        public void endTurn()
        {
            foreach (City city in cities)
            {
                    city.Owner.Gold += city.Income;
            }

            //move units? or do they have move points and move when you click? maybe a mix with Civ system?
            //advance spy operations
            //doAI
        }
        #endregion

        #region properties
        public List<Faction> Factions
        {
            get { return factions; }
        }

        public List<City> Cities
        {
            get { return cities; }
        }

        public Character Player
        {
            get { return player; }
        }
        #endregion

    }
}