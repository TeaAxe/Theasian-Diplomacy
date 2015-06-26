using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Game
    {
        private List<Faction> factions;
        private List<City> cities;

        public Game()
        {
            NewGame();
        }

        public List<Faction> Factions
        {
            get { return factions; }
        }

        public List<City> Cities
        {
            get { return cities; }
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
            City newCity = new City("La ville des chats");
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Player_House");
            newFaction.addMember(new Character("Generic", newFaction), true);
            newCity = new City("La ville des Souris");
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("People");
            newFaction.addMember(new Character("Yolo", newFaction), true);
            newCity = new City("La ville des Marmottes");
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Foreign_Nation");
            newFaction.addMember(new Character("swEG", newFaction), true);
            newCity = new City("La ville des chiens");
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

        }

        /// <summary>
        /// Close everything
        /// </summary>
        public void Close()
        {

        }
    }
}