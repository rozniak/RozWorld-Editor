/**
 * RozWorld_Editor.Tab.PlayerEditor -- Player Editor Tab
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
    public class PlayerEditor : TabPage
    {
        private Label LabelTabTitle = new Label();

        private GroupBox GroupGeneralDetails = new GroupBox();
        private Label LabelPlayerName = new Label();
        private TextBox TextPlayerName = new TextBox();
        private Label LabelPlayerID = new Label();
        private NumericUpDown NumericPlayerID = new NumericUpDown();
        private Label LabelPlayerSubID = new Label();
        private NumericUpDown NumericPlayerSubID = new NumericUpDown();
        private Label LabelAvatar = new Label();
        private ComboBox ComboAvatar = new ComboBox();
        private PictureBox PictureAvatar = new PictureBox();
        private Label LabelGroup = new Label();
        private TextBox TextGroup = new TextBox();

        private GroupBox GroupStatDetails = new GroupBox();
        private Label LabelPlayerHealth = new Label();
        private NumericUpDown NumericPlayerHealth = new NumericUpDown();
        private Label LabelPlayerMaxHealth = new Label();
        private NumericUpDown NumericPlayerMaxHealth = new NumericUpDown();
        private Label LabelPlayerEXP = new Label();
        private NumericUpDown NumericPlayerEXP = new NumericUpDown();
        private Label LabelPlayerReqEXP = new Label();
        private NumericUpDown NumericPlayerReqEXP = new NumericUpDown();
        private Label LabelPlayerLevel = new Label();
        private NumericUpDown NumericPlayerLevel = new NumericUpDown();
        private Label LabelSpeed = new Label();
        private TextBox TextSpeed = new TextBox();
        private Label LabelChunkX = new Label();
        private NumericUpDown NumericChunkX = new NumericUpDown();
        private Label LabelChunkY = new Label();
        private NumericUpDown NumericChunkY = new NumericUpDown();
        private Label LabelPositionX = new Label();
        private TextBox TextPositionX = new TextBox();
        private Label LabelPositionY = new Label();
        private TextBox TextPositionY = new TextBox();

        private GroupBox GroupInventory = new GroupBox();
        private ListView ListInventory = new ListView();
        private Button ButtonAdd = new Button();
        private Button ButtonEdit = new Button();
        private Button ButtonRemove = new Button();
        private Button ButtonClone = new Button();

        private GroupBox GroupPet = new GroupBox();
        private Label LabelPetType = new Label();
        private ComboBox ComboPetType = new ComboBox();
        private PictureBox PicturePetType = new PictureBox();
        private Label LabelPetName = new Label();
        private TextBox TextPetName = new TextBox();
        private Label LabelPetHealth = new Label();
        private NumericUpDown NumericPetHealth = new NumericUpDown();
        private Label LabelPetMaxHealth = new Label();
        private NumericUpDown NumericPetMaxHealth = new NumericUpDown();
        private Label LabelPetEXP = new Label();
        private NumericUpDown NumericPetEXP = new NumericUpDown();
        private Label LabelPetReqEXP = new Label();
        private NumericUpDown NumericPetReqEXP = new NumericUpDown();
        private Label LabelPetLevel = new Label();
        private NumericUpDown NumericPetLevel = new NumericUpDown();
        private Label LabelPetPosition = new Label();
        private ComboBox ComboPetPosition = new ComboBox();

        public PlayerEditor()
        {
            this.Controls.Add(this.LabelTabTitle);

            this.Controls.Add(this.GroupGeneralDetails);
            this.Controls.Add(this.GroupStatDetails);
            this.Controls.Add(this.GroupInventory);
            this.Controls.Add(this.GroupPet);

            /**
             * PlayerEditor
             */
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "PlayerEditor"; // This line is temporary
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(808, 504);
            this.TabIndex = 2;
            this.Text = "Player - ";
            this.UseVisualStyleBackColor = true;

            /**
             * GroupGeneralDetails
             */
            this.GroupGeneralDetails.Controls.Add(this.LabelPlayerName);
            this.GroupGeneralDetails.Controls.Add(this.TextPlayerName);
            this.GroupGeneralDetails.Controls.Add(this.LabelPlayerID);
            this.GroupGeneralDetails.Controls.Add(this.NumericPlayerID);
            this.GroupGeneralDetails.Controls.Add(this.LabelPlayerSubID);
            this.GroupGeneralDetails.Controls.Add(this.NumericPlayerSubID);
            this.GroupGeneralDetails.Controls.Add(this.LabelAvatar);
            this.GroupGeneralDetails.Controls.Add(this.ComboAvatar);
            this.GroupGeneralDetails.Controls.Add(this.PictureAvatar);
            this.GroupGeneralDetails.Controls.Add(this.LabelGroup);
            this.GroupGeneralDetails.Controls.Add(this.TextGroup);
            this.GroupGeneralDetails.Location = new System.Drawing.Point(12, 30);
            this.GroupGeneralDetails.Name = "GroupGeneralDetails";
            this.GroupGeneralDetails.Size = new System.Drawing.Size(219, 141);
            this.GroupGeneralDetails.TabIndex = 2;
            this.GroupGeneralDetails.TabStop = false;
            this.GroupGeneralDetails.Text = "General Details";

            /**
             * LabelPlayerName
             */
            this.LabelPlayerName.AutoSize = true;
            this.LabelPlayerName.Location = new System.Drawing.Point(6, 16);
            this.LabelPlayerName.Name = "LabelPlayerName";
            this.LabelPlayerName.Size = new System.Drawing.Size(70, 13);
            this.LabelPlayerName.TabIndex = 0;
            this.LabelPlayerName.Text = "Player Name:";

            /**
             * TextPlayerName
             */
            this.TextPlayerName.Location = new System.Drawing.Point(9, 32);
            this.TextPlayerName.Name = "TextPlayerName";
            this.TextPlayerName.Size = new System.Drawing.Size(166, 20);
            this.TextPlayerName.TabIndex = 1;

            /**
             * LabelPlayerID
             */
            this.LabelPlayerID.AutoSize = true;
            this.LabelPlayerID.Location = new System.Drawing.Point(6, 55);
            this.LabelPlayerID.Name = "LabelPlayerID";
            this.LabelPlayerID.Size = new System.Drawing.Size(21, 13);
            this.LabelPlayerID.TabIndex = 2;
            this.LabelPlayerID.Text = "ID:";

            /**
             * NumericPlayerID
             */
            this.NumericPlayerID.Location = new System.Drawing.Point(9, 71);
            this.NumericPlayerID.Maximum = 255;
            this.NumericPlayerID.Name = "NumericPlayerID";
            this.NumericPlayerID.Size = new System.Drawing.Size(38, 20);
            this.NumericPlayerID.TabIndex = 3;
            this.NumericPlayerID.Value = 0;

            /**
             * LabelPlayerSubID
             */
            this.LabelPlayerSubID.AutoSize = true;
            this.LabelPlayerSubID.Location = new System.Drawing.Point(50, 55);
            this.LabelPlayerSubID.Name = "LabelPlayerSubID";
            this.LabelPlayerSubID.Size = new System.Drawing.Size(40, 13);
            this.LabelPlayerSubID.TabIndex = 4;
            this.LabelPlayerSubID.Text = "SubID:";

            /**
             * NumericPlayerSubID
             */
            this.NumericPlayerSubID.Location = new System.Drawing.Point(53, 71);
            this.NumericPlayerSubID.Maximum = 255;
            this.NumericPlayerSubID.Name = "NumericPlayerSubID";
            this.NumericPlayerSubID.Size = new System.Drawing.Size(38, 20);
            this.NumericPlayerSubID.TabIndex = 5;
            this.NumericPlayerSubID.Value = 0;

            /**
             * LabelAvatar
             */
            this.LabelAvatar.AutoSize = true;
            this.LabelAvatar.Location = new System.Drawing.Point(97, 55);
            this.LabelAvatar.Name = "LabelAvatar";
            this.LabelAvatar.Size = new System.Drawing.Size(41, 13);
            this.LabelAvatar.TabIndex = 6;
            this.LabelAvatar.Text = "Avatar:";

            /**
             * ComboAvatar
             */
            this.ComboAvatar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAvatar.FormattingEnabled = true;
            this.ComboAvatar.Items.AddRange(new object[] {
            "Terry",
            "[Female Default Variant]",
            "Watson",
            "King",
            "Tom"});
            this.ComboAvatar.Location = new System.Drawing.Point(100, 71);
            this.ComboAvatar.Name = "ComboAvatar";
            this.ComboAvatar.Size = new System.Drawing.Size(113, 21);
            this.ComboAvatar.TabIndex = 7;

            /**
             * PictureAvatar
             */
            this.PictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureAvatar.Location = new System.Drawing.Point(181, 20);
            this.PictureAvatar.Name = "PictureAvatar";
            this.PictureAvatar.Size = new System.Drawing.Size(32, 32);
            this.PictureAvatar.TabIndex = 1;
            this.PictureAvatar.TabStop = false;

            /**
             * LabelGroup
             */
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Location = new System.Drawing.Point(6, 94);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(39, 13);
            this.LabelGroup.TabIndex = 8;
            this.LabelGroup.Text = "Group:";

            /**
             * TextGroup
             */
            this.TextGroup.Location = new System.Drawing.Point(9, 110);
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(204, 20);
            this.TextGroup.TabIndex = 9;

            /**
             * GroupStatDetails
             */
            this.GroupStatDetails.Controls.Add(this.LabelPlayerHealth);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerHealth);
            this.GroupStatDetails.Controls.Add(this.LabelPlayerMaxHealth);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerMaxHealth);
            this.GroupStatDetails.Controls.Add(this.LabelPlayerEXP);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerEXP);
            this.GroupStatDetails.Controls.Add(this.LabelPlayerReqEXP);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerReqEXP);
            this.GroupStatDetails.Controls.Add(this.LabelPlayerLevel);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerLevel);
            this.GroupStatDetails.Controls.Add(this.LabelSpeed);
            this.GroupStatDetails.Controls.Add(this.TextSpeed);
            this.GroupStatDetails.Controls.Add(this.LabelChunkX);
            this.GroupStatDetails.Controls.Add(this.NumericChunkX);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerReqEXP);
            this.GroupStatDetails.Controls.Add(this.NumericPlayerReqEXP); // Finish adding controls
            this.GroupStatDetails.Location = new System.Drawing.Point(12, 177);
            this.GroupStatDetails.Name = "GroupStatDetails";
            this.GroupStatDetails.Size = new System.Drawing.Size(219, 220);
            this.GroupStatDetails.TabIndex = 3;
            this.GroupStatDetails.TabStop = false;
            this.GroupStatDetails.Text = "Stat Details";
        }
    }
}
