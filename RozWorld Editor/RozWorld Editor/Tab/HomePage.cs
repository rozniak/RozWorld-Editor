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
    public class HomePage : TabPage
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


        public HomePage()
        {
            #region Windows Forms Initialisation

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
            this.PictureEditorLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureEditorLogo.Image = global::RozWorld_Editor.Properties.Resources.EditorLogo;
            this.PictureEditorLogo.Location = new System.Drawing.Point(8, 6);
            this.PictureEditorLogo.Name = "PictureEditorLogo";
            this.PictureEditorLogo.Size = new System.Drawing.Size(792, 187);
            this.PictureEditorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureEditorLogo.TabIndex = 0;
            this.PictureEditorLogo.TabStop = false;

            /**
             * LabelNewTasks
             */
            this.LabelNewTasks.AutoSize = true;
            this.LabelNewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewTasks.Location = new System.Drawing.Point(8, 196);
            this.LabelNewTasks.Name = "LabelNewTasks";
            this.LabelNewTasks.Size = new System.Drawing.Size(87, 16);
            this.LabelNewTasks.TabIndex = 1;
            this.LabelNewTasks.Text = "Create New...";

            /**
             * ButtonNewWorld
             */
            this.ButtonNewWorld.Location = new System.Drawing.Point(8, 215);
            this.ButtonNewWorld.Name = "ButtonNewWorld";
            this.ButtonNewWorld.Size = new System.Drawing.Size(209, 23);
            this.ButtonNewWorld.TabIndex = 2;
            this.ButtonNewWorld.Text = "World...";
            this.ButtonNewWorld.UseVisualStyleBackColor = true;

            /**
             * ButtonNewPlayer
             */
            this.ButtonNewPlayer.Location = new System.Drawing.Point(8, 244);
            this.ButtonNewPlayer.Name = "ButtonNewPlayer";
            this.ButtonNewPlayer.Size = new System.Drawing.Size(209, 23);
            this.ButtonNewPlayer.TabIndex = 3;
            this.ButtonNewPlayer.Text = "Player...";
            this.ButtonNewPlayer.UseVisualStyleBackColor = true;

            /**
             * ButtonNewGUIOMETRY
             */
            this.ButtonNewGUIOMETRY.Location = new System.Drawing.Point(8, 273);
            this.ButtonNewGUIOMETRY.Name = "ButtonNewGUIOMETRY";
            this.ButtonNewGUIOMETRY.Size = new System.Drawing.Size(209, 23);
            this.ButtonNewGUIOMETRY.TabIndex = 4;
            this.ButtonNewGUIOMETRY.Text = "GUIOMETRY.BIN...";
            this.ButtonNewGUIOMETRY.UseVisualStyleBackColor = true;

            /**
             * LabelOpenTasks
             */
            this.LabelOpenTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOpenTasks.AutoSize = true;
            this.LabelOpenTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpenTasks.Location = new System.Drawing.Point(588, 196);
            this.LabelOpenTasks.Name = "LabelOpenTasks";
            this.LabelOpenTasks.Size = new System.Drawing.Size(106, 16);
            this.LabelOpenTasks.TabIndex = 9;
            this.LabelOpenTasks.Text = "Open Previous...";

            /**
             * ButtonOpenWorld
             */
            this.ButtonOpenWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenWorld.Location = new System.Drawing.Point(591, 215);
            this.ButtonOpenWorld.Name = "ButtonOpenWorld";
            this.ButtonOpenWorld.Size = new System.Drawing.Size(209, 23);
            this.ButtonOpenWorld.TabIndex = 6;
            this.ButtonOpenWorld.Text = "World...";
            this.ButtonOpenWorld.UseVisualStyleBackColor = true;

            /**
             * ButtonOpenPlayer
             */
            this.ButtonOpenPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenPlayer.Location = new System.Drawing.Point(591, 244);
            this.ButtonOpenPlayer.Name = "ButtonOpenPlayer";
            this.ButtonOpenPlayer.Size = new System.Drawing.Size(209, 23);
            this.ButtonOpenPlayer.TabIndex = 7;
            this.ButtonOpenPlayer.Text = "Player...";
            this.ButtonOpenPlayer.UseVisualStyleBackColor = true;

            /**
             * ButtonOpenGUIOMETRY
             */
            this.ButtonOpenGUIOMETRY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenGUIOMETRY.Location = new System.Drawing.Point(591, 273);
            this.ButtonOpenGUIOMETRY.Name = "ButtonOpenGUIOMETRY";
            this.ButtonOpenGUIOMETRY.Size = new System.Drawing.Size(209, 23);
            this.ButtonOpenGUIOMETRY.TabIndex = 8;
            this.ButtonOpenGUIOMETRY.Text = "GUIOMETRY.BIN...";
            this.ButtonOpenGUIOMETRY.UseVisualStyleBackColor = true;

            #endregion
        }
    }
}
