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
            prompt.Width = 700;
            prompt.Height = 400;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.ColumnCount = 1;
            prompt.Controls.Add(tableLayoutPanel);

            //Panel Dosar
            Panel panelCodDosar = new Panel();
            panelCodDosar.Height = 40;
            panelCodDosar.Dock = DockStyle.Fill;
            // Label si input
            Label textLabeIndicativInstanta = new Label() { Left = 50, Top = 20, Text ="Indicativ Instanta"};
                panelCodDosar.Controls.Add(textLabeIndicativInstanta);
            TextBox textBoxIndicativInstanta = new TextBox() { Left = 150, Top = 20, Name = "textBoxIndicativInstanta" };
                textBoxIndicativInstanta.Size = new System.Drawing.Size(100, 20);
                panelCodDosar.Controls.Add(textBoxIndicativInstanta);
            // Label si input
            Label textLabelCodDosar = new Label() { Left = 350, Top = 20, Text = "Cod Dosar" };
                panelCodDosar.Controls.Add(textLabelCodDosar);
            TextBox textBoxCodDosar = new TextBox() { Left = 450, Top = 20, Name = "textBoxCodDosar" };
                textBoxCodDosar.Size = new System.Drawing.Size(100, 20);
                panelCodDosar.Controls.Add(textBoxCodDosar);


            //Panel Dosar
            Panel panelDetaliiDosar = new Panel();
            panelDetaliiDosar.Height = 100;
            panelDetaliiDosar.Dock = DockStyle.Fill;
            // Label si input
            Label textLabelNumeClient = new Label() { Left = 50, Top = 20, Text = "Nume client" };
                panelDetaliiDosar.Controls.Add(textLabelNumeClient);
            TextBox textBoxNumeClient = new TextBox() { Left = 150, Top = 20, Name = "textBoxNumeClient" };
                textBoxNumeClient.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxNumeClient);
            // Label si input
            Label textLabelNumeTitular = new Label() { Left = 50, Top = 50, Text = "Nume titular" };
                panelDetaliiDosar.Controls.Add(textLabelNumeTitular);
            TextBox textBoxNumeTitular = new TextBox() { Left = 150, Top = 50, Name = "textBoxNumeTitular" };
            textBoxNumeTitular.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxNumeTitular);
            // Label si input
            Label textLabelTipAct = new Label() { Left = 50, Top = 80, Text = "Tip act" };
                panelDetaliiDosar.Controls.Add(textLabelTipAct);
            TextBox textBoxTipAct = new TextBox() { Left = 150, Top = 80, Name = "textBoxTipAct" };
            textBoxTipAct.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxTipAct);
            // Label si input
            Label textLabelDataAct = new Label() { Left = 350, Top = 20, Text = "Data Act" };
                panelDetaliiDosar.Controls.Add(textLabelDataAct);
            TextBox textBoxDataAct = new TextBox() { Left = 450, Top = 20, Name = "textBoxDataAct" };
            textBoxDataAct.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxDataAct);
            // Label si input
            Label textLabelDetaliiAct = new Label() { Left = 350, Top = 50, Text = "Detalii Act" };
                panelDetaliiDosar.Controls.Add(textLabelDetaliiAct);
            TextBox textBoxDetaliiAct = new TextBox() { Left = 450, Top = 50, Name = "textBoxDetaliiAct" };
            textBoxDetaliiAct.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxDetaliiAct);
            // Label si input
            Label textLabelZileRamase = new Label() { Left = 350, Top = 80, Text = "Zile Ramase" };
                panelDetaliiDosar.Controls.Add(textLabelZileRamase);
            TextBox textBoxZileRamase = new TextBox() { Left = 450, Top = 80, Name = "textBoxZileRamase" };
            textBoxZileRamase.Size = new System.Drawing.Size(100, 20);
            panelDetaliiDosar.Controls.Add(textBoxZileRamase);



            //Panel Dosar
            Panel panelTipAct = new Panel();
            panelTipAct.Height = 100;
            panelTipAct.Dock = DockStyle.Fill;
            // Label si input
            Label textLabelNumeStare = new Label() { Left = 50, Top = 20, Text = "Stare" };
            panelTipAct.Controls.Add(textLabelNumeStare);
            TextBox textBoxNumeStare = new TextBox() { Left = 150, Top = 20, Name = "textBoxNumeStare" };
            textBoxNumeStare.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxNumeStare);
            // Label si input
            Label textLabelDataStare = new Label() { Left = 50, Top = 50, Text = "Data Stare" };
            panelTipAct.Controls.Add(textLabelDataStare);
            TextBox textBoxDataStare = new TextBox() { Left = 150, Top = 50, Name = "textBoxDataStare" };
            textBoxDataStare.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxDataStare);
            // Label si input
            Label textLabelAdresaStare = new Label() { Left = 50, Top = 80, Text = "Adresa" };
            panelTipAct.Controls.Add(textLabelAdresaStare);
            TextBox textBoxAdresaStare = new TextBox() { Left = 150, Top = 80, Name = "textBoxAdresaStare" };
            textBoxAdresaStare.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxAdresaStare);
            // Label si input
            Label textLabelNumeAvct = new Label() { Left = 350, Top = 20, Text = "Nume Avocat" };
            panelTipAct.Controls.Add(textLabelNumeAvct);
            TextBox textBoxNumeAvc = new TextBox() { Left = 450, Top = 20, Name = "textBoxNumeAvc" };
            textBoxNumeAvc.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxNumeAvc);
            // Label si input
            Label textLabelInstanta = new Label() { Left = 350, Top = 50, Text = "Instanta" };
            panelTipAct.Controls.Add(textLabelInstanta);
            TextBox textBoxInstanta = new TextBox() { Left = 450, Top = 50, Name = "textBoxInstanta" };
            textBoxInstanta.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxInstanta);
            // Label si input
            Label textLabelJudecatorie = new Label() { Left = 350, Top = 80, Text = "Judecatorie" };
            panelTipAct.Controls.Add(textLabelJudecatorie);
            TextBox textBoxJudecatorie = new TextBox() { Left = 450, Top = 80, Name = "textBoxJudecatorie" };
            textBoxJudecatorie.Size = new System.Drawing.Size(100, 20);
            panelTipAct.Controls.Add(textBoxJudecatorie);

            //Panel Dosar
            Panel panelStareAct = new Panel();
            panelStareAct.Height = 40;
            panelStareAct.Dock = DockStyle.Fill;
            // Label si input
            Label textLabelFotoCopiat = new Label() { Left = 50, Top = 20, Text = "Foto Copiat" };
            panelStareAct.Controls.Add(textLabelFotoCopiat);
            TextBox textBoxFotoCopiat = new TextBox() { Left = 150, Top = 20, Name = "textBoxFotoCopiat" };
            textBoxFotoCopiat.Size = new System.Drawing.Size(100, 20);
            panelStareAct.Controls.Add(textBoxFotoCopiat);

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
