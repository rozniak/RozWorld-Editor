namespace RozWorld_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemGUIOMETRY = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemMoveNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCloneNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemToolbars = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubItemToolbarStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSubItemHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRozWorldPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditorDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditorRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TabUI = new System.Windows.Forms.TabControl();
            this.ContextTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllOnTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllOnTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.cloneToNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.ContextTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuView,
            this.MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(814, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu Strip";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemNew,
            this.MenuItemOpen,
            this.MenuFileSeparator1,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.MenuItemSaveAll,
            this.MenuFileSeparator2,
            this.MenuItemRecent,
            this.MenuFileSeparator3,
            this.MenuItemClose,
            this.MenuItemCloseAll,
            this.MenuFileSeparator4,
            this.MenuItemExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(35, 20);
            this.MenuFile.Text = "File";
            // 
            // ItemNew
            // 
            this.ItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSubItemWorld,
            this.MenuSubItemPlayer,
            this.MenuSubItemGUIOMETRY});
            this.ItemNew.Image = ((System.Drawing.Image)(resources.GetObject("ItemNew.Image")));
            this.ItemNew.Name = "ItemNew";
            this.ItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ItemNew.Size = new System.Drawing.Size(193, 22);
            this.ItemNew.Text = "New...";
            // 
            // MenuSubItemWorld
            // 
            this.MenuSubItemWorld.Image = ((System.Drawing.Image)(resources.GetObject("MenuSubItemWorld.Image")));
            this.MenuSubItemWorld.Name = "MenuSubItemWorld";
            this.MenuSubItemWorld.Size = new System.Drawing.Size(154, 22);
            this.MenuSubItemWorld.Text = "World";
            // 
            // MenuSubItemPlayer
            // 
            this.MenuSubItemPlayer.Image = ((System.Drawing.Image)(resources.GetObject("MenuSubItemPlayer.Image")));
            this.MenuSubItemPlayer.Name = "MenuSubItemPlayer";
            this.MenuSubItemPlayer.Size = new System.Drawing.Size(154, 22);
            this.MenuSubItemPlayer.Text = "Player";
            // 
            // MenuSubItemGUIOMETRY
            // 
            this.MenuSubItemGUIOMETRY.Image = global::RozWorld_Editor.Properties.Resources.NewBINIcon;
            this.MenuSubItemGUIOMETRY.Name = "MenuSubItemGUIOMETRY";
            this.MenuSubItemGUIOMETRY.Size = new System.Drawing.Size(154, 22);
            this.MenuSubItemGUIOMETRY.Text = "GUIOMETRY.BIN";
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemOpen.Image")));
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpen.Size = new System.Drawing.Size(193, 22);
            this.MenuItemOpen.Text = "Open...";
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            this.MenuFileSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSave.Image")));
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(193, 22);
            this.MenuItemSave.Text = "Save";
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSaveAs.Image")));
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveAs.Size = new System.Drawing.Size(193, 22);
            this.MenuItemSaveAs.Text = "Save As...";
            // 
            // MenuItemSaveAll
            // 
            this.MenuItemSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSaveAll.Image")));
            this.MenuItemSaveAll.Name = "MenuItemSaveAll";
            this.MenuItemSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveAll.Size = new System.Drawing.Size(193, 22);
            this.MenuItemSaveAll.Text = "Save All...";
            // 
            // MenuFileSeparator2
            // 
            this.MenuFileSeparator2.Name = "MenuFileSeparator2";
            this.MenuFileSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuItemRecent
            // 
            this.MenuItemRecent.Name = "MenuItemRecent";
            this.MenuItemRecent.Size = new System.Drawing.Size(193, 22);
            this.MenuItemRecent.Text = "Recent...";
            // 
            // MenuFileSeparator3
            // 
            this.MenuFileSeparator3.Name = "MenuFileSeparator3";
            this.MenuFileSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemClose.Image")));
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.MenuItemClose.Size = new System.Drawing.Size(193, 22);
            this.MenuItemClose.Text = "Close";
            // 
            // MenuItemCloseAll
            // 
            this.MenuItemCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCloseAll.Image")));
            this.MenuItemCloseAll.Name = "MenuItemCloseAll";
            this.MenuItemCloseAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.MenuItemCloseAll.Size = new System.Drawing.Size(193, 22);
            this.MenuItemCloseAll.Text = "Close All";
            // 
            // MenuFileSeparator4
            // 
            this.MenuFileSeparator4.Name = "MenuFileSeparator4";
            this.MenuFileSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(193, 22);
            this.MenuItemExit.Text = "Exit";
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUndo,
            this.MenuItemRedo,
            this.MenuEditSeparator1,
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste,
            this.MenuItemDelete,
            this.MenuEditSeparator2,
            this.MenuItemSelectAll});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(37, 20);
            this.MenuEdit.Text = "Edit";
            // 
            // MenuItemUndo
            // 
            this.MenuItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemUndo.Image")));
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuItemUndo.Size = new System.Drawing.Size(156, 22);
            this.MenuItemUndo.Text = "Undo";
            // 
            // MenuItemRedo
            // 
            this.MenuItemRedo.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemRedo.Image")));
            this.MenuItemRedo.Name = "MenuItemRedo";
            this.MenuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuItemRedo.Size = new System.Drawing.Size(156, 22);
            this.MenuItemRedo.Text = "Redo";
            // 
            // MenuEditSeparator1
            // 
            this.MenuEditSeparator1.Name = "MenuEditSeparator1";
            this.MenuEditSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCut.Image")));
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemCut.Size = new System.Drawing.Size(156, 22);
            this.MenuItemCut.Text = "Cut";
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCopy.Image")));
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuItemCopy.Size = new System.Drawing.Size(156, 22);
            this.MenuItemCopy.Text = "Copy";
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemPaste.Image")));
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemPaste.Size = new System.Drawing.Size(156, 22);
            this.MenuItemPaste.Text = "Paste";
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemDelete.Image")));
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuItemDelete.Size = new System.Drawing.Size(156, 22);
            this.MenuItemDelete.Text = "Delete";
            // 
            // MenuEditSeparator2
            // 
            this.MenuEditSeparator2.Name = "MenuEditSeparator2";
            this.MenuEditSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // MenuItemSelectAll
            // 
            this.MenuItemSelectAll.Name = "MenuItemSelectAll";
            this.MenuItemSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuItemSelectAll.Size = new System.Drawing.Size(156, 22);
            this.MenuItemSelectAll.Text = "Select All";
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewWindow,
            this.MenuViewSeparator1,
            this.MenuItemMoveNewWindow,
            this.MenuItemCloneNewWindow,
            this.MenuViewSeparator2,
            this.MenuItemToolbars,
            this.MenuViewSeparator3,
            this.MenuSubItemHomePage});
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(41, 20);
            this.MenuView.Text = "View";
            // 
            // MenuItemNewWindow
            // 
            this.MenuItemNewWindow.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemNewWindow.Image")));
            this.MenuItemNewWindow.Name = "MenuItemNewWindow";
            this.MenuItemNewWindow.Size = new System.Drawing.Size(200, 22);
            this.MenuItemNewWindow.Text = "New Window";
            // 
            // MenuViewSeparator1
            // 
            this.MenuViewSeparator1.Name = "MenuViewSeparator1";
            this.MenuViewSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // MenuItemMoveNewWindow
            // 
            this.MenuItemMoveNewWindow.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemMoveNewWindow.Image")));
            this.MenuItemMoveNewWindow.Name = "MenuItemMoveNewWindow";
            this.MenuItemMoveNewWindow.Size = new System.Drawing.Size(200, 22);
            this.MenuItemMoveNewWindow.Text = "Move Tab to New Window";
            // 
            // MenuItemCloneNewWindow
            // 
            this.MenuItemCloneNewWindow.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCloneNewWindow.Image")));
            this.MenuItemCloneNewWindow.Name = "MenuItemCloneNewWindow";
            this.MenuItemCloneNewWindow.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCloneNewWindow.Text = "Clone Tab to New Window";
            // 
            // MenuViewSeparator2
            // 
            this.MenuViewSeparator2.Name = "MenuViewSeparator2";
            this.MenuViewSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // MenuItemToolbars
            // 
            this.MenuItemToolbars.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSubItemToolbarStandard});
            this.MenuItemToolbars.Name = "MenuItemToolbars";
            this.MenuItemToolbars.Size = new System.Drawing.Size(200, 22);
            this.MenuItemToolbars.Text = "Toolbars...";
            // 
            // MenuSubItemToolbarStandard
            // 
            this.MenuSubItemToolbarStandard.AutoSize = false;
            this.MenuSubItemToolbarStandard.Checked = true;
            this.MenuSubItemToolbarStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuSubItemToolbarStandard.Name = "MenuSubItemToolbarStandard";
            this.MenuSubItemToolbarStandard.Size = new System.Drawing.Size(152, 22);
            this.MenuSubItemToolbarStandard.Text = "Standard";
            this.MenuSubItemToolbarStandard.Click += new System.EventHandler(this.ToolstripToggleItem_Click);
            // 
            // MenuViewSeparator3
            // 
            this.MenuViewSeparator3.Name = "MenuViewSeparator3";
            this.MenuViewSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // MenuSubItemHomePage
            // 
            this.MenuSubItemHomePage.Image = ((System.Drawing.Image)(resources.GetObject("MenuSubItemHomePage.Image")));
            this.MenuSubItemHomePage.Name = "MenuSubItemHomePage";
            this.MenuSubItemHomePage.Size = new System.Drawing.Size(200, 22);
            this.MenuSubItemHomePage.Text = "Home Page";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRozWorldPage,
            this.MenuHelpSeparator1,
            this.MenuItemEditorDocs,
            this.MenuItemEditorRepo,
            this.MenuHelpSeparator2,
            this.MenuItemAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(40, 20);
            this.MenuHelp.Text = "Help";
            // 
            // MenuItemRozWorldPage
            // 
            this.MenuItemRozWorldPage.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemRozWorldPage.Image")));
            this.MenuItemRozWorldPage.Name = "MenuItemRozWorldPage";
            this.MenuItemRozWorldPage.Size = new System.Drawing.Size(202, 22);
            this.MenuItemRozWorldPage.Text = "RozWorld Home Page";
            // 
            // MenuHelpSeparator1
            // 
            this.MenuHelpSeparator1.Name = "MenuHelpSeparator1";
            this.MenuHelpSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // MenuItemEditorDocs
            // 
            this.MenuItemEditorDocs.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemEditorDocs.Image")));
            this.MenuItemEditorDocs.Name = "MenuItemEditorDocs";
            this.MenuItemEditorDocs.Size = new System.Drawing.Size(202, 22);
            this.MenuItemEditorDocs.Text = "Editor Documentation";
            // 
            // MenuItemEditorRepo
            // 
            this.MenuItemEditorRepo.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemEditorRepo.Image")));
            this.MenuItemEditorRepo.Name = "MenuItemEditorRepo";
            this.MenuItemEditorRepo.Size = new System.Drawing.Size(202, 22);
            this.MenuItemEditorRepo.Text = "Editor GitHub Repository";
            // 
            // MenuHelpSeparator2
            // 
            this.MenuHelpSeparator2.Name = "MenuHelpSeparator2";
            this.MenuHelpSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItemAbout.Size = new System.Drawing.Size(202, 22);
            this.MenuItemAbout.Text = "About RozWorld Editor";
            // 
            // TabUI
            // 
            this.TabUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabUI.Location = new System.Drawing.Point(0, 24);
            this.TabUI.Name = "TabUI";
            this.TabUI.SelectedIndex = 0;
            this.TabUI.Size = new System.Drawing.Size(814, 556);
            this.TabUI.TabIndex = 1;
            this.TabUI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TabUI_MouseUp);
            // 
            // ContextTabs
            // 
            this.ContextTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem,
            this.closeAllOnTheLeftToolStripMenuItem,
            this.closeAllOnTheRightToolStripMenuItem,
            this.toolStripSeparator17,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator16,
            this.openContainingFolderToolStripMenuItem,
            this.toolStripSeparator18,
            this.moveToNewWindowToolStripMenuItem,
            this.cloneToNewWindowToolStripMenuItem,
            this.toolStripSeparator15,
            this.deleteAndCloseToolStripMenuItem});
            this.ContextTabs.Name = "contextMenuStrip1";
            this.ContextTabs.Size = new System.Drawing.Size(188, 248);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeTabToolStripMenuItem.Image")));
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeAllButThisToolStripMenuItem.Image")));
            this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
            this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAllButThisToolStripMenuItem.Text = "Close All Except This";
            // 
            // closeAllOnTheLeftToolStripMenuItem
            // 
            this.closeAllOnTheLeftToolStripMenuItem.Image = global::RozWorld_Editor.Properties.Resources.LeftArrowIcon;
            this.closeAllOnTheLeftToolStripMenuItem.Name = "closeAllOnTheLeftToolStripMenuItem";
            this.closeAllOnTheLeftToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAllOnTheLeftToolStripMenuItem.Text = "Close All on the Left";
            // 
            // closeAllOnTheRightToolStripMenuItem
            // 
            this.closeAllOnTheRightToolStripMenuItem.Image = global::RozWorld_Editor.Properties.Resources.RightArrowIcon;
            this.closeAllOnTheRightToolStripMenuItem.Name = "closeAllOnTheRightToolStripMenuItem";
            this.closeAllOnTheRightToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAllOnTheRightToolStripMenuItem.Text = "Close All on the Right";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(184, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem1.Image")));
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(184, 6);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openContainingFolderToolStripMenuItem.Image")));
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open Containing Folder";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(184, 6);
            // 
            // moveToNewWindowToolStripMenuItem
            // 
            this.moveToNewWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem1,
            this.toolStripSeparator19});
            this.moveToNewWindowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveToNewWindowToolStripMenuItem.Image")));
            this.moveToNewWindowToolStripMenuItem.Name = "moveToNewWindowToolStripMenuItem";
            this.moveToNewWindowToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.moveToNewWindowToolStripMenuItem.Text = "Move to...";
            // 
            // newWindowToolStripMenuItem1
            // 
            this.newWindowToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newWindowToolStripMenuItem1.Image")));
            this.newWindowToolStripMenuItem1.Name = "newWindowToolStripMenuItem1";
            this.newWindowToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.newWindowToolStripMenuItem1.Text = "New Window";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(133, 6);
            // 
            // cloneToNewWindowToolStripMenuItem
            // 
            this.cloneToNewWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem2,
            this.toolStripSeparator20});
            this.cloneToNewWindowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cloneToNewWindowToolStripMenuItem.Image")));
            this.cloneToNewWindowToolStripMenuItem.Name = "cloneToNewWindowToolStripMenuItem";
            this.cloneToNewWindowToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cloneToNewWindowToolStripMenuItem.Text = "Clone to...";
            // 
            // newWindowToolStripMenuItem2
            // 
            this.newWindowToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("newWindowToolStripMenuItem2.Image")));
            this.newWindowToolStripMenuItem2.Name = "newWindowToolStripMenuItem2";
            this.newWindowToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.newWindowToolStripMenuItem2.Text = "New Window";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(133, 6);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(184, 6);
            // 
            // deleteAndCloseToolStripMenuItem
            // 
            this.deleteAndCloseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteAndCloseToolStripMenuItem.Image")));
            this.deleteAndCloseToolStripMenuItem.Name = "deleteAndCloseToolStripMenuItem";
            this.deleteAndCloseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteAndCloseToolStripMenuItem.Text = "Delete and Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 580);
            this.Controls.Add(this.TabUI);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 590);
            this.Name = "MainForm";
            this.Text = "RozWorld Editor - ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ContextTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem ItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.TabControl TabUI;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemWorld;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemPlayer;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemGUIOMETRY;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRecent;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCloseAll;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewWindow;
        private System.Windows.Forms.ToolStripSeparator MenuViewSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMoveNewWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCloneNewWindow;
        private System.Windows.Forms.ToolStripSeparator MenuViewSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolbars;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemToolbarStandard;
        private System.Windows.Forms.ToolStripSeparator MenuViewSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuSubItemHomePage;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRozWorldPage;
        private System.Windows.Forms.ToolStripSeparator MenuHelpSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditorDocs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditorRepo;
        private System.Windows.Forms.ToolStripSeparator MenuHelpSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAll;
        private System.Windows.Forms.ContextMenuStrip ContextTabs;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllOnTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllOnTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem moveToNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem cloneToNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem deleteAndCloseToolStripMenuItem;
    }
}

