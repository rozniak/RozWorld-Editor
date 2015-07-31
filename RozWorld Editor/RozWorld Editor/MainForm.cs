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
            
        }


        /// <summary>
        /// [Event] Main tab interface mouse up.
        /// </summary>
        private void TabUI_MouseUp(object sender, MouseEventArgs e)
        {
            bool foundTab = false;
            int i = 0;

            if (e.Button == MouseButtons.Right) // Show context-menu for the clicked tab.
            {
                do
                {
                    Rectangle tabBounds = this.TabUI.GetTabRect(i);

                    if (tabBounds.Contains(e.Location))
                    {
                        this.TabUI.SelectedIndex = i;
                        this.contextMenuStrip1.Show(this.TabUI, e.Location);
                        foundTab = true;
                    }
                } while (!foundTab && i++ < this.TabUI.TabCount);
            }
            else if (e.Button == MouseButtons.Middle) // Request to close the middle clicked tab.
            {
                do
                {
                    Rectangle tabBounds = this.TabUI.GetTabRect(i);

                    if (tabBounds.Contains(e.Location))
                    {
                        this.TabUI.TabPages.RemoveAt(i);
                        foundTab = true;
                    }
                } while (!foundTab && i++ < this.TabUI.TabCount);
            }
        }
    }
}
