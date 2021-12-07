using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surukleBirakFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.adım
            list_pull.AllowDrop = true;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_enter.Text!="")
            {
                list_push.Items.Add(txt_enter.Text.ToString());

            }
            txt_enter.Clear();
        }

        private void list_push_MouseDown(object sender, MouseEventArgs e)
        {
            //2.adım
            list_push.DoDragDrop(list_push.SelectedItem, DragDropEffects.Move);
        }

        private void list_pull_DragEnter(object sender, DragEventArgs e)
        {
            //3.adım
            e.Effect = DragDropEffects.Move;

        }

        private void list_pull_DragDrop(object sender, DragEventArgs e)
        {
            //4.adım
            list_pull.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            list_push.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
        }
    }
}
