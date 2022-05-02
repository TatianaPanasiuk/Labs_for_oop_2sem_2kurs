using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace SEm2_LABA_2oop
{
    public partial class AddForm : Form
    {
        public List<Proizvoditel> proizvod1;
        public AddForm()
        {
            InitializeComponent();
            proizvod1 = new List<Proizvoditel>();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            var pro = new Proizvoditel();
            pro.Org = textBoxOrg.Text;
            pro.Strana = textBoxStrana.Text;
            pro.Adres = textBoxAders.Text;
            pro.Telefon = Telefon.Text;

            proizvod1.Add(pro);
            XmlSerializer ser= new XmlSerializer(typeof(List<Proizvoditel>));
            using (FileStream stream = new FileStream("Proizvoditeli.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(stream, proizvod1);
            }
        }
    }
}
