using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;


namespace SEm2_LABA_5oop
{
    public partial class Form2 : Form
    {
        public Form2()//String Data)
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Regex r1 = new Regex($@"{Nazvanie.Text}(\w*)");
            ListTovarov tovari = null;
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
            {
                tovari = ser.Deserialize(stream) as ListTovarov;
            }

            List<Tovar> searchResult = new List<Tovar>();

            foreach (var tov in tovari.Tovars)
            {
                MatchCollection matches = r1.Matches(tov.Nazvanie);
                if (matches.Count > 0)
                {
                    if (ndCenaOt.Value <= Convert.ToInt32(tov.Cena) && ndCenaDo.Value >= Convert.ToInt32(tov.Cena)) //continue;
                    {
                        if (checkBox2.Checked == true && String.IsNullOrEmpty(tov.TipSag) == false || checkBox3.Checked == true && String.IsNullOrEmpty(tov.TipSem) == false)
                            searchResult.Add(tov);
                    }

                }



            }
            if (searchResult.Count == 0)
            {
                MessageBox.Show("Мы не нашли подобных записей :c", "Поиск завершился неудачей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }

            IEnumerable<Tovar> ordered = null;

            ordered = searchResult.OrderBy(p => p.Nazvanie);
            foreach (Tovar item in ordered)
                listBox1.Items.Add(item.Result);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
