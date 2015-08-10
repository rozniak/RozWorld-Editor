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

using System.IO;
using System.Windows.Forms;

namespace RozWorld_Editor.Tab
{
    public class WorldEditor : EditorTab
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


        public WorldEditor(TabControl parentTabUI, int uniqueID, string file = "")
        {
            #region Windows Forms Initialisation

            ParentTabUI = parentTabUI;
            ParentForm = (MainForm)parentTabUI.Parent;

            Controls.Add(LabelTabTitle);
            Controls.Add(LabelNavigation);
            Controls.Add(LabelChunkCoordinates);

            Controls.Add(ButtonUp);
            Controls.Add(ButtonRight);
            Controls.Add(ButtonDown);
            Controls.Add(ButtonLeft);

            Controls.Add(PanelProperties);
            Controls.Add(PanelWorldView);

            /**
             * WorldEditor
             */
            Location = new System.Drawing.Point(4, 22);
            Name = "WorldEditor" + uniqueID.ToString();
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(808, 504);
            TabIndex = 1;
            Text = "";
            UseVisualStyleBackColor = true;

            /**
             * LabelTabTitle
             */
            LabelTabTitle.AutoSize = true;
            LabelTabTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTabTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            LabelTabTitle.Location = new System.Drawing.Point(8, 3);
            LabelTabTitle.Name = "LabelTabTitle";
            LabelTabTitle.Size = new System.Drawing.Size(137, 24);
            LabelTabTitle.TabIndex = 4;
            LabelTabTitle.Text = "World Editor";

            /**
             * LabelNavigation
             */
            LabelNavigation.AutoSize = true;
            LabelNavigation.Location = new System.Drawing.Point(9, 34);
            LabelNavigation.Name = "LabelNavigation";
            LabelNavigation.Size = new System.Drawing.Size(61, 13);
            LabelNavigation.TabIndex = 9;
            LabelNavigation.Text = "Navigation:";

            /**
             * LabelChunkCoordinates
             */
            LabelChunkCoordinates.AutoSize = true;
            LabelChunkCoordinates.Location = new System.Drawing.Point(76, 34);
            LabelChunkCoordinates.Name = "LabelChunkCoordinates";
            LabelChunkCoordinates.Size = new System.Drawing.Size(61, 13);
            LabelChunkCoordinates.TabIndex = 11;
            LabelChunkCoordinates.Text = "X0 , Y0, Z0";

            /**
             * ButtonUp
             */
            ButtonUp.Image = global::RozWorld_Editor.Properties.Resources.UpArrowIcon;
            ButtonUp.Location = new System.Drawing.Point(65, 50);
            ButtonUp.Name = "ButtonUp";
            ButtonUp.Size = new System.Drawing.Size(24, 24);
            ButtonUp.TabIndex = 5;
            ButtonUp.UseVisualStyleBackColor = true;

            /**
             * ButtonRight
             */
            ButtonRight.Image = global::RozWorld_Editor.Properties.Resources.RightArrowIcon;
            ButtonRight.Location = new System.Drawing.Point(95, 62);
            ButtonRight.Name = "ButtonRight";
            ButtonRight.Size = new System.Drawing.Size(24, 24);
            ButtonRight.TabIndex = 8;
            ButtonRight.UseVisualStyleBackColor = true;

            /**
             * ButtonDown
             */
            ButtonDown.Image = global::RozWorld_Editor.Properties.Resources.DownArrowIcon;
            ButtonDown.Location = new System.Drawing.Point(65, 80);
            ButtonDown.Name = "ButtonDown";
            ButtonDown.Size = new System.Drawing.Size(24, 24);
            ButtonDown.TabIndex = 6;
            ButtonDown.UseVisualStyleBackColor = true;

            /**
             * ButtonLeft
             */
            ButtonLeft.Image = global::RozWorld_Editor.Properties.Resources.LeftArrowIcon;
            ButtonLeft.Location = new System.Drawing.Point(35, 62);
            ButtonLeft.Name = "ButtonLeft";
            ButtonLeft.Size = new System.Drawing.Size(24, 24);
            ButtonLeft.TabIndex = 7;
            ButtonLeft.UseVisualStyleBackColor = true;

            /**
             * PanelProperties
             */
            PanelProperties.BackColor = System.Drawing.Color.Transparent;
            PanelProperties.Controls.Add(PictureThingIcon);
            PanelProperties.Controls.Add(LabelThingType);
            PanelProperties.Controls.Add(LabelThingName);
            PanelProperties.Location = new System.Drawing.Point(1, 110);
            PanelProperties.Name = "PanelProperties";
            PanelProperties.Size = new System.Drawing.Size(152, 388);
            PanelProperties.TabIndex = 10;
            
            /**
             * PictureThingIcon
             */
            PictureThingIcon.Image = global::RozWorld_Editor.Properties.Resources.ThingUnknown;
            PictureThingIcon.Location = new System.Drawing.Point(3, 3);
            PictureThingIcon.Name = "PictureThingIcon";
            PictureThingIcon.Size = new System.Drawing.Size(32, 32);
            PictureThingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            PictureThingIcon.TabIndex = 1;
            PictureThingIcon.TabStop = false;

            /**
             * LabelThingType
             */
            LabelThingType.AutoSize = true;
            LabelThingType.Location = new System.Drawing.Point(41, 3);
            LabelThingType.Name = "LabelThingType";
            LabelThingType.Size = new System.Drawing.Size(82, 13);
            LabelThingType.TabIndex = 2;
            LabelThingType.Text = "Unknown Entity";

            /**
             * LabelThingName
             */
            LabelThingName.AutoSize = true;
            LabelThingName.Enabled = false;
            LabelThingName.Location = new System.Drawing.Point(41, 22);
            LabelThingName.Name = "LabelThingName";
            LabelThingName.Size = new System.Drawing.Size(27, 13);
            LabelThingName.TabIndex = 3;
            LabelThingName.Text = "N/A";

            /**
             * PanelWorldView
             */
            PanelWorldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            PanelWorldView.AutoScroll = true;
            PanelWorldView.AutoScrollMinSize = new System.Drawing.Size(640, 480);
            PanelWorldView.BackColor = System.Drawing.Color.Black;
            PanelWorldView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            PanelWorldView.Controls.Add(PictureObjectOverlay);
            PanelWorldView.Location = new System.Drawing.Point(156, 3);
            PanelWorldView.Name = "PanelWorldView";
            PanelWorldView.Size = new System.Drawing.Size(646, 495);
            PanelWorldView.TabIndex = 0;

            #endregion

            if (file == "")
            {
                Text = "World - *";
                IsUnsaved = true;
            }
            else
            {
                Text = "World - " + Path.GetFileName(file);
            }
        }
    }
}
