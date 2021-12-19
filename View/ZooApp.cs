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
    public partial class ZooApp : Form
    {
        List<Animal> Animals = new List<Animal>();
        bool showMamals = false;
        bool showReptiles = false;
        bool showBirds = false;
        List<SimpleVM> tableSource = new List<SimpleVM>();
        public ZooApp()
        {
            InitializeComponent();
        }

        private void ZooApp_Load(object sender, EventArgs e)
        {
            FetchAnimals();
            UpdateFilter();
        }

        private void FetchAnimals() //Takes all animals from the database
        {
            Animals = MamalRepo.ReadAll().Cast<Animal>().ToList();
            Animals.AddRange(BirdRepo.ReadAll().Cast<Animal>());
            Animals.AddRange(ReptileRepo.ReadAll().Cast<Animal>());
        }

        private void UpdateFilter() //Changes the global variables upon pressing some checkbox
        {
            showMamals = cbxMamals.Checked;
            showBirds = cbxBirds.Checked;
            showReptiles = cbxReptiles.Checked;
            FilterAnimals();
        }

        private void FilterAnimals() // filters the animals according to the category
        {
            IEnumerable<Animal> filtered = Animals.AsEnumerable();
            if(!showMamals)
            {
                filtered = filtered.Where(x => !(x is Mamal));
            }
            if (!showBirds)
            {
                filtered = filtered.Where(x => !(x is Bird));
            }
            if (!showReptiles)
            {
                filtered = filtered.Where(x => !(x is Reptile));
            }
            tableSource = SimpleVM.ConvertMany(filtered.ToList());
            ShowAnimals();
        }

        private void ShowAnimals() //Adds the needed viewmodels to the grid view
        {
            dgvData.DataSource = tableSource;
            dgvData.ClearSelection();
        }

        private void cbx_CheckedChanged(object sender, EventArgs e) //Event listener of checkboxes
        {
            UpdateFilter();
        }

        private void btnCreate_Click(object sender, EventArgs e) //For adding new objects with the help of the outher form
        {
            try
            {
                CreateForm createForm = new CreateForm();
                createForm.ShowDialog();
                FetchAnimals();
                UpdateFilter();
                MessageBox.Show("Animal added succsefully into the system", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error has occured: {ex.Message}", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

       
      
        private void btnDelete_Click(object sender, EventArgs e) //Deleting an animal
        {
            if (dgvData.SelectedRows.Count > 0) //Checks if there is selected animal
            {
                try
                {
                    int selectedIndex = (int)dgvData.SelectedRows[0].Cells[0].Value;
                    AnimalType animalType = (AnimalType)dgvData.SelectedRows[0].Cells[3].Value;
                    switch (animalType)
                    {
                        case AnimalType.Mamal:
                            MamalRepo.Delete(selectedIndex);
                            FetchAnimals();
                            UpdateFilter();
                            break;
                        case AnimalType.Bird:
                            BirdRepo.Delete(selectedIndex);
                            FetchAnimals();
                            UpdateFilter();
                            break;
                        case AnimalType.Reptile:
                            ReptileRepo.Delete(selectedIndex);
                            FetchAnimals();
                            UpdateFilter();
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Animal deleted succsefully from the system", "Animal Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error has occured: {ex.Message}", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No Animal selected", "Select Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = (int)dgvData.SelectedRows[0].Cells[0].Value;
                    AnimalType animalType = (AnimalType)dgvData.SelectedRows[0].Cells[3].Value;
                    Animal animal = null;
                    switch (animalType)
                    {
                        case AnimalType.Mamal:
                            animal = MamalRepo.Read(selectedIndex);
                            break;
                        case AnimalType.Bird:
                            animal = BirdRepo.Read(selectedIndex);
                            break;
                        case AnimalType.Reptile:
                            animal = ReptileRepo.Read(selectedIndex);
                            break;
                        default:
                            break;
                    }
                    ViewForm viewForm = new ViewForm(animal);
                    viewForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error has occured: {ex.Message}", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No Animal selected", "Select Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = (int)dgvData.SelectedRows[0].Cells[0].Value;
                    AnimalType animalType = (AnimalType)dgvData.SelectedRows[0].Cells[3].Value;
                    Animal animal = null;
                    switch (animalType)
                    {
                        case AnimalType.Mamal:
                            animal = MamalRepo.Read(selectedIndex);
                            break;
                        case AnimalType.Bird:
                            animal = BirdRepo.Read(selectedIndex);
                            break;
                        case AnimalType.Reptile:
                            animal = ReptileRepo.Read(selectedIndex);
                            break;
                        default:
                            break;
                    }
                    UpdateForm updateForm = new UpdateForm(animal, animalType);
                    updateForm.ShowDialog();
                    FetchAnimals();
                    UpdateFilter();
                    MessageBox.Show("Animal updated succsefully in the system", "Animal Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error has occured: {ex.Message}", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No Animal selected", "Select Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
