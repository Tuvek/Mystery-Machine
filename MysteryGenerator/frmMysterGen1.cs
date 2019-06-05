using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MysteryGenerator
{
    public partial class frmMysteryGen1 : Form
    {
        public frmMysteryGen1()
        {
            InitializeComponent();
        }

        private void frmMysteryGen1_Load(object sender, EventArgs e)
        {

            loadData();

        }

        private void loadData()
        {

            txtLocationNumber.Text = "";
            txtMonstersNum.Text = "";
            txtTypesNum.Text = "";
            txtDescription.Text = "";

            String[] locations = File.ReadAllLines("data/locations.txt");
            lstLocations.Items.Clear();
            foreach (String loc in locations) { lstLocations.Items.Add(loc); }

            String[] monsters = File.ReadAllLines("data/monsters.txt");
            lstMonsters.Items.Clear();
            foreach (String monster in monsters) { lstMonsters.Items.Add(monster); }

            String[] types = File.ReadAllLines("data/types.txt");
            lstTypes.Items.Clear();
            foreach (String type in types) { lstTypes.Items.Add(type); }

        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {

            loadData();

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {

            Int32 numLocations = lstLocations.Items.Count;
            Int32 numMonsters = lstMonsters.Items.Count;
            Int32 numTypes = lstTypes.Items.Count;

            Random randomVar = new Random();
            Int32 rdmLocation = randomVar.Next(1, numLocations);
            Int32 rdmMonsters = randomVar.Next(1, numMonsters);
            Int32 rdmTypes = randomVar.Next(1, numTypes);

            txtLocationNumber.Text = rdmLocation.ToString();
            txtMonstersNum.Text = rdmMonsters.ToString();
            txtTypesNum.Text = rdmTypes.ToString();

            lstLocations.SelectedIndex = rdmLocation;
            lstMonsters.SelectedIndex = rdmMonsters;
            lstTypes.SelectedIndex = rdmTypes;

            txtDescription.Text = generateString();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            txtDescription.Text = generateString();

        }

        private String generateString() {

            String outPut = "";

            try
            { 
                String Location = lstLocations.SelectedItem.ToString();
                String Monster = lstMonsters.SelectedItem.ToString();
                String Type = lstTypes.SelectedItem.ToString();

                outPut = Monster + " in/at " + Location + " that wants " + Type;
            }
            catch (Exception ex)
            {
                outPut = "Not all options selected...";
            }

            return outPut;

        }

    }
}
