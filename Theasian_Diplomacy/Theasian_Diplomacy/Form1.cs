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
        #region variable
        private Game game;
        #endregion

        #region generated methode
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            game = new Game();
            Refresh();
        }

        private void btnVille_des_Chats_info_Click(object sender, EventArgs e)
        {
            //open dialogue avec ville des chats
        }

        private void btnVille_des_Chiens_info_Click(object sender, EventArgs e)
        {
            //open dialogue avec ville des chiens
        }

        private void btnVille_des_marmottes_info_Click(object sender, EventArgs e)
        {
            //open dialogue avec ville des marmottes
        }

        private void btnVille_des_souris_info_Click(object sender, EventArgs e)
        {
            //open dialogue avec ville des souris
        }

        private void btnListFaction_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {
            game.NewGame();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            game.endTurn();
            Refresh();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseGame();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            game.Player.FirstName = txtPlayerName.Text;
            Refresh();
        }
        #endregion

        #region our methodes
        /// <summary>
        /// Close everything
        /// </summary>
        public void CloseGame()
        {
            game.Close();
        }

        /// <summary>
        /// Refresh all showed data on the screen
        /// </summary>
        private void Refresh()
        {
            lstFaction.Items.Clear();
            lstCharacter.Items.Clear();
            lstCity.Items.Clear();
            lstFactionLeaders.Items.Clear();

            foreach (Faction faction in game.Factions)
            {
                lstFaction.Items.Add(faction);

                foreach (Character character in faction.Members)
                {
                    lstCharacter.Items.Add(character);
                }
            }

            foreach (City city in game.Cities)
            {
                lstCity.Items.Add(city);
            }

            foreach (Faction faction in game.Factions)
            {
                lstFactionLeaders.Items.Add(faction.Leader);
            }

            lblPlayerGold.Text = "Or: " + game.Player.Faction.Gold.ToString() + " pièce(s).";
        }
        #endregion
    }
}