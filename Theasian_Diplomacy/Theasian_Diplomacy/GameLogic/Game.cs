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
        private List<Location> locations;
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
            locations = new List<Location>();

            //Adds factions to the list, needs to come from a list
            Faction newFaction = new Faction("Barbarians");
            newFaction.addMember(new Character("John", newFaction, new DateTime()), true);
            Location newLocation = new Location("La ville des chats", "Il y a beaucoup de chats ici!");
            City newCity = new City("La ville des chats", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Player_House");
            newFaction.addMember(new Character("Generic", newFaction, new DateTime()), true);
            player = newFaction.Members.ElementAt(0);
            newLocation = new Location("La ville des souris", "Il y a beaucoup de souris ici!");
            newCity = new City("La ville des Souris", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("People");
            newFaction.addMember(new Character("Yolo", newFaction, new DateTime()), true);
            newLocation = new Location("La ville des marmottes", "Il y a beaucoup de marmottes ici!");
            newCity = new City("La ville des Marmottes", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Foreign_Nation");
            newFaction.addMember(new Character("swEG", newFaction, new DateTime()), true);
            newLocation = new Location("La ville des chiens", "Il y a beaucoup de chiens ici!");
            newCity = new City("La ville des chiens", 100, newLocation);
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