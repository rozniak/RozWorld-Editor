/**
 * RozWorld_Editor.MainForm -- Editor Main Window
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace RozWorld_Editor
{
    public partial class MainForm : Form
    {
        public MainForm(bool homePage = false)
        {
            InitializeComponent();

            if (homePage)
            {
                this.TabUI.TabPages.Add(new Tab.HomePage());
            }
        }


        /// <summary>
        /// [Event] Form loaded.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e) { }


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
