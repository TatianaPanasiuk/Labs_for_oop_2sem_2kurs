using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SEm2_LABA_2oop
{
    public partial class Form2 : Form
    {
        public Form2()//String Data)
        {
            InitializeComponent();
          //  textBoxOrg.Text = Data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pro = new Proizvoditel();
            pro.organization = textBoxOrg.Text;
            //pro.strana = textBoxStrana.Text;
            //pro.adres = textBoxAders.Text;
            //pro.telefon = Telefon.Text;

            XmlSerializeWrapper.Serialize(pro, "proizvoditeli.xml");
            //using (StreamWriter writer = new StreamWriter("test.txt", false))
            //{
            //    writer.WriteLine(org, str, adr, tel);
            //}
        }
    }
}
