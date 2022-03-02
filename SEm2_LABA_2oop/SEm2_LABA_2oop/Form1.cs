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

       

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            var nov = new List<Tovar>()
            {
                new Tovar(){
                Nazvanie = textBoxNazvanie.Text,
                InvetarniNumber = textBoxInventNumber.Text,
                Ves = textBoxVes.Text,
                DataPostyplenia = dateTimePicker1.Text,
                Colichestvo = trackBarColichestvo.Value,
                Cena = textBoxCena.Text,
                organization = textBoxOrg.Text,
                strana = textBoxStrana.Text,
                adres = textBoxAders.Text,
                telefon = Telefon.Text, }
            };

            if (checkBox1.Checked) { nov[0].Tip += "семена"; }
            if (checkBox2.Checked) {nov[0].Tip +=" сажинец"; }

            if (radioBig.Checked) {nov[0].Razmer += "Большой"; }
            if (radioSred.Checked) { nov[0].Razmer += "Средний"; }
            if (radioSmall.Checked) { nov[0].Razmer += "Маленький"; }
            XmlSerializeWrapper.Serialize(nov, "tovari.xml");

            if (String.IsNullOrEmpty(nov[0].Nazvanie) == true || String.IsNullOrEmpty(nov[0].InvetarniNumber) == true || String.IsNullOrEmpty(nov[0].organization) == true || String.IsNullOrEmpty(nov[0].Cena) == true || String.IsNullOrEmpty(nov[0].Colichestvo.ToString()) == true || String.IsNullOrEmpty(nov[0].strana) == true || String.IsNullOrEmpty(nov[0].Ves) == true)
            {
                MessageBox.Show("Заполните все поля!");
            }
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
                $" Id: {deserializeUsers[0].Id};\n" +
                $" Razmer: {deserializeUsers[0].Razmer};\n Tip: {deserializeUsers[0].Tip}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAders.Clear();
            textBoxCena.Clear();
            textBoxNazvanie.Clear();
            textBoxInventNumber.Clear();
            textBoxOrg.Clear();
            textBoxStrana.Clear();
            textBoxVes.Clear();
            Telefon.Clear();
            label10.Text = "0";
            trackBarColichestvo.Value = 0;
        }

        private void textBoxVes_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
