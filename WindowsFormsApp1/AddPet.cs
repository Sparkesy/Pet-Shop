using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddPet : Form
    {
        private Form1 form1;
        public AddPet(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string species = speciesTextBox.Text;
            string breed = breedTextBox.Text;
            string color = colorTextBox.Text;
            int age = (int)ageNumericUpDown.Value;
            string gender = (string)sexComboBox.SelectedItem;

            Pet newPet = new Pet(species, breed, color, age, gender);

            Pet[] updatedPetStock = new Pet[form1.petStock.Length + 1];
            form1.petStock.CopyTo(updatedPetStock, 0);
            updatedPetStock[form1.petStock.Length] = newPet;
            form1.petStock = updatedPetStock;

            using (var writer = new System.IO.StreamWriter("petstock.xml"))
            {
                var serializer = new XmlSerializer(typeof(Pet[]));
                serializer.Serialize(writer, form1.petStock);
            }

            form1.petStockListBox.DataSource = null;
            form1.petStockListBox.DataSource = form1.petStock;
            this.Close();
        }
    }
}
