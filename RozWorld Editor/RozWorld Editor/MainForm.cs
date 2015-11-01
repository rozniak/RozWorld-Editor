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
using System.IO;
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
            get { return _NextWorldTabID++; }
            private set { _NextWorldTabID = value; }
        }

        private int _NextPlayerTabID;
        public int NextPlayerTabID
        {
            get { return _NextPlayerTabID++; }
            private set { _NextPlayerTabID = value; }
        }

        private int _NextGUIOMETRYTabID;
        public int NextGUIOMETRYTabID
        {
            get { return _NextGUIOMETRYTabID++; }
            private set { _NextGUIOMETRYTabID = value; }
        }


        public MainForm(bool homePage = false)
        {
            InitializeComponent();

            // Manage toolbars from user settings
            if (EditorEnvironment.UserSettings.ToolbarStandardActive)
            {
                SetToolbarStatus("ToolbarStandard", true);
            }

            if (homePage)
            {
                TabUI.TabPages.Add(new Tab.HomePage(TabUI));
            }

            UpdateToolbarsTabDetails();
        }


        /// <summary>
        /// Closes all the tabs in this window.
        /// </summary>
        /// <returns>Whether all the tabs were successfully closed or not.</returns>
        public bool CloseAllTabs()
        {
            bool stillClosing = true;

            if (TabUI.TabCount > 0)
            {
                int i = 0;

                do
                {
                    stillClosing = ((Tab.EditorTab)TabUI.TabPages[i]).Close();
                } while (stillClosing && ++i < TabUI.TabCount);
            }

            return stillClosing;
        }


        /// <summary>
        /// Opens an open dialog box with a supplied filter.
        /// </summary>
        /// <param name="filter">The desired filter.</param>
        public void OpenFile(Filter filter)
        {
            var openDialog = new OpenFileDialog();

            openDialog.Title = "Open";

            switch (filter)
            {
                case Filter.BIN: // GUIOMETRY.BIN file
                    openDialog.Filter = "GUIOMETRY (*.bin)|*.bin";
                    break;

                case Filter.DAT: // Player file
                    openDialog.Filter = "Player File (*.dat)|*.dat;";
                    break;

                case Filter.SEG: // World segment
                    openDialog.Filter = "World Segment (*.seg)|*.seg";
                    break;

                case Filter.WLD: // World file
                    openDialog.Filter = "World File (*.wld)|*.wld";
                    break;

                case Filter.WLD_SEG:
                    openDialog.Filter = "World Files (*.seg, *.wld)|*.seg;*.wld";
                    break;

                default:
                case Filter.Any: // *.* files
                    openDialog.Filter = "RozWorld Files (*.bin, *.dat, *.wld, *.seg)|*.bin;*.dat;*.wld;*.seg";
                    break;
            }

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(openDialog.FileName).ToLower())
                {
                    /**
                     * GUIOMETRY.BIN
                     */
                    case ".bin":
                        TabUI.TabPages.Add(new Tab.GUIOMETRYEditor(this.TabUI,
                            NextGUIOMETRYTabID, openDialog.FileName));
                        break;

                    /**
                     * Player
                     */
                    case ".dat":
                        // TODO: Open a player tab with the data in
                        break;

                    /**
                     * World
                     */
                    case ".wld":
                        // TODO: Open a world tab with the data in
                        break;

                    /**
                     * World Segment
                     */
                    case ".seg":
                        // TODO: Open a world tab with the data in
                        break;
                }

                TabUI.SelectedIndex = TabUI.TabCount - 1;
            }
        }


        /// <summary>
        /// Opens a save as dialog box filtered for the current tab.
        /// </summary>
        /// <param name="tabTitle">The title of the current tab, used to determine filters.</param>
        /// <returns>The desired filename/path selected by the user.</returns>
        private string SaveAs(string tabTitle = "")
        {
            var saveDialog = new SaveFileDialog();

            saveDialog.Title = "Save As";

            // Determine save filter
            if (tabTitle.StartsWith("GUIOMETRY"))
            {
                saveDialog.Filter = "GUIOMETRY (*.bin)|*.bin";
            }
            else if (tabTitle.StartsWith("Player"))
            {
                saveDialog.Filter = "Player File (*.dat)|*.dat;";
            }
            else if (tabTitle.StartsWith("World"))
            {
                saveDialog.Filter = "World Segment (*.seg)|*.seg";
            }
            else
            {
                saveDialog.Filter = "RozWorld Files (*.bin, *.dat, *.wld, *.seg)|*.bin;*.dat;*.wld;*.seg";
            }

            if (saveDialog.ShowDialog() == DialogResult.OK) return saveDialog.FileName;

            return "";
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
                        Controls.Add(new Toolbar.Standard(this));
                        MenuSubItemToolbarStandard.Checked = true;
                        break;
                }
            }
            else
            {
                switch (toolbarName)
                {
                    case "ToolbarStandard":
                        Controls.RemoveByKey(toolbarName);
                        MenuSubItemToolbarStandard.Checked = false;
                        break;
                }
            }

            MenuStrip.SendToBack(); // Make sure the main menu strip stays at the top
            UpdateToolbarsTabDetails(); // Update the toolbar on the current tab's details
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
            if (TabUI.TabCount > 0 && TabUI.SelectedTab != null)
            {
                var currentTab = (Tab.EditorTab)TabUI.SelectedTab;

                // Check undo / redo
                bool canUndo = currentTab.CanUndo();
                bool canRedo = currentTab.CanRedo();

                MenuItemUndo.Enabled = canUndo;
                MenuItemRedo.Enabled = canRedo;

                if (this.Controls.ContainsKey("ToolbarStandard"))
                {
                    var standardToolbar = (Toolbar.Standard)this.Controls["ToolbarStandard"];
                    standardToolbar.Items["ButtonUndo"].Enabled = canUndo;
                    standardToolbar.Items["ButtonRedo"].Enabled = canRedo;
                }

                // Check save / save as
                bool canSave = currentTab.CanSave && currentTab.IsUnsaved;
                bool canSaveAs = currentTab.CanSave;

                MenuItemSave.Enabled = canSave;
                MenuItemSaveAs.Enabled = canSaveAs;

                if (this.Controls.ContainsKey("ToolbarStandard"))
                {
                    var standardToolbar = (Toolbar.Standard)this.Controls["ToolbarStandard"];
                    standardToolbar.Items["ButtonSave"].Enabled = canSave;
                }
            }
            else
            {
                // Disable all options
                MenuItemUndo.Enabled = false;
                MenuItemRedo.Enabled = false;
                MenuItemSave.Enabled = false;
                MenuItemSaveAs.Enabled = false;

                if (this.Controls.ContainsKey("ToolbarStandard"))
                {
                    var standardToolbar = (Toolbar.Standard)this.Controls["ToolbarStandard"];
                    standardToolbar.Items["ButtonUndo"].Enabled = false;
                    standardToolbar.Items["ButtonRedo"].Enabled = false;
                    standardToolbar.Items["ButtonSave"].Enabled = false;
                }
            }
        }


        /// <summary>
        /// [Event] "* > Open" clicked.
        /// </summary>
        public void OpenItem_Click(object sender, EventArgs e)
        {
            OpenFile(Filter.Any);
        }


        /// <summary>
        /// [Event] "* > New > World" menu item clicked.
        /// </summary>
        public void NewWorld_Click(object sender, EventArgs e)
        {
            TabUI.TabPages.Add(new Tab.WorldEditor(TabUI, NextWorldTabID));
            TabUI.SelectedIndex = TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > New > Player" menu item clicked.
        /// </summary>
        public void NewPlayer_Click(object sender, EventArgs e)
        {
            TabUI.TabPages.Add(new Tab.PlayerEditor(TabUI, NextPlayerTabID));
            TabUI.SelectedIndex = TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > New > GUIOMETRY.BIN" menu item clicked.
        /// </summary>
        public void NewGUIOMETRY_Click(object sender, EventArgs e)
        {
            TabUI.TabPages.Add(new Tab.GUIOMETRYEditor(TabUI, NextGUIOMETRYTabID));
            TabUI.SelectedIndex = TabUI.TabCount - 1;
        }


        /// <summary>
        /// [Event] "* > Redo" menu item clicked.
        /// </summary>
        public void RedoItem_Click(object sender, EventArgs e)
        {
            if (TabUI.TabCount > 0)
            {
                ((Tab.EditorTab)TabUI.SelectedTab).Redo();
            }
        }


        /// <summary>
        /// [Event] "* > Save" clicked.
        /// </summary>
        public void SaveItem_Click(object sender, EventArgs e)
        {
            var currentTab = (Tab.EditorTab)TabUI.SelectedTab;

            if (currentTab.AssociatedFilename != "")
            {
                currentTab.Save();
            }
            else
            {
                // Doesn't have a file name yet, let the user pick one
                string filename = SaveAs(currentTab.Text);

                currentTab.Save(filename);
            }
        }


        /// <summary>
        /// [Event] "* > Save All" clicked.
        /// </summary>
        public void SaveAllItem_Click(object sender, EventArgs e)
        {
            // TODO: Call a save on every tab
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
        /// [Event] "* > Undo" menu item clicked.
        /// </summary>
        public void UndoItem_Click(object sender, EventArgs e)
        {
            if (TabUI.TabCount > 0)
            {
                ((Tab.EditorTab)TabUI.SelectedTab).Undo();
            }
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
            bool closeSuccessful = CloseAllTabs();

            if (closeSuccessful)
            {
                EditorEnvironment.CloseWindow(Name);
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
                    try
                    {
                        Rectangle tabBounds = TabUI.GetTabRect(i);

                        if (tabBounds.Contains(e.Location))
                        {
                            TabUI.SelectedIndex = i;
                            ContextTabs.Show(TabUI, e.Location);
                            foundTab = true;
                        }
                    }
                    /**
                     * This catch block is here due to some strange voodoo that can cause
                     * this loop to continue even though i isn't less than TabUI.TabCount.
                     * 
                     * Will attempt to see the cause later, it seems to happen randomly
                     * during rapid right-clicking of tabs (aka, should never happen in
                     * normal use).
                     */
                    catch (ArgumentOutOfRangeException argRangeEx)
                    {
                        foundTab = true;
                    }
                } while (!foundTab && i++ < TabUI.TabCount);
            }
            else if (e.Button == MouseButtons.Middle) // Request to close the middle clicked tab.
            {
                do
                {
                    Rectangle tabBounds = TabUI.GetTabRect(i);

                    if (tabBounds.Contains(e.Location))
                    {
                        TabUI.TabPages.RemoveAt(i);
                        foundTab = true;
                    }
                } while (!foundTab && i++ < TabUI.TabCount);
            }
        }


        /// <summary>
        /// Main tab interface changed tab.
        /// </summary>
        private void TabUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabUI.SelectedTab != null)
            {
                string tabTitle = TabUI.SelectedTab.Text;

                if (tabTitle == "Home Page")
                {
                    Text = "RozWorld Editor";
                }
                else
                {
                    Text = tabTitle + " - RozWorld Editor";
                }
            }
            else
            {
                Text = "RozWorld Editor";
            }

            // Update toolbars relevant to this tab
            UpdateToolbarsTabDetails(sender, e);
        }


        /// <summary>
        /// [Event] "Tab Context Menu > Close Tab" clicked.
        /// </summary>
        private void ContextCloseTab_Click(object sender, EventArgs e)
        {
            ((Tab.EditorTab)TabUI.SelectedTab).Close();
        }


        /// <summary>
        /// [Event] "File > Exit" clicked or ALT+F4 pressed.
        /// </summary>
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            EditorEnvironment.Exit();
        }


        /// <summary>
        /// [Event] "File > Save As" clicked.
        /// </summary>
        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            var currentTab = (Tab.EditorTab)TabUI.SelectedTab;
            string filename = SaveAs(currentTab.Text);

            if (filename != "")
            {
                currentTab.Save(filename);
            }
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
