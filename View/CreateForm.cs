using DataAccess.Models;
using Service.Repos;
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
    public partial class CreateForm : Form
    {
        int animalType = 0;
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            //Populates the list with the needed values
            lsbTempreture.Items.AddRange(Enum.GetNames(typeof(TempreturePreference)));
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            //Checks and updates the radiobuttons' state
            if (rbnMamals.Checked)
            {
                animalType = 0;
            }
            else if (rbnBirds.Checked)
            {
                animalType = 1;
            }
            else
            {
                animalType = 2;
            }
            ShowPregnant();
        }

        private void ShowPregnant()
        {
            //Makes the pregnant box show up only for animals
            cbxPregnant.Visible = animalType == 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GetAnimal(out Animal animal))
            {
                try
                {
                    switch (animalType)
                    {
                        case 0:
                            MamalRepo.Add(animal as Mamal);
                            break;
                        case 1:
                            BirdRepo.Add(animal as Bird);
                            break;
                        case 2:
                            ReptileRepo.Add(animal as Reptile);
                            break;
                        default:
                            break;
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    this.Close();
                    throw ex;
                    //Closes the form to avoid issues and rethrows the exception to the main form to be handled
                }
                
            }
            else
            {
                MessageBox.Show($"Some of the data fields have invalid value or aren't filled in", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool GetAnimal(out Animal animal)
        {
            //Checks if all of the inputs are acceptable and if so creates a new object
            string name = txbName.Text, species = txbSpecies.Text;
            int age = (int)nudAge.Value, cageNumber = (int)nudCageNumber.Value;
            bool pregnant = cbxPregnant.Checked;
            if (
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(species) ||
                lsbTempreture.SelectedIndex == -1
                )
            {
                animal = null;
                return false;
            }

            TempreturePreference tempreturePreference = (TempreturePreference)Enum.Parse(typeof(TempreturePreference), lsbTempreture.SelectedItem.ToString());
            switch (animalType)
            {
                case 0:
                    animal = new Mamal()
                    {
                        Name = name,
                        Age = age,
                        EnclosureNumber = cageNumber,
                        Species = species,
                        TempreturePreference = tempreturePreference,
                        IsPregnant = pregnant
                    }; break;
                case 1:
                    animal = new Bird()
                    {
                        Name = name,
                        Age = age,
                        EnclosureNumber = cageNumber,
                        Species = species,
                        TempreturePreference = tempreturePreference,
                    }; break;
                case 2:
                    animal = new Reptile()
                    {
                        Name = name,
                        Age = age,
                        EnclosureNumber = cageNumber,
                        Species = species,
                        TempreturePreference = tempreturePreference,
                    }; break;
                default:
                    animal = null;
                    break;
            }
            return true;
        }
    }
}
