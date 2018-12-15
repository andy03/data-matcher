using DataMacher.apb.Data;
using DataMacher.apb.Service;
using System.Windows.Forms;

namespace DataMacher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.folderList = new System.Windows.Forms.ListView();
            this.instanta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_dosar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume_client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newButton = new System.Windows.Forms.Button();
            this.nume_titular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa_stare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instanta_stare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip_act = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_act = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_stare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.judecatorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_fotocopiat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.folderList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // folderList
            // 
            this.folderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.instanta,
            this.nr_dosar,
            this.nume_client,
            this.nume_titular,
            this.tip_act,
            this.data_act,
            this.Stare,
            this.data_stare,
            this.adresa_stare,
            this.instanta_stare,
            this.judecatorie,
            this.data_fotocopiat});
            this.folderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList.FullRowSelect = true;
            this.folderList.Location = new System.Drawing.Point(327, 143);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(969, 416);
            this.folderList.TabIndex = 0;
            this.folderList.UseCompatibleStateImageBehavior = false;
            this.folderList.View = System.Windows.Forms.View.Details;
            this.folderList.DoubleClick += new System.EventHandler(this.folderList_DoubleClick);
            // 
            // instanta
            // 
            this.instanta.Text = "Instanta";
            this.instanta.Width = 70;
            // 
            // nr_dosar
            // 
            this.nr_dosar.Text = "Nr Dosar";
            this.nr_dosar.Width = 70;
            // 
            // nume_client
            // 
            this.nume_client.Text = "Nume Client";
            this.nume_client.Width = 140;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 416);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(327, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 134);
            this.panel2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(378, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatrix_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatrix_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(516, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 134);
            this.panel3.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(52, 37);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "new folder";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // nume_titular
            // 
            this.nume_titular.Text = "Nume Titular";
            this.nume_titular.Width = 140;
            // 
            // adresa_stare
            // 
            this.adresa_stare.DisplayIndex = 4;
            this.adresa_stare.Text = "Adresa";
            this.adresa_stare.Width = 70;
            // 
            // instanta_stare
            // 
            this.instanta_stare.DisplayIndex = 5;
            this.instanta_stare.Text = "Instanta Stare";
            this.instanta_stare.Width = 70;
            // 
            // tip_act
            // 
            this.tip_act.DisplayIndex = 6;
            this.tip_act.Text = "Tip Act";
            this.tip_act.Width = 70;
            // 
            // data_act
            // 
            this.data_act.DisplayIndex = 7;
            this.data_act.Text = "Data Act";
            // 
            // Stare
            // 
            this.Stare.DisplayIndex = 8;
            this.Stare.Text = "Stare";
            this.Stare.Width = 70;
            // 
            // data_stare
            // 
            this.data_stare.DisplayIndex = 9;
            this.data_stare.Text = "Data Stare";
            this.data_stare.Width = 70;
            // 
            // judecatorie
            // 
            this.judecatorie.Text = "Judecatorie";
            this.judecatorie.Width = 70;
            // 
            // data_fotocopiat
            // 
            this.data_fotocopiat.Text = "Data Fotocopiat";
            this.data_fotocopiat.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "DataMatcher v1.0 ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView folderList;
        private System.Windows.Forms.Button newButton;
        private NewFolderDialog createNewFolderDialog;

        private InitializeListService initializeListService;
        private ColumnHeader instanta;
        private ColumnHeader nr_dosar;
        private ColumnHeader nume_client;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private Button searchButton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ColumnHeader nume_titular;
        private ColumnHeader tip_act;
        private ColumnHeader data_act;
        private ColumnHeader Stare;
        private ColumnHeader data_stare;
        private ColumnHeader adresa_stare;
        private ColumnHeader instanta_stare;
        private ColumnHeader judecatorie;
        private ColumnHeader data_fotocopiat;
    }
}