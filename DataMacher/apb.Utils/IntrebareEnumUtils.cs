using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataMacher.apb.Utils
{
    public enum IntrebareEnumUtils
    {
        [Description("Redactata?")]
        REDACTATA,
        [Description("Comunicata?")]
        COMUNICATA,
        [Description("La ce adresa?")]
        ADRESA,
        [Description("Apel?")]
        APEL,
        [Description("Recurs?")]
        Recurs,
        [Description("A plecat dosarul?")]
        DEPUS,
        [Description("Inregistrat?")]
        INREGISTRAT
    }
}
