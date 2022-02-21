using System;
using System.Collections.Generic;
using System.Text;

namespace SEm2_LABA_1oop
{
   public  interface ICalculator
    {
        public void Put_A(double a); //сохранить а

        public void Clear_A();

        public double Sin();
        public double Cos();       
        public double Tg();    
        public double Ctg();
        public  double Actg();
        public  double Atg();
        public double Asin();
        public double Acos();

        public double SqrtX(double a);
        public double DegreeY(double a);
        public double Sqrt();



        public double MemoryShow(); //показать содержимое регистра памяти

        public void Memory_Clear(); //стереть содержимое регистра памяти

        // + - к регистру памяти
        
        public void M_Sum(double b);

        public void M_Subtraction(double b); //вычитание

    }
}
