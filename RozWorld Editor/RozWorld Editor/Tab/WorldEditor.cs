/**
 * RozWorld_Editor.Tab.WorldEditor -- World Editor Tab
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
    public class WorldEditor : TabPage
    {
        #region Windows Forms Controls

        private Label LabelTabTitle = new Label();
        private Label LabelNavigation = new Label();
        private Label LabelChunkCoordinates = new Label();

        private Button ButtonUp = new Button();
        private Button ButtonRight = new Button();
        private Button ButtonDown = new Button();
        private Button ButtonLeft = new Button();

        private Panel PanelProperties = new Panel();
        private PictureBox PictureThingIcon = new PictureBox();
        private Label LabelThingType = new Label();
        private Label LabelThingName = new Label();

        private Panel PanelWorldView = new Panel();
        private PictureBox PictureObjectOverlay = new PictureBox();

        #endregion


        public WorldEditor()
        {
            #region Windows Forms Initialisation

            this.Controls.Add(this.LabelTabTitle);
            this.Controls.Add(this.LabelNavigation);
            this.Controls.Add(this.LabelChunkCoordinates);

            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonLeft);

            this.Controls.Add(this.PanelProperties);
            this.Controls.Add(this.PanelWorldView);

            /**
             * WorldEditor
             */
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "WorldEditor"; // This line is temporary
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(808, 504);
            this.TabIndex = 1;
            this.Text = "World - ";
            this.UseVisualStyleBackColor = true;

            /**
             * LabelTabTitle
             */
            this.LabelTabTitle.AutoSize = true;
            this.LabelTabTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTabTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelTabTitle.Location = new System.Drawing.Point(8, 3);
            this.LabelTabTitle.Name = "LabelTabTitle";
            this.LabelTabTitle.Size = new System.Drawing.Size(137, 24);
            this.LabelTabTitle.TabIndex = 4;
            this.LabelTabTitle.Text = "World Editor";

            /**
             * LabelNavigation
             */
            this.LabelNavigation.AutoSize = true;
            this.LabelNavigation.Location = new System.Drawing.Point(9, 34);
            this.LabelNavigation.Name = "LabelNavigation";
            this.LabelNavigation.Size = new System.Drawing.Size(61, 13);
            this.LabelNavigation.TabIndex = 9;
            this.LabelNavigation.Text = "Navigation:";

            /**
             * LabelChunkCoordinates
             */
            this.LabelChunkCoordinates.AutoSize = true;
            this.LabelChunkCoordinates.Location = new System.Drawing.Point(76, 34);
            this.LabelChunkCoordinates.Name = "LabelChunkCoordinates";
            this.LabelChunkCoordinates.Size = new System.Drawing.Size(61, 13);
            this.LabelChunkCoordinates.TabIndex = 11;
            this.LabelChunkCoordinates.Text = "X0 , Y0, Z0";

            /**
             * ButtonUp
             */
            this.ButtonUp.Image = global::RozWorld_Editor.Properties.Resources.UpArrowIcon;
            this.ButtonUp.Location = new System.Drawing.Point(65, 50);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(24, 24);
            this.ButtonUp.TabIndex = 5;
            this.ButtonUp.UseVisualStyleBackColor = true;

            /**
             * ButtonRight
             */
            this.ButtonRight.Image = global::RozWorld_Editor.Properties.Resources.RightArrowIcon;
            this.ButtonRight.Location = new System.Drawing.Point(95, 62);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(24, 24);
            this.ButtonRight.TabIndex = 8;
            this.ButtonRight.UseVisualStyleBackColor = true;

            /**
             * ButtonDown
             */
            this.ButtonDown.Image = global::RozWorld_Editor.Properties.Resources.DownArrowIcon;
            this.ButtonDown.Location = new System.Drawing.Point(65, 80);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(24, 24);
            this.ButtonDown.TabIndex = 6;
            this.ButtonDown.UseVisualStyleBackColor = true;

            /**
             * ButtonLeft
             */
            this.ButtonLeft.Image = global::RozWorld_Editor.Properties.Resources.LeftArrowIcon;
            this.ButtonLeft.Location = new System.Drawing.Point(35, 62);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(24, 24);
            this.ButtonLeft.TabIndex = 7;
            this.ButtonLeft.UseVisualStyleBackColor = true;

            /**
             * PanelProperties
             */
            this.PanelProperties.BackColor = System.Drawing.Color.Transparent;
            this.PanelProperties.Controls.Add(this.PictureThingIcon);
            this.PanelProperties.Controls.Add(this.LabelThingType);
            this.PanelProperties.Controls.Add(this.LabelThingName);
            this.PanelProperties.Location = new System.Drawing.Point(1, 110);
            this.PanelProperties.Name = "PanelProperties";
            this.PanelProperties.Size = new System.Drawing.Size(152, 388);
            this.PanelProperties.TabIndex = 10;
            
            /**
             * PictureThingIcon
             */
            this.PictureThingIcon.Image = global::RozWorld_Editor.Properties.Resources.ThingUnknown;
            this.PictureThingIcon.Location = new System.Drawing.Point(3, 3);
            this.PictureThingIcon.Name = "PictureThingIcon";
            this.PictureThingIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureThingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureThingIcon.TabIndex = 1;
            this.PictureThingIcon.TabStop = false;

            /**
             * LabelThingType
             */
            this.LabelThingType.AutoSize = true;
            this.LabelThingType.Location = new System.Drawing.Point(41, 3);
            this.LabelThingType.Name = "LabelThingType";
            this.LabelThingType.Size = new System.Drawing.Size(82, 13);
            this.LabelThingType.TabIndex = 2;
            this.LabelThingType.Text = "Unknown Entity";

            /**
             * LabelThingName
             */
            this.LabelThingName.AutoSize = true;
            this.LabelThingName.Enabled = false;
            this.LabelThingName.Location = new System.Drawing.Point(41, 22);
            this.LabelThingName.Name = "LabelThingName";
            this.LabelThingName.Size = new System.Drawing.Size(27, 13);
            this.LabelThingName.TabIndex = 3;
            this.LabelThingName.Text = "N/A";

            /**
             * PanelWorldView
             */
            this.PanelWorldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelWorldView.AutoScroll = true;
            this.PanelWorldView.AutoScrollMinSize = new System.Drawing.Size(640, 480);
            this.PanelWorldView.BackColor = System.Drawing.Color.Black;
            this.PanelWorldView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelWorldView.Controls.Add(this.PictureObjectOverlay);
            this.PanelWorldView.Location = new System.Drawing.Point(156, 3);
            this.PanelWorldView.Name = "PanelWorldView";
            this.PanelWorldView.Size = new System.Drawing.Size(646, 495);
            this.PanelWorldView.TabIndex = 0;

            #endregion
        }
    }
}
