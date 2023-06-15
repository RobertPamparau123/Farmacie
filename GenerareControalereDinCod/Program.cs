using System;
using System.Windows.Forms;
using System.Windows;
using Farmacie;
using System.Drawing;
using System.Configuration;

namespace GenerareControalereDinCod
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            FormularMedicament form1 = new FormularMedicament();
            form1.Show();
            Application.Run();
        }
    }

    public class FormularMedicament : Form
    {
        private Label lblDenumire;
        private TextBox txtDenumire;

        private Label lblProspect;
        private TextBox txtProspect;

        private Button btnAfiseaza;
        private Label lblMedicament;
        private const int LATIME_CONTROL = 160;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;


        public FormularMedicament()
        {
            //setare proprietati
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Adauga Medicament";

            //adaugare control de tip Label pentru 'Lungime';
            lblDenumire = new Label();
            lblDenumire.Width = LATIME_CONTROL;
            lblDenumire.Text = "Denumire:";
            lblDenumire.BackColor = Color.LightYellow;
            this.Controls.Add(lblDenumire);

            //adaugare control de tip TextBox pentru 'Lungime';
            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtDenumire);


            //adaugare control de tip Label pentru 'Latime';
            lblProspect = new Label();
            lblProspect.Width = LATIME_CONTROL;
            lblProspect.Text = "Prospect:";
            lblProspect.Top = DIMENSIUNE_PAS_Y;
            lblProspect.BackColor = Color.LightYellow;
            this.Controls.Add(lblProspect);

            //adaugare control de tip TextBox pentru 'Latime'
            txtProspect = new TextBox();
            txtProspect.Width = LATIME_CONTROL;
            txtProspect.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtProspect);

            //adaugare control de tip Button
            btnAfiseaza = new Button();
            btnAfiseaza.Width = LATIME_CONTROL;
            btnAfiseaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            btnAfiseaza.Text = "Afiseaza";
            // "Click" este un *event* in clasa Button
            // si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            // Acesta este motivul utilizarii operatorului +=
            btnAfiseaza.Click += OnButtonClicked; // numele metodei este utilizat fara ()
                                                    // pentru a indica ca se transmite adresa functiei si nu este un apel de functie
            this.Controls.Add(btnAfiseaza);

            // adaugare control de tip Label
            lblMedicament = new Label();
            lblMedicament.Width = LATIME_CONTROL;
            lblMedicament.Height = 70;
            lblMedicament.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 3 * DIMENSIUNE_PAS_Y);
            lblMedicament.BackColor = Color.LightYellow;
            lblMedicament.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblMedicament);

            // adaugare handlere pentru evenimentele SizeChanged si FormClosed ale formei
            this.SizeChanged += OnFormSizeChanged;
            this.FormClosed += OnFormClosed;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnCalculeaza
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularGeometrie 
            string denumire = txtDenumire.Text;
            string prospect = txtProspect.Text;

            AddMedicament d = new AddMedicament(denumire, prospect,"dasasdasda",50000);
            lblMedicament.Text = "MEdicamentul este  = " + d.Info();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminMedicamente = new AdministrareMedicamente_FisierText(numeFisier);
            adminMedicamente.AddMedicament(d);
        }

        private void OnFormSizeChanged(object sender, EventArgs e)
        {
            // obiectul *sender* este FormularGeometrie
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului SizeChanged
            // al clasei FormularGeometrie catre subscriber-ul curent care este tot forma FormularGeometrie 
            txtDenumire.Text = this.Width.ToString();
            txtProspect.Text = this.Height.ToString();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
