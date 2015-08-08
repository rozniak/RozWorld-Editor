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
        /**
         * Keep track of the tab ID's to make unique names.
         */
        private int _NextWorldTabID;
        public int NextWorldTabID
        {
            get { return this._NextWorldTabID++; }
            private set { this._NextWorldTabID = value; }
        }

        private int _NextPlayerTabID;
        public int NextPlayerTabID
        {
            get { return this._NextPlayerTabID++; }
            private set { this._NextPlayerTabID = value; }
        }

        private int _NextGUIOMETRYTabID;
        public int NextGUIOMETRYTabID
        {
            get { return this._NextGUIOMETRYTabID++; }
            private set { this._NextGUIOMETRYTabID = value; }
        }


        public MainForm(bool homePage = false)
        {
            InitializeComponent();

            // Manage toolbars from user settings
            if (EditorEnvironment.UserSettings.ToolbarStandardActive)
            {
                this.SetToolbarStatus("ToolbarStandard", true);
            }

            if (homePage)
            {
                this.TabUI.TabPages.Add(new Tab.HomePage(this.TabUI));
            }

            UpdateToolbarsTabDetails();
        }


        /// <summary>
        /// Sets the status of a toolbar on or off.
        /// </summary>
        /// <param name="toolbar">The name of the toolbar.</param>
        /// <param name="status">The new status of the toolbar.</param>
        public void SetToolbarStatus(string toolbarName, bool status)
        {
            if (status)
            {
                switch (toolbarName)
                {
                    case "ToolbarStandard":
                        this.Controls.Add(new Toolbar.Standard(this));
                        this.MenuSubItemToolbarStandard.Checked = true;
                        break;
                }
            }
            else
            {
                switch (toolbarName)
                {
                    case "ToolbarStandard":
                        this.Controls.RemoveByKey(toolbarName);
                        this.MenuSubItemToolbarStandard.Checked = false;
                        break;
                }
            }

            MenuStrip.SendToBack(); // Make sure the main menu strip stays at the top
            UpdateToolbarsTabDetails(); // Update the toolbar on the current tab's details
        }


        /// <summary>
        /// Closes all the tabs in this window.
        /// </summary>
        /// <returns>Whether all the tabs were successfully closed or not.</returns>
        public bool CloseAllTabs()
        {
            bool stillClosing = true;

            if (this.TabUI.TabCount > 0)
            {
                int i = 0;

                do
                {
                    stillClosing = ((Tab.EditorTab)this.TabUI.TabPages[i]).Close();
                } while (stillClosing && ++i < this.TabUI.TabCount);
            }

            return stillClosing;
        }


        /// <summary>
        /// [Event] Event overload for UpdateToolbarsTabDetails().
        /// </summary>
        private void UpdateToolbarsTabDetails(object sender, EventArgs e) { UpdateToolbarsTabDetails(); }
        
        /// <summary>
        /// Updates toolbars relevant to details of the currently open tab.
        /// </summary>
        private void UpdateToolbarsTabDetails()
        {
            if (this.TabUI.TabCount > 0)
            {
                var currentTab = (Tab.EditorTab)this.TabUI.SelectedTab;

                /**
                 * Check undo/redo.
                 */
                bool canUndo = currentTab.CanUndo();
                bool canRedo = currentTab.CanRedo();

                this.MenuItemUndo.Enabled = canUndo;
                this.MenuItemRedo.Enabled = canRedo;

                if (this.Controls.ContainsKey("ToolbarStandard"))
                {
                    var standardToolbar = (Toolbar.Standard)this.Controls["ToolbarStandard"];
                    standardToolbar.Items["ButtonUndo"].Enabled = canUndo;
                    standardToolbar.Items["ButtonRedo"].Enabled = canRedo;
                }
            }
        }


        /// <summary>
        /// [Event] "* > New > World" menu item clicked.
        /// </summary>
        public void NewWorld_Click(object sender, EventArgs e)
        {
            this.TabUI.TabPages.Add(new Tab.WorldEditor(this.TabUI, this.NextWorldTabID));
            this.TabUI.SelectedIndex = this.TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > New > Player" menu item clicked.
        /// </summary>
        public void NewPlayer_Click(object sender, EventArgs e)
        {
            this.TabUI.TabPages.Add(new Tab.PlayerEditor(this.TabUI, this.NextPlayerTabID));
            this.TabUI.SelectedIndex = this.TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > New > GUIOMETRY.BIN" menu item clicked.
        /// </summary>
        public void NewGUIOMETRY_Click(object sender, EventArgs e)
        {
            this.TabUI.TabPages.Add(new Tab.GUIOMETRYEditor(this.TabUI, this.NextGUIOMETRYTabID));
            this.TabUI.SelectedIndex = this.TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > Redo" menu item clicked.
        /// </summary>
        public void RedoItem_Click(object sender, EventArgs e)
        {
            if (this.TabUI.TabCount > 0)
            {
                ((Tab.EditorTab)this.TabUI.SelectedTab).Redo();
            }
        }


        /// <summary>
        /// [Event] "* > Undo" menu item clicked.
        /// </summary>
        public void UndoItem_Click(object sender, EventArgs e)
        {
            if (this.TabUI.TabCount > 0)
            {
                ((Tab.EditorTab)this.TabUI.SelectedTab).Undo();
            }
        }


        /// <summary>
        /// [Event] "View > Toolbars > * " clicked.
        /// </summary>
        private void ToolstripToggleItem_Click(object sender, EventArgs e)
        {
            var menuItemSender = ((ToolStripMenuItem)sender);
            string toolbar = menuItemSender.Name.Substring(11);

            EditorEnvironment.SetToolbarStatus(toolbar, !menuItemSender.Checked);
        }


        /// <summary>
        /// [Event] Form loaded.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e) { }


        /// <summary>
        /// [Event] Form closing.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool closeSuccessful = this.CloseAllTabs();

            if (closeSuccessful)
            {
                EditorEnvironment.CloseWindow(this.Name);
            }
            else
            {
                e.Cancel = true;
            }
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


        /// <summary>
        /// Main tab interface changed tab.
        /// </summary>
        private void TabUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabUI.TabCount > 0)
            {
                string tabTitle = this.TabUI.SelectedTab.Text;

                if (tabTitle == "Home Page")
                {
                    this.Text = "RozWorld Editor";
                }
                else
                {
                    this.Text = tabTitle + " - RozWorld Editor";
                }
            }
            else
            {
                this.Text = "RozWorld Editor";
            }

            // Update toolbars relevant to this tab
            UpdateToolbarsTabDetails(sender, e);
        }


        /// <summary>
        /// [Event] "Tab Context Menu > Close Tab" clicked.
        /// </summary>
        private void ContextCloseTab_Click(object sender, EventArgs e)
        {
            ((Tab.EditorTab)this.TabUI.SelectedTab).Close();
        }


        /// <summary>
        /// [Event] "Edit" clicked.
        /// </summary>
        private void MenuEdit_Click(object sender, EventArgs e)
        {
            UpdateToolbarsTabDetails(sender, e);
        }


        /// <summary>
        /// [Event] "File > Exit" clicked or ALT+F4 pressed.
        /// </summary>
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            EditorEnvironment.Exit();
        }


        /// <summary>
        /// [Event] "View > New Window" clicked.
        /// </summary>
        private void MenuItemNewWindow_Click(object sender, EventArgs e)
        {
            EditorEnvironment.CreateWindow(EditorEnvironment.GenerateWindowName());
        }
    }
}
