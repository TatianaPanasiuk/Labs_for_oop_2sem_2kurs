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

namespace SEm2_LABA_5oop
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
            AbstractTovar abstractTovar = new AbstractTovar();
            Proizvoditel Proizvod = abstractTovar.createProizvoditel(textBoxOrg.Text, textBoxStrana.Text, textBoxAders.Text, Telefon.Text);
       
            proizvod1.Add(Proizvod);
            XmlSerializer ser = new XmlSerializer(typeof(List<Proizvoditel>));
            using (FileStream stream = new FileStream("Proizvoditeli.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(stream, proizvod1);
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
