using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ViewForm : Form
    {
        Animal Animal;
        public ViewForm(Animal animal)
        {
            InitializeComponent();
            Animal = animal;

        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            lblAge.Text = Animal.Age.ToString();
            lblCageNumber.Text = Animal.EnclosureNumber.ToString();
            lblName.Text = Animal.Name;
            lblSpecies.Text = Animal.Species;
            lblTemp.Text = Animal.TempreturePreference.ToString();
            if (Animal is Mamal mamal)
            {

                cbxPregnant.Visible = true;
                cbxPregnant.Checked = mamal.IsPregnant;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPregnant_CheckedChanged(object sender, EventArgs e)
        {
            
            cbxPregnant.Checked = (Animal as Mamal).IsPregnant;
        }
    }
}
