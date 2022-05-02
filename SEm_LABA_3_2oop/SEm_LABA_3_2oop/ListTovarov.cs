using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEm2_LABA_2oop
{
    [Serializable]
    public class ListTovarov
    {
        public List<Tovar> Tovars { get; set; }
        public Proizvoditel Proizvoditel { get; set; }

        public ListTovarov()
        {
            Proizvoditel = new Proizvoditel();
            Tovars = new List<Tovar>();

        }

    }
}
