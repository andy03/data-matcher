using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Utils
{


    public class NameValue
    {

        private string dataName;
        private string dataValue;

        public NameValue(string dataName, string dataValue)
        {
            DataName = dataName;
            DataValue = dataValue;
        }

        public string DataName
        {
            get { return dataName; }
            set { dataName = value; }
        }

        public string DataValue
        {
            get { return dataValue; }
            set { dataValue = value; }
        }

        public override string ToString()
        {
            return dataName;
        }

    }

}
