using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of the AddMedicament class
            AddMedicament med = new AddMedicament("Aspirin", "https://www.example.com/aspirin", "Tablete", 10.50f);

            // Set the Text property of each label to the corresponding field value of the med object
            Denumire.Text = med.getDenumire();
           // Prospect.Text = med.prospect;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
