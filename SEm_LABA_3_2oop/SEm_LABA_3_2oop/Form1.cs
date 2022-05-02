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
        Timer timerForCountSchet;
        Timer timerForLastAction;
        public string lastAction;
        public int counter = 0;


        public ListTovarov tovari;
        public Form1()
        {
            InitializeComponent();
            tovari = new ListTovarov();
            timerForCountSchet = new Timer() { Interval = 1000 };
            timerForCountSchet.Tick += timerSchetCount_Tick;
            timerForCountSchet.Start();
            timerForLastAction = new Timer() { Interval = 1000 };
            timerForLastAction.Tick += timerLastAction_Tick;
            timerForLastAction.Start();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        Tovar tovar = new Tovar();

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            lastAction = "Сохранение данных";
           
            Tovar tov = new Tovar
            {
                Nazvanie = textBoxNazvanie.Text,
                inventNumber = textBoxInventNumber.Text,
                Cena = textBoxCena.Text,
                Ves = textBoxVes.Text,
                Data = dateTimePicker1.Value,
                Colichestvo = trackBarColichestvo.Value,
                Proizvoditeli = new Proizvoditel
                {
                    Adres = Adres.Text,
                    Org = Org.Text,
                    Strana = Strana.Text,
                    Telefon = Telefon.Text
                }
            };

            if (radioBig.Checked) tov.Razmer += " большой";
            if (radioSred.Checked) tov.Razmer += " средний";
            if (radioSmall.Checked) tov.Razmer += " маленький";
            if (checkBox1.Checked) tov.TipSag += "Сажинец ";
            if (checkBox2.Checked) tov.TipSem += "Семена ";

            tov.Result = "Nazvanie: "+ tov.Nazvanie+";"+ "InventNumber: " + tov.inventNumber+";"+ "Razmer: " + tov.Razmer+";" + "Tip: " + tov.TipSag + tov.TipSem + ";" + "Cena: " + tov.Cena + "; Ves: " + tov.Ves+ ";" +
                "Data postuplenia: " + tov.Data+ ";" + "Colichestvo: " + tov.Colichestvo+ ";" +
                "Adres: " + tov.Proizvoditeli.Adres+ ";" + "Organizacia: " + tov.Proizvoditeli.Org+ ";" + "Strana: " + tov.Proizvoditeli.Strana+ ";" + "Telefon: " + tov.Proizvoditeli.Telefon;
            tovari.Tovars.Add(tov);

            XmlSerializer serializer = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, tovari);
            }
           
            if(String.IsNullOrEmpty(textBoxNazvanie.Text) == true || String.IsNullOrEmpty(textBoxInventNumber.Text) == true ||
                String.IsNullOrEmpty(textBoxCena.Text) == true || String.IsNullOrEmpty(textBoxVes.Text) == true||
                String.IsNullOrEmpty(Adres.Text) == true || String.IsNullOrEmpty(Org.Text) == true || String.IsNullOrEmpty(Strana.Text) == true
                 )
            {
                MessageBox.Show("Заполните все поля");
            }

        }

        private void trackBarColichestvo_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBarColichestvo.Value + "";
        }

        private void buttonIzFile_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            counter = 0;
            XmlSerializer serializer = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
            {
                tovari = serializer.Deserialize(stream) as ListTovarov;
            }
            foreach (var elem in tovari.Tovars)
            {
                listBox1.Items.Add(elem.Result);
                 counter++;
            }
            lastAction = "Загрузка данных";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCena.Clear();
            textBoxInventNumber.Clear();
            textBoxNazvanie.Clear();
            textBoxVes.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioBig.Checked = false;
            radioSred.Checked = false;
            radioSmall.Checked = false;
            Strana.Clear();
            Org.Clear();
            Adres.Clear();
            Telefon.Clear();
            label10.Text = "0";
            trackBarColichestvo.Value = 0;
            listBox1.Items.Clear();
            lastAction = "очистка полей";

        }

        private void textBoxVes_KeyPress(object sender, KeyPressEventArgs e)
        {
            tovar.inputNumber(e);
        }


       


        private void add_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show();
        }

        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            tovar.inputNumber(e);
        }

        private void textBoxInventNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            tovar.inputNumber(e);
        }

        //public void updateOrg(ComboBox combobox)
        //{

        //}

        private void textBoxNazvanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            tovar.inputLetters(e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void poiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 search = new Form2();
            search.ShowDialog(this);
        }

        private void DataoolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari= ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Data);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);

            lastAction = "Сортировка по дате";
        }

        private void nazvanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari = ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Nazvanie);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);

            lastAction = "Сортировка по названию";

        }
        private void StranaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari = ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Proizvoditeli.Strana);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);

            lastAction = "Сортировка по стране";
        }




        private void oProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laba 3?\n Panasiuk T.S.");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buttonSaveInFile_Click(null, null);
            lastAction = "Сохранение данных";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Текущее время - " + DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            buttonIzFile_Click(null, null);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
           
        }



        void timerSchetCount_Tick(object sender, EventArgs e)
        {
            if (tovari != null) toolStripStatusLabel3.Text = $"Tоваров в памяти: {counter}";
            else toolStripStatusLabel3.Text = "0";

        }
        void timerLastAction_Tick(object sender, EventArgs e)
        {
            if (tovari != null) toolStripStatusLabel2.Text = $"Последнее действие: {lastAction}";
            else toolStripStatusLabel2.Text = "-";
        }

        
    }
}
