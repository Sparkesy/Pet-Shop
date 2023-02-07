using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class PetDetails : Form
    {
        private Pet pet;

        public void PetDetailsForm(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
            speciesTextBox.Text = pet.Species;
            breedTextBox.Text = pet.Breed;
            colorTextBox.Text = pet.Color;
            ageNumericUpDown.Value = pet.Age;
            sexComboBox.SelectedItem = pet.Gender;
        }

        

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            pet.Species = speciesTextBox.Text;
            pet.Breed = breedTextBox.Text;
            pet.Color = colorTextBox.Text;
            pet.Age = (int)ageNumericUpDown.Value;
            pet.Gender = (string)sexComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
