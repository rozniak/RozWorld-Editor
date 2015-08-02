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

            ToggleToolbar("ToolbarStandard", false);

            if (homePage)
            {
                this.TabUI.TabPages.Add(new Tab.HomePage());
            }
        }


        /// <summary>
        /// Toggles a toolbar on or off.
        /// </summary>
        /// <param name="toolbar">The name of the toolbar to toggle.</param>
        /// <param name="status">The current status of the toolbar.</param>
        private void ToggleToolbar(string toolbar, bool status)
        {
            if (status)
            {
                switch (toolbar)
                {
                    case "ToolbarStandard":
                        this.Controls.RemoveByKey(toolbar);
                        break;
                }
            }
            else
            {
                switch (toolbar)
                {
                    case "ToolbarStandard":
                        this.Controls.Add(new Toolbar.Standard());
                        break;
                }
            }

            MenuStrip.SendToBack(); // Make sure the main menu strip stays at the top
        }


        /// <summary>
        /// [Event] "View > Toolbars > * " clicked.
        /// </summary>
        private void ToolstripToggleItem_Click(object sender, EventArgs e)
        {
            var menuItemSender = ((ToolStripMenuItem)sender);
            string toolbar = menuItemSender.Name.Substring(11);

            ToggleToolbar(toolbar, menuItemSender.Checked);

            menuItemSender.Checked = !menuItemSender.Checked;
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
                        this.ContextTabs.Show(this.TabUI, e.Location);
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
