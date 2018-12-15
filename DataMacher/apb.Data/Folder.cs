using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static DataMacher.apb.Utils.IntrebareEnumUtils;

namespace DataMacher.apb.Data
{
    public class Folder
    {
        public int IdFolder { get; set; }
        public Instanta Instanta { get; set; }
        public string CodValueA { get; set; }
        public string CodValueB { get; set; }
        public string CodValueC { get; set; }
        public string CodValueD { get; set; }
        public string CodValue { get; set; }
        public string NumeClient { get; set; }
        public string NumeTitular { get; set; }
        public Act Act { get; set; }

        public Folder(Instanta Instanta, string CodValueA, string CodValueB, string CodValueC, string CodValueD, string NumeClient, string NumeTitular, Act Act)
        {
            this.Instanta = Instanta;
            this.CodValueA = CodValue;
            this.CodValueB = CodValueB;
            this.CodValueC = CodValueC;
            this.CodValueD = CodValueD;
            this.CodValue = CodValueA + '/' + CodValueB + '/' + CodValueC + '/' + CodValueD;
            this.NumeClient = NumeClient;
            this.NumeTitular = NumeTitular;
            this.Act = Act;
        }

        public Folder(Instanta Instanta, string CodValueA, string CodValueB, string CodValueC,  string NumeClient, string NumeTitular, Act Act)
        {
            this.Instanta = Instanta;
            this.CodValueA = CodValueA;
            this.CodValueB = CodValueB;
            this.CodValueC = CodValueC;
            this.CodValue = CodValueA + '/' + CodValueB + '/' + CodValueC;
            this.NumeClient = NumeClient;
            this.NumeTitular = NumeTitular;
            this.Act = Act;
        }

        public Folder()
        {
        }

        public static implicit operator Folder(ListViewSubItemCollection v)
        {
            Stare Stare = new Stare(REDACTATA, new DateTime(), "adresa", "tip", "numbeAvt", new Instanta("numeInstanta"), "numbeJudecatorie", new DateTime());
            Situatie Situatie = new Situatie("nume situatie", 12, "descriere");
            Act Act = new Act(Stare, Situatie,"tipAct", new DateTime());

            Folder Folder = new Folder(new Instanta("22") , v[2].Text, v[0].Text, v[1].Text, v[2].Text, v[0].Text, v[1].Text, Act);
            return Folder;
        }
    }
}
