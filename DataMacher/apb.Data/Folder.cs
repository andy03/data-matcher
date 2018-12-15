using System;
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

        public Folder(Instanta instanta, string codValueA, string codValueB, string codValueC, string codValueD, string numeClient, string numeTitular, Act act)
        {
            this.Instanta = instanta;
            this.CodValueA = codValueA;
            this.CodValueB = codValueB;
            this.CodValueC = codValueC;
            this.CodValueD = codValueD;
            this.CodValue = codValueA + '/' + codValueB + '/' + codValueC + '/' + codValueD;
            this.NumeClient = numeClient;
            this.NumeTitular = numeTitular;
            this.Act = act;
        }

        public Folder(Instanta instanta, string codValueA, string codValueB, string codValueC, string numeClient, string numeTitular, Act act)
        {
            this.Instanta = instanta;
            this.CodValueA = codValueA;
            this.CodValueB = codValueB;
            this.CodValueC = codValueC;
            this.CodValue = codValueA + '/' + codValueB + '/' + codValueC;
            this.NumeClient = numeClient;
            this.NumeTitular = numeTitular;
            this.Act = act;
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
