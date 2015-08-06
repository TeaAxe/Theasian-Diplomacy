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
    public partial class CityInfoForm : Form
    {
        public CityInfoForm(int _baseIncome, string _name, int _fortificationlevel, int _fortificationLevelMax, string _description, int _defendersAdvantage, int _satisfaction)
        {
            InitializeComponent();

            lblBaseIncome.Text = "Revenus de base: " + _baseIncome.ToString();
            lblCityName.Text = _name;
            lblDescription.Text = "Courte description: " + _description;
            lblFortificationLevel.Text = "Niveau de fortification: " + _fortificationlevel.ToString() + " (Avantage du terrain pour le défenseur: " + _defendersAdvantage.ToString() + ")";
            lblFortificationLevelMax.Text = "Niveau de fortification maximale: " + _fortificationLevelMax.ToString();
            lblSatisfaction.Text = "Niveau de satisfaction: " + _satisfaction.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
