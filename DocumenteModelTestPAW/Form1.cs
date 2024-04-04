using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace DocumenteModelTestPAW
{
    public partial class Form1 : Form
    {
        Registru registru = new Registru();



        public Form1()
        {
            InitializeComponent();
            registru.AdaugaDocument("test");
            registru.AdaugaDocument("test2");
            registru.AdaugaDocument("test3");
            registru.AdaugaDocument("test4");

            //string mesajAfisare = "";
            ////foreach (Document doc in registru.documents)
            ////    mesajAfisare += doc.ToString() + Environment.NewLine;
            //mesajAfisare += registru["test2"].ToString();

            //MessageBox.Show(mesajAfisare);
            LoadListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titlu = textBoxTiltu.Text;

            registru.AdaugaDocument(titlu);

            MessageBox.Show("Document adaugat cu success!");
            LoadListView();
        }

        void LoadListView()
        {
            listView1.Items.Clear();
            foreach (Document doc in registru.documents)
            {
                ListViewItem item = new ListViewItem(doc.cod.ToString());
                item.SubItems.Add(doc.titlu);
                item.SubItems.Add(doc.data.ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            if(lv.SelectedItems.Count > 0)
            {
                textBoxId.Text = lv.SelectedItems[0].Text;
                buttonRemove.Enabled = true;
            } else
            {
                textBoxId.Text = "";
                buttonRemove.Enabled = false;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            using (ConfirmDialog form2 = new ConfirmDialog())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (listView1.Items.Count > 0)
                    {
                        ListViewItem lvi = listView1.SelectedItems[0];
                        string titlu = lvi.Text;
                        int cod = Convert.ToInt32(titlu);
                        registru.RemoveDocumentWithId(cod);
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("Nu exista un document selectat!");
                    }
                } else
                {
                    MessageBox.Show("Operatia a fost anulata");
                }
            }
             
        }
    }
}
