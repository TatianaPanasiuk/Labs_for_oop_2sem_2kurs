using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEm2_LABA_2oop
{
    abstract class Prototype
    {
        public string Nazvanie { get; private set; }
        public string inventNumber { get; private set; }
            
        public string Cena { get; private set; }
        public string Ves { get; private set; }
        public int Colichestvo { get; set; }

        public DateTime Data { get; set; }
        public string Result { get; set; }


        public Prototype(string Nazvanie, string inventNumber, string Cena, string Ves, int Colichestvo, DateTime Data)
        {
            this.Nazvanie = Nazvanie;
            this.inventNumber = inventNumber;
            this.Cena = Cena;
            this.Ves = Ves;
            this.Colichestvo = Colichestvo;
            this.Data = Data;



        }

        public abstract Prototype Clone();
    }
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string Nazvanie, string inventNumber, string Cena, string Ves, int Colichestvo, DateTime Data) : base(Nazvanie, inventNumber, Cena, Ves, Colichestvo, Data)
        {

        }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Nazvanie, inventNumber, Cena, Ves, Colichestvo, Data);
        }
    }
}
