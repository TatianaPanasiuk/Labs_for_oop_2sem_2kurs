using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace SEm2_LABA_2oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        int check = 0;

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            var nov = new List<Tovar>
            {
                new Tovar()
                {
                    Nazvanie = textBoxNazvanie.Text,
                    InvetarniNumber = textBoxInventNumber.Text,
                    
                    //razmer
                    Ves = textBoxVes.Text,
                    //tip
                    DataPostyplenia = dateTimePicker1.Text,
                    Colichestvo = trackBarColichestvo.Value,
                    Cena = textBoxCena.Text,
                    organization = textBoxOrg.Text,
                    strana = textBoxStrana.Text,
                    adres = textBoxAders.Text,
                    telefon = Telefon.Text,
                }
            };

            //if () {; }
            XmlSerializeWrapper.Serialize(nov, "tovari.xml");
            

        }

        private void trackBarColichestvo_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBarColichestvo.Value + "";
        }

        private void buttonIzFile_Click(object sender, EventArgs e)
        {
            
            var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Tovar>>("tovari.xml");
            richTextBox1.Text = $" Nazvanie: {deserializeUsers[0].Nazvanie};\n Invent Number: {deserializeUsers[0].InvetarniNumber};\n Ves: {deserializeUsers[0].Ves};\n" +
                $" Data postyplenia: {deserializeUsers[0].DataPostyplenia};\n Colichestvo: {deserializeUsers[0].Colichestvo};\n"+
                $" Cena: {deserializeUsers[0].Cena};\n Organization: {deserializeUsers[0].organization};\n" +
                $" Strana: {deserializeUsers[0].strana};\n Adres: {deserializeUsers[0].adres};\n Telefon: {deserializeUsers[0].telefon};\n" +
                $" Id: {deserializeUsers[0].Id};\n";

        }

        private void radioBig_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
            
        }

        private void radioSred_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
    }
}
