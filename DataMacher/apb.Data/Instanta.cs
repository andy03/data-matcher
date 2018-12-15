using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Data
{
    public class Instanta
    {
        public int IdInstanta { get; set; }
        public string NumeInstanta { get; set; }

        public Instanta(string NumeInstanta)
        {
            this.NumeInstanta = NumeInstanta;
        }
    }
}
