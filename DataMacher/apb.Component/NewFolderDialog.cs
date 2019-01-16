using DataMacher.apb.Data;
using System.Windows.Forms;
using DataMacher.apb.Service;
using System;
using DataMacher.apb.Repository;

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
            prompt.Width = 800;
            prompt.Height = 800;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.ColumnCount = 1;
            prompt.Controls.Add(tableLayoutPanel);

            //Panel Dosar
            Panel panelCodDosar = CreateDosar(60);
            // Label si input
            RenderIndicativInstanta(panelCodDosar);
            // Label si input
            RenderNrDosar(panelCodDosar);


            //Panel Dosar
            Panel panelDetaliiDosar = CreateDosar(100);
            // Label si input
            RenderNumeClient(panelDetaliiDosar);
            // Label si input
            RenderNumeTitular(panelDetaliiDosar);
            // Label si input
            RenderTipAct(panelDetaliiDosar);
            // Label si input
            RenderDataAct(panelDetaliiDosar);
            // Label si input
            RenderDetaliiAct(panelDetaliiDosar);
            // Label si input
            RenderZileRamase(panelDetaliiDosar);



            //Panel Dosar
            Panel panelTipAct = CreateDosar(100);
            // Label si input
            RenderNumeStare(panelTipAct);
            // Label si input
            RenderDataStare(panelTipAct);
            // Label si input
            RenderAdresaStare(panelTipAct);
            // Label si input
            RenderNumeAvocat(panelTipAct);
            // Label si input
            RenderInstanta(panelTipAct);
            // Label si input
            RenderJudecatorie(panelTipAct);

            //Panel Dosar
            Panel panelStareAct = CreateDosar(40);
            // Label si input
            RenderFotoCopiat(panelStareAct);

            tableLayoutPanel.Controls.Add(panelCodDosar, 0, 0);
            tableLayoutPanel.Controls.Add(panelDetaliiDosar, 1, 0);
            tableLayoutPanel.Controls.Add(panelTipAct, 2, 0);
            tableLayoutPanel.Controls.Add(panelStareAct, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
        }

        private Panel CreateDosar(int height)
        {
            Panel panel = new Panel();
            panel.Height = height;
            panel.Dock = DockStyle.Fill;
            return panel;
        }

        private TextBox CreateTextBox(string numeTextBox, string text, int left, int top, int width, int height)
        {
            TextBox textBox = new TextBox() { Left = left, Top = top, Name = numeTextBox };
            textBox.Text = text;
            textBox.AutoSize = false;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Size = new System.Drawing.Size(width, height);
            textBox.MouseCaptureChanged += new EventHandler(RemoveText);
            return textBox;
        }
        
        private Label CreateLabel(string text, int left, int top, int width, int height)
        {
            Label textLabel = new Label() { Left = left, Top = top, Text = text };
            textLabel.Size = new System.Drawing.Size(width, height);
            textLabel.AutoSize = false;
            textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return textLabel;
        }

        private void RenderIndicativInstanta(Panel panel)
        {
            Label textLabeLIndicativInstanta = CreateLabel("Indicativ Instanta" ,170,15,120,20);
            panel.Controls.Add(textLabeLIndicativInstanta);

            ComboBox comboBoxIndicativInstanta = new ComboBox() { Left = 180, Top = 35, Name = "textBoxIndicativInstanta" };
            comboBoxIndicativInstanta.Size = new System.Drawing.Size(100, 20);
            comboBoxIndicativInstanta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIndicativInstanta.SelectedIndexChanged += new EventHandler(ComboBoxIndicativInstanta_SelectedIndexChanged);
            comboBoxIndicativInstanta.DataSource = InstantaRepository.GetInstantaRepository.FindAllInstantaName();

            panel.Controls.Add(comboBoxIndicativInstanta);
        }

        private void RenderNrDosar(Panel panel)
        {
            Label textLabeLNrDosar = CreateLabel("Numar Dosar", 435, 15, 120, 20);
            panel.Controls.Add(textLabeLNrDosar);

            TextBox textBoxCodDosar1 = CreateTextBox("textBoxCodDosar1", "", 370, 35, 70, 20);
            TextBox textBoxCodDosar2 = CreateTextBox("textBoxCodDosar2", "", 450, 35, 50, 20);
            TextBox textBoxCodDosar3 = CreateTextBox("textBoxCodDosar3", "", 510, 35, 40, 20);
            TextBox textBoxCodDosar4 = CreateTextBox("textBoxCodDosar4", "", 560, 35, 40, 20);
            panel.Controls.Add(textBoxCodDosar1);
            panel.Controls.Add(textBoxCodDosar2);
            panel.Controls.Add(textBoxCodDosar3);
            panel.Controls.Add(textBoxCodDosar4);
        }

        private void RenderNumeClient(Panel panel)
        {
            TextBox textBoxNumeClient = CreateTextBox("textBoxNumeClient", "Nume Client", 100, 20, 200, 20);
            panel.Controls.Add(textBoxNumeClient);
        }

        private void RenderNumeTitular(Panel panel)
        {           
            TextBox textBoxNumeTitular = CreateTextBox("textBoxNumeTitular", "Nume titular", 400, 20, 300, 20);
            panel.Controls.Add(textBoxNumeTitular);
        }

        private void RenderTipAct(Panel panel)
        {
            TextBox textBoxTipAct = CreateTextBox("textBoxtTipAct", "Tip act", 100, 50, 100, 20);
            panel.Controls.Add(textBoxTipAct);
        }

        private void RenderDataAct(Panel panel)
        {
            TextBox textBoxDataAct = CreateTextBox("textBoxDataAct", "Data Act", 200, 50, 100, 20);
            panel.Controls.Add(textBoxDataAct);
        }

        private void RenderDetaliiAct(Panel panel)
        {
            TextBox textBoxDetaliiAct = CreateTextBox("textBoxDetaliiAct", "Detalii Act", 450, 50, 100, 20);
            panel.Controls.Add(textBoxDetaliiAct);
        }

        private void RenderZileRamase(Panel panel)
        {
            TextBox textBoxZileRamase = CreateTextBox("textBoxZileRamase", "Zile Ramase", 550, 50, 100, 20);
            panel.Controls.Add(textBoxZileRamase);
        }

        private void RenderNumeStare(Panel panel)
        {
            Label textLabelNumeStare = new Label() { Left = 50, Top = 20, Text = "Stare" };
            panel.Controls.Add(textLabelNumeStare);
            TextBox textBoxNumeStare = new TextBox() { Left = 150, Top = 20, Name = "textBoxNumeStare" };
            textBoxNumeStare.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxNumeStare);
        }

        private void RenderDataStare(Panel panel)
        {
            Label textLabelDataStare = new Label() { Left = 50, Top = 50, Text = "Data Stare" };
            panel.Controls.Add(textLabelDataStare);
            TextBox textBoxDataStare = new TextBox() { Left = 150, Top = 50, Name = "textBoxDataStare" };
            textBoxDataStare.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxDataStare);
        }

        private void RenderAdresaStare(Panel panel)
        {
            Label textLabelAdresaStare = new Label() { Left = 50, Top = 80, Text = "Adresa" };
            panel.Controls.Add(textLabelAdresaStare);
            TextBox textBoxAdresaStare = new TextBox() { Left = 150, Top = 80, Name = "textBoxAdresaStare" };
            textBoxAdresaStare.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxAdresaStare);
        }

        private void RenderNumeAvocat(Panel panel)
        {
            Label textLabelNumeAvct = new Label() { Left = 350, Top = 20, Text = "Nume Avocat" };
            panel.Controls.Add(textLabelNumeAvct);
            TextBox textBoxNumeAvc = new TextBox() { Left = 450, Top = 20, Name = "textBoxNumeAvc" };
            textBoxNumeAvc.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxNumeAvc);
        }

        private void RenderInstanta(Panel panel)
        {
            Label textLabelInstanta = new Label() { Left = 350, Top = 50, Text = "Instanta" };
            panel.Controls.Add(textLabelInstanta);
            TextBox textBoxInstanta = new TextBox() { Left = 450, Top = 50, Name = "textBoxInstanta" };
            textBoxInstanta.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxInstanta);
        }

        private void RenderJudecatorie(Panel panel)
        {
            Label textLabelJudecatorie = new Label() { Left = 350, Top = 80, Text = "Judecatorie" };
            panel.Controls.Add(textLabelJudecatorie);
            TextBox textBoxJudecatorie = new TextBox() { Left = 450, Top = 80, Name = "textBoxJudecatorie" };
            textBoxJudecatorie.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxJudecatorie);
        }

        private void RenderFotoCopiat(Panel panel)
        {
            Label textLabelFotoCopiat = new Label() { Left = 50, Top = 20, Text = "Foto Copiat" };
            panel.Controls.Add(textLabelFotoCopiat);
            TextBox textBoxFotoCopiat = new TextBox() { Left = 150, Top = 20, Name = "textBoxFotoCopiat" };
            textBoxFotoCopiat.Size = new System.Drawing.Size(100, 20);
            panel.Controls.Add(textBoxFotoCopiat);
        }

        private void ComboBoxIndicativInstanta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            textBox.SelectAll();
        }

        public void AddText(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(myTxtbx.Text))
            //    myTxtbx.Text = "Enter text here...";
        }



        public string createNewFolder(Folder folder)
        {
            //comboSource = new DataTable();
            InitDialog();           

            var instanta = InstantaService.GetInstantaService.GetById(2);
            var stare = StareService.GetStareService.GetById(1);
            var instanta2 = stare.Instanta.Nume_instanta;



            Button confirmation = new Button() { Text = "STESTSETS", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();
            
            return "true";
        }
    }
}

//ListView instantaList = new ListView();
//ListViewItem listview = new ListViewItem(InstantaRepository.GetInstantaRepository.FindAllInstantaName().ToArray());
//instantaList.Items.Add(listview);