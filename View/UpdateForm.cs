using DataAccess.Models;
using Service.Repos;
using Service.ViewModels;
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
    public partial class UpdateForm : Form
    {
        public Animal Animal { get; set; }
        public AnimalType AnimalType { get; set; }
        public UpdateForm(Animal animal, AnimalType animalType)
        {
            Animal = animal;
            AnimalType = animalType;
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            lsbTempreture.Items.AddRange(Enum.GetNames(typeof(TempreturePreference)));
            txbName.Text = Animal.Name;
            txbSpecies.Text = Animal.Species;
            nudAge.Value = Animal.Age;
            nudCageNumber.Value = Animal.EnclosureNumber;
            lsbTempreture.SelectedIndex = (int)Animal.TempreturePreference;
            if (AnimalType == AnimalType.Mamal)
            {
               
                cbxPregnant.Visible = true;
                cbxPregnant.Checked = (Animal as Mamal).IsPregnant;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GetAnimal(out Animal animal))
            {
                try
                {
                    animal.ID = Animal.ID;
                    switch (AnimalType)
                    {
                        case AnimalType.Mamal:
                            MamalRepo.Update(animal as Mamal);
                            break;
                        case AnimalType.Bird:
                            BirdRepo.Update(animal as Bird);
                            break;
                        case AnimalType.Reptile:
                            ReptileRepo.Update(animal as Reptile);
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
                }
                
            }
            else
            {
                MessageBox.Show($"Some of the data fields have invalid value or aren't filled in", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool GetAnimal(out Animal animal)
        {
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
            switch (AnimalType)
            {
                case AnimalType.Mamal:
                    animal = new Mamal()
                    {
                        Name = name,
                        Age = age,
                        EnclosureNumber = cageNumber,
                        Species = species,
                        TempreturePreference = tempreturePreference,
                        IsPregnant = pregnant
                    }; break;
                case AnimalType.Bird:
                    animal = new Bird()
                    {
                        Name = name,
                        Age = age,
                        EnclosureNumber = cageNumber,
                        Species = species,
                        TempreturePreference = tempreturePreference,
                    }; break;
                case AnimalType.Reptile:
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
