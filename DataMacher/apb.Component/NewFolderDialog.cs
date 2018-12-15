using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMacher
{
    class NewFolderDialog
    {
        private static readonly NewFolderDialog INSTANCE = new NewFolderDialog();
        private static Form prompt;

        private NewFolderDialog() { }

        public static NewFolderDialog Instance
        {
            get
            {
                if(prompt == null)
                {
                    prompt = new Form();
                }
                return INSTANCE;
            }
        }

        public void InitDialog()
        {
            prompt.RightToLeft = RightToLeft.Yes;
            prompt.Width = 500;
            prompt.Height = 300;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.ColumnCount = 1;
            prompt.Controls.Add(tableLayoutPanel);
            Panel panelCodDosar = new Panel();
            panelCodDosar.Height = 40;
            panelCodDosar.Dock = DockStyle.Fill;
            Label textLabeIndicativInstanta = new Label() { Left = 50, Top = 20, Text ="Indicativ Instanta"};
                panelCodDosar.Controls.Add(textLabeIndicativInstanta);
            Label textLabelCodDosar = new Label() { Left = 350, Top = 20, Text = "Cod Dosar" };
                panelCodDosar.Controls.Add(textLabelCodDosar);


            Panel panelDetaliiDosar = new Panel();
            panelDetaliiDosar.Height = 100;
            panelDetaliiDosar.Dock = DockStyle.Fill;
            Label textLabelNumeClient = new Label() { Left = 50, Top = 20, Text = "Nume client" };
                panelDetaliiDosar.Controls.Add(textLabelNumeClient);
            Label textLabelNumeTitular = new Label() { Left = 50, Top = 50, Text = "Nume titular" };
                panelDetaliiDosar.Controls.Add(textLabelNumeTitular);
            Label textLabelTipAct = new Label() { Left = 50, Top = 80, Text = "Tip act" };
                panelDetaliiDosar.Controls.Add(textLabelTipAct);
            Label textLabelDataAct = new Label() { Left = 350, Top = 20, Text = "Data Act" };
                panelDetaliiDosar.Controls.Add(textLabelDataAct);
            Label textLabelDetaliiAct = new Label() { Left = 350, Top = 50, Text = "Detalii Act" };
                panelDetaliiDosar.Controls.Add(textLabelDetaliiAct);
            Label textLabelZileRamase = new Label() { Left = 350, Top = 80, Text = "Zile Ramase" };
                panelDetaliiDosar.Controls.Add(textLabelZileRamase);


            Panel panelTipAct = new Panel();
            panelTipAct.Height = 100;
            panelTipAct.Dock = DockStyle.Fill;
            Label textLabelNumeStare = new Label() { Left = 50, Top = 20, Text = "Stare" };
            panelTipAct.Controls.Add(textLabelNumeStare);
            Label textLabelDataStare = new Label() { Left = 50, Top = 50, Text = "Data Stare" };
            panelTipAct.Controls.Add(textLabelDataStare);
            Label textLabelAdresaStare = new Label() { Left = 50, Top = 80, Text = "Adresa" };
            panelTipAct.Controls.Add(textLabelAdresaStare);
            Label textLabelNumeAvct = new Label() { Left = 350, Top = 20, Text = "Nume Avocat" };
            panelTipAct.Controls.Add(textLabelNumeAvct);
            Label textLabelInstanta = new Label() { Left = 350, Top = 50, Text = "Instanta" };
            panelTipAct.Controls.Add(textLabelInstanta);
            Label textLabelJudecatorie = new Label() { Left = 350, Top = 80, Text = "Judecatorie" };
            panelTipAct.Controls.Add(textLabelJudecatorie);


            Panel panelStareAct = new Panel();
            panelStareAct.Height = 40;
            panelStareAct.Dock = DockStyle.Fill;
            Label textLabelFotoCopiat = new Label() { Left = 50, Top = 20, Text = "Foto Copiat" };
            panelStareAct.Controls.Add(textLabelFotoCopiat);

            tableLayoutPanel.Controls.Add(panelCodDosar, 0, 0);
            tableLayoutPanel.Controls.Add(panelDetaliiDosar, 1, 0);
            tableLayoutPanel.Controls.Add(panelTipAct, 2, 0);
            tableLayoutPanel.Controls.Add(panelStareAct, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
        }


        public string createNewFolder(Folder folder)
        {
            //comboSource = new DataTable();
            InitDialog();
        



   
            Button confirmation = new Button() { Text = "STESTSETS", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();
            
            return "true";
        }
    }
}
