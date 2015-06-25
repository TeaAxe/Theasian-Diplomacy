using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (Faction element in game.Factions)
            {
                lstFaction.Items.Add(element);
                
                foreach (Character el in element.Members)
                {
                    lstCharacter.Items.Add(el);
                }
            }
        }

        
    }
}
