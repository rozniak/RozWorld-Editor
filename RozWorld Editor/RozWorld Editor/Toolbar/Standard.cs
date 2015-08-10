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
                DropDownNew,
                ButtonOpen,
                ButtonSave,
                ButtonSaveAll,
                SeparatorFileClipboardOps,
                ButtonCut,
                ButtonCopy,
                ButtonPaste,
                SeparatorClipboardHistoryOps,
                ButtonUndo,
                ButtonRedo,
                SeparatorHistorySelectModeOps,
                LabelSelectionMode,
                ComboSelectionMode
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
            DropDownNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DropDownNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                DropItemNewWorld,
                DropItemNewPlayer,
                DropItemNewGUIOMETRY
            });
            DropDownNew.Image = Properties.Resources.NewIcon;
            DropDownNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            DropDownNew.Name = "DropDownNew";
            DropDownNew.Size = new System.Drawing.Size(29, 22);
            DropDownNew.Text = "New... (CTRL+N)";

            /**
             * DropItemNewWorld
             */
            DropItemNewWorld.Image = Properties.Resources.NewWorldIcon;
            DropItemNewWorld.Name = "DropItemNewWorld";
            DropItemNewWorld.Size = new System.Drawing.Size(154, 22);
            DropItemNewWorld.Text = "World";
            DropItemNewWorld.Click += new System.EventHandler(ParentForm.NewWorld_Click);

            /**
             * DropItemNewPlayer
             */
            DropItemNewPlayer.Image = Properties.Resources.NewPlayerIcon;
            DropItemNewPlayer.Name = "DropItemNewPlayer";
            DropItemNewPlayer.Size = new System.Drawing.Size(154, 22);
            DropItemNewPlayer.Text = "Player";
            DropItemNewPlayer.Click += new System.EventHandler(ParentForm.NewPlayer_Click);

            /**
             * DropItemNewGUIOMETRY
             */
            DropItemNewGUIOMETRY.Image = Properties.Resources.NewBINIcon;
            DropItemNewGUIOMETRY.Name = "DropItemNewGUIOMETRY";
            DropItemNewGUIOMETRY.Size = new System.Drawing.Size(154, 22);
            DropItemNewGUIOMETRY.Text = "GUIOMETRY.BIN";
            DropItemNewGUIOMETRY.Click += new System.EventHandler(ParentForm.NewGUIOMETRY_Click);


            /**
             * ButtonOpen
             */
            ButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonOpen.Image = Properties.Resources.OpenFileIcon;
            ButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new System.Drawing.Size(23, 22);
            ButtonOpen.Text = "Open File (CTRL+O)";

            /**
             * ButtonSave
             */
            ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonSave.Image = Properties.Resources.SaveIcon;
            ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new System.Drawing.Size(23, 22);
            ButtonSave.Text = "Save (CTRL+S)";

            /**
             * ButtonSaveAll
             */
            ButtonSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonSaveAll.Image = Properties.Resources.SaveAllIcon;
            ButtonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonSaveAll.Name = "ButtonSaveAll";
            ButtonSaveAll.Size = new System.Drawing.Size(23, 22);
            ButtonSaveAll.Text = "Save All (CTRL+ALT+S)";


            /**
             * SeparatorFileClipboardOps
             */
            SeparatorFileClipboardOps.Name = "SeparatorFileClipboardOps";
            SeparatorFileClipboardOps.Size = new System.Drawing.Size(6, 25);

            /**
             * ButtonCut
             */
            ButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonCut.Image = Properties.Resources.CutIcon;
            ButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonCut.Name = "ButtonCut";
            ButtonCut.Size = new System.Drawing.Size(23, 22);
            ButtonCut.Text = "Cut (CTRL+X)";

            /**
             * ButtonCopy
             */
            ButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonCopy.Image = Properties.Resources.CopyIcon;
            ButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonCopy.Name = "ButtonCopy";
            ButtonCopy.Size = new System.Drawing.Size(23, 22);
            ButtonCopy.Text = "Copy (CTRL+C)";

            /**
             * ButtonPaste
             */
            ButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonPaste.Image = Properties.Resources.PasteIcon;
            ButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonPaste.Name = "ButtonPaste";
            ButtonPaste.Size = new System.Drawing.Size(23, 22);
            ButtonPaste.Text = "Paste (CTRL+V)";


            /**
             * SeparatorClipboardHistoryOps
             */
            SeparatorClipboardHistoryOps.Name = "SeparatorClipboardHistoryOps";
            SeparatorClipboardHistoryOps.Size = new System.Drawing.Size(6, 25);

            /**
             * ButtonUndo
             */
            ButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonUndo.Image = Properties.Resources.UndoIcon;
            ButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonUndo.Name = "ButtonUndo";
            ButtonUndo.Size = new System.Drawing.Size(23, 22);
            ButtonUndo.Text = "Undo (CTRL+Z)";

            /**
             * ButtonRedo
             */
            ButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ButtonRedo.Image = Properties.Resources.RedoIcon;
            ButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonRedo.Name = "ButtonRedo";
            ButtonRedo.Size = new System.Drawing.Size(23, 22);
            ButtonRedo.Text = "Redo (CTRL+Y)";


            /**
             * SeparatorHistorySelectModeOps
             */
            SeparatorHistorySelectModeOps.Name = "SeparatorHistorySelectModeOps";
            SeparatorHistorySelectModeOps.Size = new System.Drawing.Size(6, 25);

            /**
             * LabelSelectionMode
             */
            LabelSelectionMode.Name = "LabelSelectionMode";
            LabelSelectionMode.Size = new System.Drawing.Size(83, 22);
            LabelSelectionMode.Text = "Selection Mode:";

            /**
             * ComboSelectionMode
             */
            ComboSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboSelectionMode.Items.AddRange(new object[] {
            "Tiles",
            "Walls",
            "Entities",
            "Projectiles"
            });
            ComboSelectionMode.Name = "ComboSelectionMode";
            ComboSelectionMode.Size = new System.Drawing.Size(121, 25);

            #endregion
        }
    }
}
