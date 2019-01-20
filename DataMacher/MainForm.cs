using DataMacher.apb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataMacher.apb.Utils.IntrebareEnumUtils;

namespace DataMacher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        enum DATA { ASTA, ALTA, CEALALTA };

        private void Load_FolderList()
        {
            Stare Stare = new Stare(REDACTATA, new DateTime(), "adresa", "numbeAvt", new Instanta("numeInstanta"), "numbeJudecatorie", new DateTime());
            Situatie Situatie = new Situatie("nume situatie", 12, "descriere");
            Act Act = new Act(Stare, Situatie, "tipAct", new DateTime());

            Folder Folder = new Folder(new Instanta("22"), "adresa", "adresa", "adresa", "adresa", "adresa", "adresa", Act);


            string[] f1 = { Folder.Nume_cl, Folder.Nume_cl, Folder.Nume_cl };
            string[] f2 = { Folder.Nume_cl, Folder.Nume_cl, Folder.Nume_cl };
            string[] f3 = { Folder.Nume_cl, Folder.Nume_cl, Folder.Nume_cl };

            var listViewItem1 = new ListViewItem(f1);
            var listViewItem2 = new ListViewItem(f2);
            var listViewItem3 = new ListViewItem(f3);

            folderList.Items.Add(listViewItem1);
            folderList.Items.Add(listViewItem2);
            folderList.Items.Add(listViewItem3);

            comboBox1.DataSource = Enum.GetValues(typeof(DATA));
            comboBox2.DataSource = Enum.GetValues(typeof(DATA));

            comboBox1.SelectedIndex = 0;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewFolderDialog.Instance.createNewFolder();
        }

        private void folderList_DoubleClick(object sender, EventArgs e)
        {
            Folder folder = folderList.SelectedItems[0].SubItems;
            NewFolderDialog.Instance.createNewFolder();
           // MessageBox.Show(folderList.SelectedItems[0].SubItems[0].Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_FolderList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {


            string prima = comboBox1.SelectedItem.ToString();
            if (comboBox2.SelectedItem == null) return;
            string doua = comboBox2.SelectedItem.ToString();

            folderList.BeginUpdate();
            folderList.Items.RemoveAt(folderList.Items.Count-1);
            folderList.EndUpdate();

        }
    }
}
