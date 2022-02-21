using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SEm2_LABA_1oop
{
    public class Calculator : ICalculator
    {

        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Sin()
        {
            return Math.Sin(a);
        }

        public double Cos()
        {
            return Math.Cos(a);
        }

        public double Tg()
        {
            return Math.Tan(a);
        }

        public double Ctg()
        {
            try {
                if (a == 0) { throw new DivideByZeroException(); }
                return 1 / Math.Tan(a);
            }

            catch (DivideByZeroException ex) { MessageBox.Show(ex.Message); return 0; }
        }

        public double Actg()
        {
            try
            {
                if (Math.Atan(a) == 0) { throw new DivideByZeroException(); }
                else
                {
                    return 1 / (Math.Atan(a) * 180 / Math.PI);
                }
            }
            catch (DivideByZeroException ex) { MessageBox.Show(ex.Message); return 0; }
        }

        public double Atg()
        {

            return Math.Atan(a * 180 / Math.PI);
        }

        public double Asin()
        {
            return Math.Asin(a);
        }
        public double Acos()
        {
            return Math.Acos(a);
        }

        public double SqrtX(double b)
        {
            try
            {
                if (b == 0) { throw new DivideByZeroException(); }
                else { return Math.Pow(a, 1 / b); }
            }
            catch (DivideByZeroException ex) { MessageBox.Show(ex.Message); return 0; }
           
        }
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }
        public double Sqrt()
        {
            try
            {
                if (a < 0) { throw new FormatException(); }
                else
                {
                    return Math.Sqrt(a);
                }
            }
            catch (FormatException ex) { MessageBox.Show(ex.Message); return 0; }
        }



        public double MemoryShow()
        {
            return memory;
        } //показать содержимое регистра памяти

        public void Memory_Clear()
        {
            memory = 0.0;
        } //стереть содержимое регистра памяти

        // + - к регистру памяти

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        } //вычитание

    } 
}
