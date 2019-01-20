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
            prompt.Width = 560;
            prompt.Height = 380;
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
            Panel panelDetaliiDosar = CreateDosar(70);
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



            //Panel Redactata
            Panel panelStareRedactata = CreateDosar(70);
            // Label si input
            RenderNumeRedactata(panelStareRedactata);
            // Label si input
            RenderDataRedactata(panelStareRedactata);
            // Label si input
            RenderNumeComunicata(panelStareRedactata);
            // Label si input
            RenderDataComunicata(panelStareRedactata);
            // Label si input
            RenderAdresaComunicata(panelStareRedactata);

            Panel panelStareApelRecurs = CreateDosar(120);
            // Label si input
            RenderNumeApelRecurs(panelStareApelRecurs);
            // Label si input
            RenderDataApelRecurs(panelStareApelRecurs);
            // Label si input
            RenderNumeAvocat(panelStareApelRecurs);
            // Label si input
            RenderNumePlecat(panelStareApelRecurs);
            // Label si input
            RenderDataPlecat(panelStareApelRecurs);
            // Label si input
            RenderInstanta(panelStareApelRecurs);
            // Label si input
            RenderNumeInregistrat(panelStareApelRecurs);
            // Label si input
            RenderDataInregistrat(panelStareApelRecurs);
            // Label si input
            RenderJudecatorie(panelStareApelRecurs);
            // Label si input
            RenderFotoCopiat(panelStareApelRecurs);
            // Label si input
            RenderMentiuni(panelStareApelRecurs);


            tableLayoutPanel.Controls.Add(panelCodDosar, 0, 0);
            tableLayoutPanel.Controls.Add(panelDetaliiDosar, 1, 0);
            tableLayoutPanel.Controls.Add(panelStareRedactata, 2, 0);
            tableLayoutPanel.Controls.Add(panelStareApelRecurs, 3, 0);
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
        /// <summary>
        /// ////////
        /// </summary>
        /// <param name="panel"></param>
        private void RenderIndicativInstanta(Panel panel)
        {
            Label textLabeLIndicativInstanta = CreateLabel("Indicativ Instanta" ,60,15,120,20);
            panel.Controls.Add(textLabeLIndicativInstanta);

            ComboBox comboBoxIndicativInstanta = new ComboBox() { Left = 70, Top = 35, Name = "textBoxIndicativInstanta" };
            comboBoxIndicativInstanta.Size = new System.Drawing.Size(100, 20);
            comboBoxIndicativInstanta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIndicativInstanta.SelectedIndexChanged += new EventHandler(ComboBoxIndicativInstanta_SelectedIndexChanged);
            comboBoxIndicativInstanta.DataSource = InstantaRepository.GetInstantaRepository.FindAllInstantaName();

            panel.Controls.Add(comboBoxIndicativInstanta);
        }

        private void RenderNrDosar(Panel panel)
        {
            Label textLabeLNrDosar = CreateLabel("Numar Dosar", 300, 15, 120, 20);
            panel.Controls.Add(textLabeLNrDosar);

            TextBox textBoxCodDosar1 = CreateTextBox("textBoxCodDosar1", "", 235, 35, 70, 20);
            TextBox textBoxCodDosar2 = CreateTextBox("textBoxCodDosar2", "", 315, 35, 50, 20);
            TextBox textBoxCodDosar3 = CreateTextBox("textBoxCodDosar3", "", 375, 35, 40, 20);
            TextBox textBoxCodDosar4 = CreateTextBox("textBoxCodDosar4", "", 425, 35, 40, 20);
            panel.Controls.Add(textBoxCodDosar1);
            panel.Controls.Add(textBoxCodDosar2);
            panel.Controls.Add(textBoxCodDosar3);
            panel.Controls.Add(textBoxCodDosar4);
        }
        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <param name="panel"></param>
        private void RenderNumeClient(Panel panel)
        {
            TextBox textBoxNumeClient = CreateTextBox("textBoxNumeClient", "Nume Client", 20, 20, 200, 20);
            panel.Controls.Add(textBoxNumeClient);
        }

        private void RenderNumeTitular(Panel panel)
        {           
            TextBox textBoxNumeTitular = CreateTextBox("textBoxNumeTitular", "Nume titular", 240, 20, 280, 20);
            panel.Controls.Add(textBoxNumeTitular);
        }

        private void RenderTipAct(Panel panel)
        {
            TextBox textBoxTipAct = CreateTextBox("textBoxtTipAct", "Tip act", 20, 50, 100, 20);
            panel.Controls.Add(textBoxTipAct);
        }

        private void RenderDataAct(Panel panel)
        {
            TextBox textBoxDataAct = CreateTextBox("textBoxDataAct", "Data Act", 150, 50, 100, 20);
            panel.Controls.Add(textBoxDataAct);
        }

        private void RenderDetaliiAct(Panel panel)
        {
            TextBox textBoxDetaliiAct = CreateTextBox("textBoxDetaliiAct", "Detalii Act", 290, 50, 100, 20);
            panel.Controls.Add(textBoxDetaliiAct);
        }

        private void RenderZileRamase(Panel panel)
        {
            TextBox textBoxZileRamase = CreateTextBox("textBoxZileRamase", "Zile Ramase", 420, 50, 100, 20);
            panel.Controls.Add(textBoxZileRamase);
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        /// 
        private void RenderNumeRedactata(Panel panel)
        {
            TextBox textBoxNumeRedactata = CreateTextBox("textBoxNumeRedactata", "Redactata?", 20, 20, 100, 20);
            panel.Controls.Add(textBoxNumeRedactata);
        }

        private void RenderDataRedactata(Panel panel)
        {
            TextBox textBoxDataRedactata = CreateTextBox("textBoxDataRedactata", "Data Redactare", 150, 20, 100, 20);
            panel.Controls.Add(textBoxDataRedactata);
        }

        private void RenderNumeComunicata(Panel panel)
        {
            TextBox textBoxNumeComunicata = CreateTextBox("textBoxNumeComunicata", "Comunicata?", 290, 20, 100, 20);
            panel.Controls.Add(textBoxNumeComunicata);
        }

        private void RenderDataComunicata(Panel panel)
        {
            TextBox textBoxDataComunicata = CreateTextBox("textBoxDataComunicata", "Data Comunicata", 420, 20, 100, 20);
            panel.Controls.Add(textBoxDataComunicata);
        }

        private void RenderAdresaComunicata(Panel panel)
        {
            TextBox textBoxDataComunicata = CreateTextBox("textBoxAdresaComunicata", "Adresa Comunicata", 20, 50, 500, 20);
            panel.Controls.Add(textBoxDataComunicata);
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        /// 


        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        /// 

        private void RenderNumeApelRecurs(Panel panel)
        {
            TextBox textBoxNumeApelRecurs = CreateTextBox("textBoxNumeApelRecurs", "Apel/Recurs", 20, 20, 150, 20);
            panel.Controls.Add(textBoxNumeApelRecurs);
        }

        private void RenderDataApelRecurs(Panel panel)
        {
            TextBox textBoxDataApelRecurs = CreateTextBox("textBoxDataApelRecurs", "Data Apel/Recurs", 190, 20, 150, 20);
            panel.Controls.Add(textBoxDataApelRecurs);
        }

        private void RenderNumeAvocat(Panel panel)
        {
            TextBox textBoxNumeAvc = CreateTextBox("textBoxNumeAvc", "Nume Avocat", 370, 20, 150, 20);
            panel.Controls.Add(textBoxNumeAvc);
        }

        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        /// 

        private void RenderNumePlecat(Panel panel)
        {
            TextBox textBoxNumePlecat = CreateTextBox("textBoxNumePlecat", "A plecat dosarul?", 20, 20, 150, 20);
            panel.Controls.Add(textBoxNumePlecat);
        }

        private void RenderDataPlecat(Panel panel)
        {
            TextBox textBoxDataPlecat = CreateTextBox("textBoxDataPlecat", "Data plecare dosar", 190, 20, 150, 20);
            panel.Controls.Add(textBoxDataPlecat);
        }

        private void RenderInstanta(Panel panel)
        {
            TextBox textBoxInstanta = CreateTextBox("textBoxInstanta", "Instanta", 370, 20, 150, 20);
            panel.Controls.Add(textBoxInstanta);
        }

        private void RenderNumeInregistrat(Panel panel)
        {
            TextBox textBoxNumeInregistrat = CreateTextBox("textBoxNumeInregistrat", "Dosar inregistrat?", 20, 50, 150, 20);
            panel.Controls.Add(textBoxNumeInregistrat);
        }

        private void RenderDataInregistrat(Panel panel)
        {
            TextBox textBoxDataInregistrat = CreateTextBox("textBoxDataInregistrat", "Data Inregistrat", 190, 50, 150, 20);
            panel.Controls.Add(textBoxDataInregistrat);
        }

        private void RenderJudecatorie(Panel panel)
        {
            TextBox textBoxJudecatorie = CreateTextBox("textBoxJudecatorie", "Judecatorie", 370, 50, 150, 20);
            panel.Controls.Add(textBoxJudecatorie);
        }

        private void RenderFotoCopiat(Panel panel)
        {
            TextBox textBoxFotoCopiat = CreateTextBox("textBoxFotoCopiat", "Data Foto Copiat", 20, 80, 100, 20);
            panel.Controls.Add(textBoxFotoCopiat);
        }

        private void RenderMentiuni(Panel panel)
        {
            TextBox textBoxMentiuni = CreateTextBox("textBoxMentiuni", "Mentiuni", 150, 80, 370, 20);
            panel.Controls.Add(textBoxMentiuni);
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