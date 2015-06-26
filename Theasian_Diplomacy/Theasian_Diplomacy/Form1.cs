using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theasian_Diplomacy.GameLogic;

namespace Theasian_Diplomacy
{
    public partial class frmMainMenu : Form
    {

        private Game game;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            game = new Game();
        }

        private void btnListFaction_Click(object sender, EventArgs e)
        {
            lstFaction.Items.Clear();
            lstCharacter.Items.Clear();
            lstCity.Items.Clear();

            foreach (Faction element in game.Factions)
            {
                lstFaction.Items.Add(element);
                
                foreach (Character el in element.Members)
                {
                    lstCharacter.Items.Add(el);
                }
            }

            foreach (City city in game.Cities)
            {
                lstCity.Items.Add(city);
            }
        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {
            game.NewGame();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        /// <summary>
        /// Close everything
        /// </summary>
        public void CloseGame()
        {
            game.Close();
            this.Close();
        }
        
    }
}
