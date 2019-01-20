using System;
using static System.Windows.Forms.ListViewItem;
using static DataMacher.apb.Utils.IntrebareEnumUtils;

namespace DataMacher.apb.Data
{
    public class Folder
    {
        public virtual int Id_dosar { get; set; }
        public virtual Instanta Instanta { get; set; }
        public virtual string Cod_value_a { get; set; }
        public virtual string Cod_value_b { get; set; }
        public virtual string Cod_value_c { get; set; }
        public virtual string Cod_value_d { get; set; }
        public virtual string Cod_value { get; set; }
        public virtual string Nume_cl { get; set; }
        public virtual string Nume_tit_dosar { get; set; }
        public virtual Act Act { get; set; }

        public Folder(Instanta instanta, string cod_Value_A, string cod_Value_B, string cod_Value_C, string cod_Value_D, string nume_Client, string nume_Titular, Act act)
        {
            this.Instanta = instanta;
            this.Cod_value_a = cod_Value_A;
            this.Cod_value_b = cod_Value_B;
            this.Cod_value_c = cod_Value_C;
            this.Cod_value_d = cod_Value_D;
            this.Cod_value = cod_Value_A + '/' + cod_Value_B + '/' + cod_Value_C + '/' + cod_Value_D;
            this.Nume_cl = nume_Client;
            this.Nume_tit_dosar = nume_Titular;
            this.Act = act;
        }

        public Folder(Instanta instanta, string cod_Value_A, string cod_Value_B, string cod_Value_C, string nume_Client, string nume_Titular, Act act)
        {
            this.Instanta = instanta;
            this.Cod_value_a = cod_Value_A;
            this.Cod_value_b = cod_Value_B;
            this.Cod_value_c = cod_Value_C;
            this.Cod_value = cod_Value_A + '/' + cod_Value_B + '/' + cod_Value_C;
            this.Nume_cl = nume_Client;
            this.Nume_tit_dosar = nume_Titular;
            this.Act = act;
        }

        public Folder()
        {
        }

        public static implicit operator Folder(ListViewSubItemCollection v)
        {
            Stare Stare = new Stare(REDACTATA, new DateTime(), "adresa", "numbeAvt", new Instanta("numeInstanta"), "numbeJudecatorie", new DateTime());
            Situatie Situatie = new Situatie("nume situatie", 12, "descriere");
            Act Act = new Act(Stare, Situatie,"tipAct", new DateTime());

            Folder Folder = new Folder(new Instanta("22") , v[2].Text, v[0].Text, v[1].Text, v[2].Text, v[0].Text, v[1].Text, Act);
            return Folder;
        }
    }
}
