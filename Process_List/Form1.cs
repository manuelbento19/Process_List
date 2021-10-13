using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Process_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            foreach (var item in process)
            {
                ListViewItem list_item = new ListViewItem();
                list_item.Text = item.ProcessName;
                list_item.SubItems.Add(item.Id.ToString());
                listView1.Items.Add(list_item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
