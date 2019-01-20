using DataMacher.apb.Data;
using System.Windows.Forms;
using DataMacher.apb.Service;
using System;
using DataMacher.apb.Repository;
using System.Globalization;

namespace DataMacher
{
    class NewFolderDialog
    {
        private static readonly NewFolderDialog INSTANCE = new NewFolderDialog();
        private static Form prompt;

        ComboBox comboBoxIndicativInstanta = new ComboBox();
        TextBox textBoxCodDosar1 = new TextBox();
        TextBox textBoxCodDosar2 = new TextBox();
        TextBox textBoxCodDosar3 = new TextBox();
        TextBox textBoxCodDosar4 = new TextBox();
        TextBox textBoxNumeClient = new TextBox();
        TextBox textBoxNumeTitular = new TextBox();
        TextBox textBoxTipAct = new TextBox();
        TextBox textBoxDataAct = new TextBox();
        TextBox textBoxDetaliiAct = new TextBox();
        TextBox textBoxZileRamase = new TextBox();
        TextBox textBoxNumeRedactata = new TextBox();
        TextBox textBoxDataRedactata = new TextBox();
        TextBox textBoxNumeComunicata = new TextBox();
        TextBox textBoxDataComunicata = new TextBox();
        TextBox textBoxAdresaComunicata = new TextBox();
        TextBox textBoxNumeApelRecurs = new TextBox();
        TextBox textBoxDataApelRecurs = new TextBox();
        TextBox textBoxNumeAvc = new TextBox();
        TextBox textBoxNumePlecat = new TextBox();
        TextBox textBoxDataPlecat = new TextBox();
        TextBox textBoxInstanta = new TextBox();
        TextBox textBoxNumeInregistrat = new TextBox();
        TextBox textBoxDataInregistrat = new TextBox();
        TextBox textBoxJudecatori = new TextBox();
        TextBox textBoxFotoCopiat = new TextBox();
        TextBox textBoxMentiuni = new TextBox();
        Panel panelButoane = new Panel();


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

        public void CreateDialog()
        {
            prompt.Width = 560;
            prompt.Height = 460;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 1;
            prompt.Controls.Add(tableLayoutPanel);

            TableLayoutPanel tableLayoutInit = InitDialog();
            tableLayoutPanel.Controls.Add(tableLayoutInit, 0, 0);

            panelButoane = CreateDosar(40);
            tableLayoutPanel.Controls.Add(panelButoane, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
        }


        public TableLayoutPanel InitDialog()
        {

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.ColumnCount = 1;

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

            Panel panelStareApelRecurs = CreateDosar(130);
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
            RenderJudecatori(panelStareApelRecurs);
            // Label si input
            RenderFotoCopiat(panelStareApelRecurs);
            // Label si input
            RenderMentiuni(panelStareApelRecurs);


            tableLayoutPanel.Controls.Add(panelCodDosar, 0, 0);
            tableLayoutPanel.Controls.Add(panelDetaliiDosar, 1, 0);
            tableLayoutPanel.Controls.Add(panelStareRedactata, 2, 0);
            tableLayoutPanel.Controls.Add(panelStareApelRecurs, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Width = 560;
            tableLayoutPanel.Height = 360;
            return tableLayoutPanel;
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

            comboBoxIndicativInstanta = new ComboBox() { Left = 70, Top = 35, Name = "textBoxIndicativInstanta" };
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
            textBoxCodDosar1 = CreateTextBox("textBoxCodDosar1", "", 235, 35, 70, 20);
            textBoxCodDosar2 = CreateTextBox("textBoxCodDosar2", "", 315, 35, 50, 20);
            textBoxCodDosar3 = CreateTextBox("textBoxCodDosar3", "", 375, 35, 40, 20);
            textBoxCodDosar4 = CreateTextBox("textBoxCodDosar4", "", 425, 35, 40, 20);
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
            textBoxNumeClient = CreateTextBox("textBoxNumeClient", "Nume Client", 20, 20, 200, 20);
            panel.Controls.Add(textBoxNumeClient);
        }

        private void RenderNumeTitular(Panel panel)
        {
            textBoxNumeTitular = CreateTextBox("textBoxNumeTitular", "Nume titular", 240, 20, 280, 20);
            panel.Controls.Add(textBoxNumeTitular);
        }

        private void RenderTipAct(Panel panel)
        {
            textBoxTipAct = CreateTextBox("textBoxtTipAct", "Tip act", 20, 50, 100, 20);
            panel.Controls.Add(textBoxTipAct);
        }

        private void RenderDataAct(Panel panel)
        {
            textBoxDataAct = CreateTextBox("textBoxDataAct", "Data Act", 150, 50, 100, 20);
            panel.Controls.Add(textBoxDataAct);
        }

        private void RenderDetaliiAct(Panel panel)
        {
            textBoxDetaliiAct = CreateTextBox("textBoxDetaliiAct", "Detalii Act", 290, 50, 100, 20);
            panel.Controls.Add(textBoxDetaliiAct);
        }

        private void RenderZileRamase(Panel panel)
        {
            textBoxZileRamase = CreateTextBox("textBoxZileRamase", "Zile Ramase", 420, 50, 100, 20);
            panel.Controls.Add(textBoxZileRamase);
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        /// 
        private void RenderNumeRedactata(Panel panel)
        {
            textBoxNumeRedactata = CreateTextBox("textBoxNumeRedactata", "Redactata?", 20, 20, 100, 20);
            panel.Controls.Add(textBoxNumeRedactata);
        }

        private void RenderDataRedactata(Panel panel)
        {
            textBoxDataRedactata = CreateTextBox("textBoxDataRedactata", "Data Redactare", 150, 20, 100, 20);
            panel.Controls.Add(textBoxDataRedactata);
        }

        private void RenderNumeComunicata(Panel panel)
        {
            textBoxNumeComunicata = CreateTextBox("textBoxNumeComunicata", "Comunicata?", 290, 20, 100, 20);
            panel.Controls.Add(textBoxNumeComunicata);
        }

        private void RenderDataComunicata(Panel panel)
        {
            textBoxDataComunicata = CreateTextBox("textBoxDataComunicata", "Data Comunicata", 420, 20, 100, 20);
            panel.Controls.Add(textBoxDataComunicata);
        }

        private void RenderAdresaComunicata(Panel panel)
        {
            textBoxAdresaComunicata = CreateTextBox("textBoxAdresaComunicata", "Adresa Comunicata", 20, 50, 500, 20);
            panel.Controls.Add(textBoxAdresaComunicata);
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="panel"></param>
        private void RenderNumeApelRecurs(Panel panel)
        {
            textBoxNumeApelRecurs = CreateTextBox("textBoxNumeApelRecurs", "Apel/Recurs", 20, 20, 150, 20);
            panel.Controls.Add(textBoxNumeApelRecurs);
        }

        private void RenderDataApelRecurs(Panel panel)
        {
            textBoxDataApelRecurs = CreateTextBox("textBoxDataApelRecurs", "Data Apel/Recurs", 190, 20, 150, 20);
            panel.Controls.Add(textBoxDataApelRecurs);
        }

        private void RenderNumeAvocat(Panel panel)
        {
            textBoxNumeAvc = CreateTextBox("textBoxNumeAvc", "Nume Avocat", 370, 20, 150, 20);
            panel.Controls.Add(textBoxNumeAvc);
        }

        private void RenderNumePlecat(Panel panel)
        {
            textBoxNumePlecat = CreateTextBox("textBoxNumePlecat", "A plecat dosarul?", 20, 50, 150, 20);
            panel.Controls.Add(textBoxNumePlecat);
        }

        private void RenderDataPlecat(Panel panel)
        {
            textBoxDataPlecat = CreateTextBox("textBoxDataPlecat", "Data plecare dosar", 190, 50, 150, 20);
            panel.Controls.Add(textBoxDataPlecat);
        }

        private void RenderInstanta(Panel panel)
        {
            textBoxInstanta = CreateTextBox("textBoxInstanta", "Instanta", 370, 50, 150, 20);
            panel.Controls.Add(textBoxInstanta);
        }

        private void RenderNumeInregistrat(Panel panel)
        {
            textBoxNumeInregistrat = CreateTextBox("textBoxNumeInregistrat", "Dosar inregistrat?", 20, 80, 150, 20);
            panel.Controls.Add(textBoxNumeInregistrat);
        }

        private void RenderDataInregistrat(Panel panel)
        {
            textBoxDataInregistrat = CreateTextBox("textBoxDataInregistrat", "Data Inregistrat", 190, 80, 150, 20);
            panel.Controls.Add(textBoxDataInregistrat);
        }

        private void RenderJudecatori(Panel panel)
        {
            textBoxJudecatori = CreateTextBox("textBoxJudecatorie", "Judecatorie", 370, 80, 150, 20);
            panel.Controls.Add(textBoxJudecatori);
        }

        private void RenderFotoCopiat(Panel panel)
        {
            textBoxFotoCopiat = CreateTextBox("textBoxFotoCopiat", "Data Foto Copiat", 20, 110, 100, 20);
            panel.Controls.Add(textBoxFotoCopiat);
        }

        private void RenderMentiuni(Panel panel)
        {
            textBoxMentiuni = CreateTextBox("textBoxMentiuni", "Mentiuni", 150, 110, 370, 20);
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



        public void createNewFolder()
        {
            //comboSource = new DataTable();
            CreateDialog();

            Folder folder = new Folder();
            
            Button cancel = new Button() { Text = "Cancel", Left = 150, Width = 100, Top = 20 };
            Button confirmation = new Button() { Text = "Save", Left = 350, Width = 100, Top = 20 };
            confirmation.Click += (sender, e) => { saveFolder(sender, e); };
            cancel.Click += (sender, e) => { prompt.Close(); };
            panelButoane.Controls.Add(confirmation);
            panelButoane.Controls.Add(cancel);
            prompt.ShowDialog();        
        }


        private void saveFolder(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            string format = "d/M/yyyy";
            Folder folder = new Folder();
            Act act = new Act();
            Situatie situatie = new Situatie();
            Stare stare = new Stare();

            //         folder.Instanta = (Instanta) comboBoxIndicativInstanta.SelectedItem;

            folder.Instanta = InstantaRepository.GetInstantaRepository.GetById(1);
            //folder.Instanta.Id_instanta = 1;
            folder.Cod_value_a = textBoxCodDosar1.Text;
            folder.Cod_value_b = textBoxCodDosar2.Text;
            folder.Cod_value_c = textBoxCodDosar3.Text;
            folder.Cod_value_d = textBoxCodDosar4.Text;
            folder.Cod_value = folder.Cod_value_a + '/' + folder.Cod_value_b + '/' + folder.Cod_value_c + '/' + folder.Cod_value_d;

            folder.Nume_cl = textBoxNumeClient.Text;
            folder.Nume_tit_dosar = textBoxNumeTitular.Text;

            act.Tip_act = textBoxTipAct.Text;
            act.Data = DateTime.ParseExact(textBoxDataAct.Text, format, CultureInfo.InvariantCulture);

            situatie.Nume_situatie = textBoxDetaliiAct.Text;
            situatie.Nr_zile_ramase = int.Parse(textBoxZileRamase.Text);
            //10
            situatie.Descriere = "";
            SituatieService.GetSituatieService.Add(situatie);
            act.Situatie = situatie;

            stare.Nume_intrebare = textBoxNumeRedactata.Text;
            stare.Data_intrebare = DateTime.ParseExact(textBoxDataAct.Text, format, CultureInfo.InvariantCulture);

            //stare.Nume_intrebare = textBoxNumeComunicata.Text;
            //stare.Data_intrebare = DateTime.Parse(textBoxDataComunicata.Text);
            stare.Adresa = textBoxAdresaComunicata.Text;

            //stare.Tip = textBoxNumeApelRecurs.Text;
            //stare.Data_tip = DateTime.Parse(textBoxDataApelRecurs.Text);
            stare.Nume_avct = textBoxNumeAvc.Text;

            //stare.Plecat = textBoxNumePlecat;
            //stare.Data_plecat = textBoxDataPlecat.Text;
            stare.Instanta = InstantaRepository.GetInstantaRepository.GetById(1);
            //stare.Instanta.Id_instanta = 1;
            //stare.Inregistrat = textBoxNumeInregistrat.Text;
            //stare.Data_inregistrare = textBoxDataInregistrat.Text;

            stare.Nume_jdctr = textBoxJudecatori.Text;
            StareRepository.GetStareRepository.Add(stare);
            //stare.Data_fotocopiat = DateTime.Parse(textBoxFotoCopiat.Text);
            //stare.Mentiuni = textBoxMentiuni.Text;
            act.Stare = stare;
            ActService.GetActService.Add(act);
            folder.Act = act;
            FolderService.GetFolderService.Add(folder);
        }
    }
}

//ListView instantaList = new ListView();
//ListViewItem listview = new ListViewItem(InstantaRepository.GetInstantaRepository.FindAllInstantaName().ToArray());
//instantaList.Items.Add(listview);