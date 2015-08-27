using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            //using (TheasianDiplomacyDBEntities db = new TheasianDiplomacyDBEntities())
            //{ 
            TheasianDiplomacyDBEntities db = new TheasianDiplomacyDBEntities();

            LocationDB locationdb = new LocationDB();
            locationdb.defenderAdvantage = 1;
            locationdb.description = "asdf";
            locationdb.name = "St-Schtroumpf";
            db.LocationDB.Add(locationdb);
            db.SaveChanges();



            SkillDB test = new SkillDB();
            test.name = "qwer";
            db.SkillDB.Add(test);
            db.SaveChanges();

            GoalDB goalDB = new GoalDB();
            goalDB.description = "First Goal";
            goalDB.name = "first";

            db.GoalDB.Add(goalDB);
            db.SaveChanges();


            FactionGoalDB factionGoalDB = new FactionGoalDB();
            factionGoalDB.code = "pen";
            factionGoalDB.description = "first penis goal";
            factionGoalDB.name = "firstpenis";
            db.FactionGoalDB.Add(factionGoalDB);
            db.SaveChanges();

            CharacterDB characterDB = new CharacterDB();
            characterDB.firstName = "John";
            characterDB.honor = 2;
            characterDB.birthDate = new DateTime(1995, 5, 3);
            characterDB.cGoalDBID = goalDB.GoalDBID;
            characterDB.cLocationDBID = locationdb.LocationDBID;
            characterDB.isDead = false;
            characterDB.sex = "m";
            characterDB.cmemberFactionDBID = null;
            db.CharacterDB.Add(characterDB);

            //Adds factions to the list, needs to come from a list
            FactionDB factionDb = new FactionDB();
            factionDb.name = "Barbarians";
            factionDb.gold = 0;
            factionDb.fFactionGoalID = factionGoalDB.FactionGoalID;//mettre vrai ID
            factionDb.fCharacterDBID = characterDB.CharacterDBID;//mettre vrai ID
            //characterDB.cmemberFactionDBID = factionDb.FactionDBID;

            db.FactionDB.Add(factionDb);

            db.SaveChanges();

            Faction newFaction = new Faction("Barbarians");



            newFaction.addMember(new Character("John", newFaction, new DateTime()), true);
            Location newLocation = new Location("La ville des Chats", "Il y a beaucoup de chats ici!");
            City newCity = new City("La ville des Chats", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Player_House");
            newFaction.addMember(new Character("Generic", newFaction, new DateTime()), true);
            player = newFaction.Members.ElementAt(0);
            newLocation = new Location("La ville des Souris", "Il y a beaucoup de souris ici!");
            newCity = new City("La ville des Souris", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("People");
            newFaction.addMember(new Character("Yolo", newFaction, new DateTime()), true);
            newLocation = new Location("La ville des Marmottes", "Il y a beaucoup de marmottes ici!");
            newCity = new City("La ville des Marmottes", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            newFaction = new Faction("Foreign_Nation");
            newFaction.addMember(new Character("swEG", newFaction, new DateTime()), true);
            newLocation = new Location("La ville des Chiens", "Il y a beaucoup de chiens ici!");
            newCity = new City("La ville des Chiens", 100, newLocation);
            newCity.Owner = newFaction;
            cities.Add(newCity);
            factions.Add(newFaction);

            List<FactionDB> testAjoutFaction = (from fac in db.FactionDB select fac).ToList();

            foreach(FactionDB factionToAdd in testAjoutFaction){
                newFaction = new Faction(factionToAdd.name);
                newFaction.addMember(new Character("TestBD", newFaction, new DateTime()), true);
                factions.Add(newFaction);
            }


            //}
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