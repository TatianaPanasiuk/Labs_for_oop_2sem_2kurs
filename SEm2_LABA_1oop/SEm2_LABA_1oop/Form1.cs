using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEm2_LABA_1oop
{

   
    public partial class Form1 : Form
    {
        
        Calculator Calc;
        int k;
        public Form1()
        {
            
            InitializeComponent();

            Calc = new Calculator();

            textBox1.Text = "0";
        }

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (textBox1.Text.IndexOf("∞") != -1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(",") != 1))
                textBox1.Text = textBox1.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (textBox1.Text[0] == '-')
                if (textBox1.Text[1] == '0' && (textBox1.Text.IndexOf(",") != 2))
                    textBox1.Text = textBox1.Text.Remove(1, 1);
        }

        private bool CanPress()
        {


            if (!buttonDegreeY.Enabled)
                return false;

            if (!buttonSqrtX.Enabled)
                return false;

            return true;
        }

       
        //sin
        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try { Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Sin().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }

             }
        }

        //cos
        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {

                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Cos().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }

        }

        //ctg
        private void buttonCtg_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Ctg().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
                
            }
        }

        //tg
        private void buttonTg_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Tg().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }

        //arcsin
        private void buttonAsin_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Asin().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }

        //arccos
        private void buttonAcos_Click(object sender, EventArgs e)
        {
            if (CanPress())
            { try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Calc.Acos().ToString();
                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
                
            }
        }

        //arcctg
        private void buttonActg_Click(object sender, EventArgs e)
        {
            if (CanPress())
            { try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Calc.Actg().ToString();
                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
                catch (DivideByZeroException) { MessageBox.Show("Divide By Zero Exception"); }
            }
        }

        //arctg
        private void buttonAtg_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Atg().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }

        //sqrt
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    textBox1.Text = Calc.Sqrt().ToString();

                    Calc.Clear_A();
                    FreeButtons();
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }
        //x^y
        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    buttonDegreeY.Enabled = false;

                    textBox1.Text = "0";
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }
        //pow(x,1/3)
        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                try
                {
                    Calc.Put_A(Convert.ToDouble(textBox1.Text));

                    buttonSqrtX.Enabled = false;

                    textBox1.Text = "0";
                }
                catch (FormatException) { MessageBox.Show("Incorect format"); }
            }
        }



        //0
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text +=0;
            CorrectNumber();
        }
        //1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text +=1;
            CorrectNumber();
        }
        //2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text +=2;
            CorrectNumber();
        }
        //3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text +=3;
            CorrectNumber();
        }
        //4
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            CorrectNumber();
        }
        //5
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text +=5;
            CorrectNumber();
        }
        //6
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text +=6;
            CorrectNumber();
        }
        //7
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text +=7;
            CorrectNumber();
        }
        //8
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text +=8;
            CorrectNumber();
        }
        //9
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            CorrectNumber();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //=
        private void buttonRavno_Click(object sender, EventArgs e)
        {
            

            if (!buttonSqrtX.Enabled)
                textBox1.Text = Calc.SqrtX(Convert.ToDouble(textBox1.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                textBox1.Text = Calc.DegreeY(Convert.ToDouble(textBox1.Text)).ToString();

            Calc.Clear_A();
            FreeButtons();

            k = 0;
        }
        //M+
        private void buttonMSum_Click(object sender, EventArgs e)
        {
            Calc.M_Sum(Convert.ToDouble(textBox1.Text));
        }
        //M-
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            Calc.M_Subtraction(Convert.ToDouble(textBox1.Text));
        }
        //,
        private void buttonZap_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            Calc.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    textBox1.Text = Calc.MemoryShow().ToString();

                if (k == 2)
                {
                    Calc.Memory_Clear();
                    textBox1.Text = "0";

                    k = 0;
                }
            }
        }

        private void FreeButtons()
        {         
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }
    }  
}
