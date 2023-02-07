using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Pet[] petStock = new Pet[5];
        public Form1()
        {
            InitializeComponent();
            LoadPetStock();
        }
        //deserielise xml and populate listbox with pet stock
        
        private void LoadPetStock()
        {
            if (System.IO.File.Exists("petstock.xml"))
            {
                using (var reader = new System.IO.StreamReader("petstock.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Pet[]));
                    petStock = (Pet[])serializer.Deserialize(reader);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Pet selectedPet = (Pet)petStockListBox.SelectedItem;
            if (selectedPet != null)
            {
                PetDetails petDetails = new PetDetails();
                petDetails.PetDetailsForm(selectedPet);
                petDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a pet to edit.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPetStock();
            petStockListBox.DataSource = petStock;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPet addPet = new AddPet(this);
            addPet.ShowDialog();
        }
    }
}
