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
using System.Text.RegularExpressions;

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
                organization = Org.Text
                //strana = Stara.Text,
              // adres = Adres.Text,
               // telefon = Telefon.Text,
                }
            };

            if (checkBox1.Checked) { nov[0].Tip += "семена"; }
            if (checkBox2.Checked) {nov[0].Tip +=" сажинец"; }

            if (radioBig.Checked) {nov[0].Razmer += "Большой"; }
            if (radioSred.Checked) { nov[0].Razmer += "Средний"; }
            if (radioSmall.Checked) { nov[0].Razmer += "Маленький"; }
            XmlSerializeWrapper.Serialize(nov, "tovari.xml");
           

            if (String.IsNullOrEmpty(nov[0].Nazvanie) == true || String.IsNullOrEmpty(nov[0].InvetarniNumber) == true )//|| String.IsNullOrEmpty(nov[0].organization) == true || String.IsNullOrEmpty(nov[0].Cena) == true || String.IsNullOrEmpty(nov[0].Colichestvo.ToString()) == true || String.IsNullOrEmpty(nov[0].strana) == true || String.IsNullOrEmpty(nov[0].Ves) == true)
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
            var pro = XmlSerializeWrapper.Deserialize<List<Proizvoditel>>("proizvoditeli.xml");
            foreach (var elem in deserializeUsers)
            {
                richTextBox1.Text = $" Nazvanie: {elem.Nazvanie};\n" +
                    $" Invent Number: {elem.InvetarniNumber};\n" +
                    $" Ves: {elem.Ves};\n" +
                    $" Data postyplenia: {elem.DataPostyplenia};\n " +
                    $" Colichestvo: {elem.Colichestvo};\n" +
                    $" Cena: {elem.Cena};\n " +                
                    $" Id: {elem.Id};\n" +
                    $" Razmer: {elem.Razmer};\n Tip: {elem.Tip}";
                foreach (var item in pro)
                {
                    richTextBox1.Text += $" Strana: {item.strana};\n" +
                        $" Adres: {item.adres};\n" +
                        $" Telefon: {item.telefon};\n" +
                        $" Organization: {item.organization};\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBoxCena.Clear();
            textBoxNazvanie.Clear();
            textBoxInventNumber.Clear();                      
            textBoxVes.Clear();           
            label10.Text = "0";
            trackBarColichestvo.Value = 0;
            //Stara.Text = "";
            Org.Text = "";
            //Telefon.Text = "";
            //Adres.Clear();  
        }

        private void textBoxVes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                Convert.ToDouble(textBoxVes.Text);
                
            }
            catch(FormatException) { MessageBox.Show("Некоректные данные");  }
        }

        public static void inputNumber(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();


            ifrm.Show();
        }

        private void textBoxCena_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBoxCena.Text);

            }
            catch (FormatException) { MessageBox.Show("Некоректные данные"); }
        }

        private void textBoxInventNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBoxInventNumber.Text);

            }
            catch (FormatException) { MessageBox.Show("Некоректные данные"); }
        }

        public void updateOrg(ComboBox combobox)
        {
            var pro = XmlSerializeWrapper.Deserialize<Proizvoditel>("proizvoditeli.xml");
            object[] org1 = new object[1];
               org1[0] = pro.organization;
            Org.Items.AddRange(org1);   
            
            

        }

        private void update_Click(object sender, EventArgs e)
        {
           updateOrg(Org);
            
        }

       
    }
}
