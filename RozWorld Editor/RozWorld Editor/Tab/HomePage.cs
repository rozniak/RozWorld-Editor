/**
 * RozWorld_Editor.Tab.HomePage -- Home Page Tab
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Windows.Forms;

namespace RozWorld_Editor.Tab
{
    public class HomePage : EditorTab
    {
        #region Windows Forms Controls

        private PictureBox PictureEditorLogo = new PictureBox();

        private Label LabelNewTasks = new Label();
        private Button ButtonNewWorld = new Button();
        private Button ButtonNewPlayer = new Button();
        private Button ButtonNewGUIOMETRY = new Button();

        private Label LabelOpenTasks = new Label();
        private Button ButtonOpenWorld = new Button();
        private Button ButtonOpenPlayer = new Button();
        private Button ButtonOpenGUIOMETRY = new Button();

        #endregion


        public HomePage(TabControl parentTabUI)
        {
            #region Windows Forms Initialisation

            this.ParentTabUI = parentTabUI;
            this.ParentForm = (MainForm)parentTabUI.Parent;

            this.Controls.Add(PictureEditorLogo);
            this.Controls.Add(LabelNewTasks);
            this.Controls.Add(ButtonNewWorld);
            this.Controls.Add(ButtonNewPlayer);
            this.Controls.Add(ButtonNewGUIOMETRY);
            this.Controls.Add(LabelOpenTasks);
            this.Controls.Add(ButtonOpenWorld);
            this.Controls.Add(ButtonOpenPlayer);
            this.Controls.Add(ButtonOpenGUIOMETRY);

            /**
             * HomePage
             */
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "HomePageTab";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(808, 504);
            this.TabIndex = 0;
            this.Text = "Home Page";
            this.UseVisualStyleBackColor = true;

            /**
             * PictureEditorLogo
             */
            PictureEditorLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            PictureEditorLogo.Image = global::RozWorld_Editor.Properties.Resources.EditorLogo;
            PictureEditorLogo.Location = new System.Drawing.Point(8, 6);
            PictureEditorLogo.Name = "PictureEditorLogo";
            PictureEditorLogo.Size = new System.Drawing.Size(792, 187);
            PictureEditorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            PictureEditorLogo.TabIndex = 0;
            PictureEditorLogo.TabStop = false;

            /**
             * LabelNewTasks
             */
            LabelNewTasks.AutoSize = true;
            LabelNewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelNewTasks.Location = new System.Drawing.Point(8, 196);
            LabelNewTasks.Name = "LabelNewTasks";
            LabelNewTasks.Size = new System.Drawing.Size(87, 16);
            LabelNewTasks.TabIndex = 1;
            LabelNewTasks.Text = "Create New...";

            /**
             * ButtonNewWorld
             */
            ButtonNewWorld.Location = new System.Drawing.Point(8, 215);
            ButtonNewWorld.Name = "ButtonNewWorld";
            ButtonNewWorld.Size = new System.Drawing.Size(209, 23);
            ButtonNewWorld.TabIndex = 2;
            ButtonNewWorld.Text = "World...";
            ButtonNewWorld.UseVisualStyleBackColor = true;
            ButtonNewWorld.Click += new System.EventHandler(ParentForm.NewWorld_Click);

            /**
             * ButtonNewPlayer
             */
            ButtonNewPlayer.Location = new System.Drawing.Point(8, 244);
            ButtonNewPlayer.Name = "ButtonNewPlayer";
            ButtonNewPlayer.Size = new System.Drawing.Size(209, 23);
            ButtonNewPlayer.TabIndex = 3;
            ButtonNewPlayer.Text = "Player...";
            ButtonNewPlayer.UseVisualStyleBackColor = true;
            ButtonNewPlayer.Click += new System.EventHandler(ParentForm.NewPlayer_Click);

            /**
             * ButtonNewGUIOMETRY
             */
            ButtonNewGUIOMETRY.Location = new System.Drawing.Point(8, 273);
            ButtonNewGUIOMETRY.Name = "ButtonNewGUIOMETRY";
            ButtonNewGUIOMETRY.Size = new System.Drawing.Size(209, 23);
            ButtonNewGUIOMETRY.TabIndex = 4;
            ButtonNewGUIOMETRY.Text = "GUIOMETRY.BIN...";
            ButtonNewGUIOMETRY.UseVisualStyleBackColor = true;
            ButtonNewGUIOMETRY.Click += new System.EventHandler(ParentForm.NewGUIOMETRY_Click);

            /**
             * LabelOpenTasks
             */
            LabelOpenTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            LabelOpenTasks.AutoSize = true;
            LabelOpenTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelOpenTasks.Location = new System.Drawing.Point(588, 196);
            LabelOpenTasks.Name = "LabelOpenTasks";
            LabelOpenTasks.Size = new System.Drawing.Size(106, 16);
            LabelOpenTasks.TabIndex = 9;
            LabelOpenTasks.Text = "Open Previous...";

            /**
             * ButtonOpenWorld
             */
            ButtonOpenWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonOpenWorld.Location = new System.Drawing.Point(591, 215);
            ButtonOpenWorld.Name = "ButtonOpenWorld";
            ButtonOpenWorld.Size = new System.Drawing.Size(209, 23);
            ButtonOpenWorld.TabIndex = 6;
            ButtonOpenWorld.Text = "World...";
            ButtonOpenWorld.UseVisualStyleBackColor = true;

            /**
             * ButtonOpenPlayer
             */
            ButtonOpenPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonOpenPlayer.Location = new System.Drawing.Point(591, 244);
            ButtonOpenPlayer.Name = "ButtonOpenPlayer";
            ButtonOpenPlayer.Size = new System.Drawing.Size(209, 23);
            ButtonOpenPlayer.TabIndex = 7;
            ButtonOpenPlayer.Text = "Player...";
            ButtonOpenPlayer.UseVisualStyleBackColor = true;

            /**
             * ButtonOpenGUIOMETRY
             */
            ButtonOpenGUIOMETRY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonOpenGUIOMETRY.Location = new System.Drawing.Point(591, 273);
            ButtonOpenGUIOMETRY.Name = "ButtonOpenGUIOMETRY";
            ButtonOpenGUIOMETRY.Size = new System.Drawing.Size(209, 23);
            ButtonOpenGUIOMETRY.TabIndex = 8;
            ButtonOpenGUIOMETRY.Text = "GUIOMETRY.BIN...";
            ButtonOpenGUIOMETRY.UseVisualStyleBackColor = true;

            #endregion
        }
    }
}
