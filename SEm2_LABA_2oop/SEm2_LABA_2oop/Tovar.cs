using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;

namespace SEm2_LABA_2oop
{
    [Serializable]
    [XmlRoot(Namespace = "SEm2_LABA_2oop")]
    [XmlType("tovari")]
    public class Tovar : Proizvoditel
    {
        [XmlElement(ElementName = "Nazvanie")]
        public string Nazvanie;

        [XmlElement(ElementName = "InvetarniNumber")]
        public string InvetarniNumber;

        [XmlElement(ElementName = "Razmer")]
        public string Razmer;

        [XmlElement(ElementName = "Ves")]
        public string Ves;

        [XmlElement(ElementName = "Tip")]
        public string Tip;

        [XmlElement(ElementName = "DataPostyplenia")]
        public string DataPostyplenia;

        [XmlElement(ElementName = "Colichestvo")]
        public int Colichestvo;

        [XmlElement(ElementName = "Cena")]
        public string Cena;

        [XmlElement(ElementName = "Proizvoditel")]
        public Proizvoditel Proizvod = new Proizvoditel();

        public Tovar() { }

    }
}
