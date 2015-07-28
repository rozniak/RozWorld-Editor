using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RozWorld_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 29; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { "6", "Bacon", "The Bacon of Gods", "1:70,8:0", "2" }));
            }
        }
    }
}
