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
        ApplicationParameters form1Params;
        Timer timerForCountSchet;
        Timer timerForLastAction;
        public string lastAction;
        public int counter = 0;


        public ListTovarov tovari;
        public List<Proizvoditel> proizvoditeli;
        public Form1()
        {
            InitializeComponent();
            tovari = new ListTovarov();
            proizvoditeli = new List<Proizvoditel>();
            timerForCountSchet = new Timer() { Interval = 1000 };
            timerForCountSchet.Tick += timerSchetCount_Tick;
            timerForCountSchet.Start();
            timerForLastAction = new Timer() { Interval = 1000 };
            timerForLastAction.Tick += timerLastAction_Tick;
            timerForLastAction.Start();

        }
        private static Form1 _instance;

        public static Form1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Form1();
            }
            return _instance;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            form1Params = ApplicationParameters.GetInstance();
        }
        
        Tovar tovar = new Tovar();

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            lastAction = "Сохранение данных";
            AbstractTovar abstractTovar = new AbstractTovar();
            ProizvoditelBuilder proizvoditel = new ProizvoditelBuilder();
            ProizvoditelDirector proizvoditelDirector = new ProizvoditelDirector(proizvoditel);                
            Proizvoditel proiz = proizvoditel.getProizvoditel();
            Tovar tovar = abstractTovar.createTovar(textBoxNazvanie.Text, textBoxInventNumber.Text, textBoxCena.Text, textBoxVes.Text, trackBarColichestvo.Value, dateTimePicker1.Value);

            foreach(RadioButton rb in gb1.Controls)
            {
                if (rb.Checked) tovar.Razmer = rb.Text;
            }
            if (checkBox1.Checked) tovar.TipSem += "Семена";
            if (checkBox1.Checked) tovar.TipSag += "Сажинец";
         
            Regex r2 = new Regex(cbOrg.Text);
            List<Proizvoditel> proizvoditeli1 = null;
            XmlSerializer ser = new XmlSerializer(typeof(List<Proizvoditel>));
            using (FileStream stream = new FileStream("Proizvoditeli.xml", FileMode.Open))
            {
                proizvoditeli1 = ser.Deserialize(stream) as List<Proizvoditel>;
            }
            
            var searchOrgResult = from p in proizvoditeli1
                                  where p.Org == cbOrg.Text
                                  select p;
            foreach (var p in searchOrgResult) {
                tovar.Result = "Nazvanie: " + tovar.Nazvanie + "; " + "InventNumber: " + tovar.inventNumber + "; " + "Razmer: " + tovar.Razmer + "; " + "Tip: " + tovar.TipSag + tovar.TipSem + "; " + "Cena: " + tovar.Cena + "; Ves: " + tovar.Ves + "; " +
                    "Data postuplenia: " + tovar.Data + ";" + " Colichestvo: " + tovar.Colichestvo + "; " +
                    "Adres: " + p.Adres + "; " + "Organizacia: " + p.Org + "; " + "Strana: " + p.Strana + "; " + "Telefon: " + p.Telefon;
            }
            tovari.Tovars.Add(tovar);
            XmlSerializer serializer = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, tovari);
            }

            if (String.IsNullOrEmpty(textBoxNazvanie.Text) == true || String.IsNullOrEmpty(textBoxInventNumber.Text) == true ||
                    String.IsNullOrEmpty(textBoxCena.Text) == true || String.IsNullOrEmpty(textBoxVes.Text) == true)
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
            counter = 0;
            lastAction = "Загрузка данных";
            listBox1.Items.Clear();
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
           Form ifrm = new AddForm();
            ifrm.Show();
            lastAction = "добавлена организация";
        }

        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            tovar.inputNumber(e);
        }

        private void textBoxInventNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            tovar.inputNumber(e);
        }

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
            lastAction = "Сортировка по дате";
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari= ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Data);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);
        }

        private void nazvanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastAction = "Сортировка по названию";
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari = ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Nazvanie);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);

        }
        private void StranaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastAction = "Сортировка по стране";
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(ListTovarov));
            using (FileStream stream = new FileStream("tovari.xml", FileMode.Open))
                tovari = ser.Deserialize(stream) as ListTovarov;

            IEnumerable<Tovar> ordered = tovari.Tovars.OrderBy(p => p.Proizvoditeli.Strana);
            foreach (var tov in ordered)
                listBox1.Items.Add(tov.Result);
        }

        private void oProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Laba 4\n 2 FIT 8\n Panasiuk T.S.");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buttonSaveInFile_Click(null, null);
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

        private void button2_Click(object sender, EventArgs e)
        {
                     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void updateOrg(ComboBox combobox)
        {
            XmlSerializer pro = new XmlSerializer(typeof(List<Proizvoditel>));
            using (FileStream stream = new FileStream("Proizvoditeli.xml", FileMode.Open))
            {
               proizvoditeli = pro.Deserialize(stream) as List<Proizvoditel>;
            }

            foreach (var item in proizvoditeli)
            {
                cbOrg.Items.Add(item.Org);
            }                  
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateOrg(cbOrg);
        }
        private void Prototype_Click(object sender, EventArgs e)
        {
            Prototype prototype = new ConcretePrototype1(textBoxNazvanie.Text, textBoxInventNumber.Text, textBoxCena.Text, textBoxVes.Text, trackBarColichestvo.Value, dateTimePicker1.Value );

            prototype.Result = "Nazvanie: " + prototype.Nazvanie + "\n" + "InventNumber: " + prototype.inventNumber + "\n" + "Cena:" + prototype.Cena + "\n" + "Ves:" + prototype.Ves + "\n" + "Colichestvo:" + prototype.Colichestvo + "\n" + "Data:" + prototype.Data;

            Prototype clone = prototype.Clone();



            clone = prototype.Clone();

            MessageBox.Show(prototype.Result);

            listBox1.Text = ("Nazvanie: " + clone.Nazvanie + "\n" + "InventNumber: " + clone.inventNumber + "\n" + "Cena:" + clone.Cena + "\n" + "Ves:" + clone.Ves + "\n" + "Colichestvo:" + clone.Colichestvo + "\n" + "Data:" + clone.Data);


        }

        void toolStripStatusLabel1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Текущее время - " + DateTime.Now.ToString();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                  $"{form1Params.height} - высота основной формы;\n" +                 
                  $"{form1Params.width} - ширина основной формы\n" +
                  $"{form1Params.bgColor} - цвет фона\n",
                  "Свойства основной формы",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
          );
        }
    }
}
