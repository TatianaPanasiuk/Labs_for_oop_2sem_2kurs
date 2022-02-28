using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;


namespace SEm2_LABA_2oop
{
    [Serializable]
    [XmlRoot(Namespace = "SEm2_LABA_2oop")]
    [XmlType("proizvoditel")]

    public class Proizvoditel
    {
        [XmlElement(ElementName = "organization")]
        public string organization;

        [XmlElement(ElementName = "strana")]
        public string strana;

        [XmlElement(ElementName = "adres")]
        public string adres;

        [XmlElement(ElementName = "telefon")]
        public string telefon;

        [XmlElement(ElementName = "id")]
        public Guid Id { get; set; }


        public Proizvoditel()
            {
            Id = Guid.NewGuid();
        }


    }
}
