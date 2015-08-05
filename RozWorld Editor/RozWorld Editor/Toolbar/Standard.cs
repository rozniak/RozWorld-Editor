/**
 * RozWorld_Editor.Toolbar.Standard -- Editor Standard Toolbar
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Windows.Forms;

namespace RozWorld_Editor.Toolbar
{
    public class Standard : EditorToolbar
    {
        #region Windows Forms Controls

        private ToolStripDropDownButton DropDownNew = new ToolStripDropDownButton();
        private ToolStripMenuItem DropItemNewWorld = new ToolStripMenuItem();
        private ToolStripMenuItem DropItemNewPlayer = new ToolStripMenuItem();
        private ToolStripMenuItem DropItemNewGUIOMETRY = new ToolStripMenuItem();

        private ToolStripButton ButtonOpen = new ToolStripButton();
        private ToolStripButton ButtonSave = new ToolStripButton();
        private ToolStripButton ButtonSaveAll = new ToolStripButton();

        private ToolStripSeparator SeparatorFileClipboardOps = new ToolStripSeparator();

        private ToolStripButton ButtonCut = new ToolStripButton();
        private ToolStripButton ButtonCopy = new ToolStripButton();
        private ToolStripButton ButtonPaste = new ToolStripButton();

        private ToolStripSeparator SeparatorClipboardHistoryOps = new ToolStripSeparator();

        private ToolStripButton ButtonUndo = new ToolStripButton();
        private ToolStripButton ButtonRedo = new ToolStripButton();

        private ToolStripSeparator SeparatorHistorySelectModeOps = new ToolStripSeparator();

        private ToolStripLabel LabelSelectionMode = new ToolStripLabel();
        private ToolStripComboBox ComboSelectionMode = new ToolStripComboBox();

        #endregion


        public Standard(MainForm parentForm)
        {
            #region Windows Forms Initialisation

            this.ParentForm = parentForm;

            this.Items.AddRange(new ToolStripItem[] {
                this.DropDownNew,
                this.ButtonOpen,
                this.ButtonSave,
                this.ButtonSaveAll,
                this.SeparatorFileClipboardOps,
                this.ButtonCut,
                this.ButtonCopy,
                this.ButtonPaste,
                this.SeparatorClipboardHistoryOps,
                this.ButtonUndo,
                this.ButtonRedo,
                this.SeparatorHistorySelectModeOps,
                this.LabelSelectionMode,
                this.ComboSelectionMode
            });

            /**
             * Standard
             */
            this.Dock = DockStyle.Top;
            this.Name = "ToolbarStandard";
            this.Size = new System.Drawing.Size(814, 25);
            this.TabIndex = 2;
            this.Text = "";


            /**
             * DropDownNew
             */
            this.DropDownNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DropDownNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.DropItemNewWorld,
                this.DropItemNewPlayer,
                this.DropItemNewGUIOMETRY
            });
            this.DropDownNew.Image = Properties.Resources.NewIcon;
            this.DropDownNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownNew.Name = "DropDownNew";
            this.DropDownNew.Size = new System.Drawing.Size(29, 22);
            this.DropDownNew.Text = "New... (CTRL+N)";

            /**
             * DropItemNewWorld
             */
            this.DropItemNewWorld.Image = Properties.Resources.NewWorldIcon;
            this.DropItemNewWorld.Name = "DropItemNewWorld";
            this.DropItemNewWorld.Size = new System.Drawing.Size(154, 22);
            this.DropItemNewWorld.Text = "World";
            this.DropItemNewWorld.Click += new System.EventHandler(this.ParentForm.NewWorld_Click);

            /**
             * DropItemNewPlayer
             */
            this.DropItemNewPlayer.Image = Properties.Resources.NewPlayerIcon;
            this.DropItemNewPlayer.Name = "DropItemNewPlayer";
            this.DropItemNewPlayer.Size = new System.Drawing.Size(154, 22);
            this.DropItemNewPlayer.Text = "Player";
            this.DropItemNewPlayer.Click += new System.EventHandler(this.ParentForm.NewPlayer_Click);

            /**
             * DropItemNewGUIOMETRY
             */
            this.DropItemNewGUIOMETRY.Image = Properties.Resources.NewBINIcon;
            this.DropItemNewGUIOMETRY.Name = "DropItemNewGUIOMETRY";
            this.DropItemNewGUIOMETRY.Size = new System.Drawing.Size(154, 22);
            this.DropItemNewGUIOMETRY.Text = "GUIOMETRY.BIN";
            this.DropItemNewGUIOMETRY.Click += new System.EventHandler(this.ParentForm.NewGUIOMETRY_Click);


            /**
             * ButtonOpen
             */
            this.ButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonOpen.Image = Properties.Resources.OpenFileIcon;
            this.ButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.ButtonOpen.Text = "Open File (CTRL+O)";

            /**
             * ButtonSave
             */
            this.ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSave.Image = Properties.Resources.SaveIcon;
            this.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(23, 22);
            this.ButtonSave.Text = "Save (CTRL+S)";

            /**
             * ButtonSaveAll
             */
            this.ButtonSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSaveAll.Image = Properties.Resources.SaveAllIcon;
            this.ButtonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(23, 22);
            this.ButtonSaveAll.Text = "Save All (CTRL+ALT+S)";


            /**
             * SeparatorFileClipboardOps
             */
            this.SeparatorFileClipboardOps.Name = "SeparatorFileClipboardOps";
            this.SeparatorFileClipboardOps.Size = new System.Drawing.Size(6, 25);

            /**
             * ButtonCut
             */
            this.ButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonCut.Image = Properties.Resources.CutIcon;
            this.ButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.Size = new System.Drawing.Size(23, 22);
            this.ButtonCut.Text = "Cut (CTRL+X)";

            /**
             * ButtonCopy
             */
            this.ButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonCopy.Image = Properties.Resources.CopyIcon;
            this.ButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.ButtonCopy.Text = "Copy (CTRL+C)";

            /**
             * ButtonPaste
             */
            this.ButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPaste.Image = Properties.Resources.PasteIcon;
            this.ButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(23, 22);
            this.ButtonPaste.Text = "Paste (CTRL+V)";


            /**
             * SeparatorClipboardHistoryOps
             */
            this.SeparatorClipboardHistoryOps.Name = "SeparatorClipboardHistoryOps";
            this.SeparatorClipboardHistoryOps.Size = new System.Drawing.Size(6, 25);

            /**
             * ButtonUndo
             */
            this.ButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonUndo.Image = Properties.Resources.UndoIcon;
            this.ButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.ButtonUndo.Text = "Undo (CTRL+Z)";

            /**
             * ButtonRedo
             */
            this.ButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonRedo.Image = Properties.Resources.RedoIcon;
            this.ButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.ButtonRedo.Text = "Redo (CTRL+Y)";


            /**
             * SeparatorHistorySelectModeOps
             */
            this.SeparatorHistorySelectModeOps.Name = "SeparatorHistorySelectModeOps";
            this.SeparatorHistorySelectModeOps.Size = new System.Drawing.Size(6, 25);

            /**
             * LabelSelectionMode
             */
            this.LabelSelectionMode.Name = "LabelSelectionMode";
            this.LabelSelectionMode.Size = new System.Drawing.Size(83, 22);
            this.LabelSelectionMode.Text = "Selection Mode:";

            /**
             * ComboSelectionMode
             */
            this.ComboSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSelectionMode.Items.AddRange(new object[] {
            "Tiles",
            "Walls",
            "Entities",
            "Projectiles"
            });
            this.ComboSelectionMode.Name = "ComboSelectionMode";
            this.ComboSelectionMode.Size = new System.Drawing.Size(121, 25);

            #endregion
        }
    }
}
