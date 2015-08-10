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

using System.IO;
using System.Windows.Forms;

namespace RozWorld_Editor.Tab
{
    public class PlayerEditor : EditorTab
    {
        #region Windows Forms Controls

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
        private ColumnHeader ColumnID = new ColumnHeader();
        private ColumnHeader ColumnItem = new ColumnHeader();
        private ColumnHeader ColumnGivenName = new ColumnHeader();
        private ColumnHeader ColumnUpgrades = new ColumnHeader();
        private ColumnHeader ColumnQuantity = new ColumnHeader();
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

        #endregion


        public PlayerEditor(TabControl parentTabUI, int uniqueID, string file = "")
        {
            #region Windows Forms Initialisation

            this.ParentTabUI = parentTabUI;
            this.ParentForm = (MainForm)parentTabUI.Parent;

            this.Controls.Add(LabelTabTitle);

            this.Controls.Add(GroupGeneralDetails);
            this.Controls.Add(GroupStatDetails);
            this.Controls.Add(GroupInventory);
            this.Controls.Add(GroupPet);


            /**
             * PlayerEditor
             */
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "PlayerEditor" + uniqueID.ToString();
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(808, 504);
            this.TabIndex = 2;
            this.Text = "";
            this.UseVisualStyleBackColor = true;

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
            LabelTabTitle.Text = "Player Editor";


            /**
             * GroupGeneralDetails
             */
            GroupGeneralDetails.Controls.Add(LabelPlayerName);
            GroupGeneralDetails.Controls.Add(TextPlayerName);
            GroupGeneralDetails.Controls.Add(LabelPlayerID);
            GroupGeneralDetails.Controls.Add(NumericPlayerID);
            GroupGeneralDetails.Controls.Add(LabelPlayerSubID);
            GroupGeneralDetails.Controls.Add(NumericPlayerSubID);
            GroupGeneralDetails.Controls.Add(LabelAvatar);
            GroupGeneralDetails.Controls.Add(ComboAvatar);
            GroupGeneralDetails.Controls.Add(PictureAvatar);
            GroupGeneralDetails.Controls.Add(LabelGroup);
            GroupGeneralDetails.Controls.Add(TextGroup);
            GroupGeneralDetails.Location = new System.Drawing.Point(12, 30);
            GroupGeneralDetails.Name = "GroupGeneralDetails";
            GroupGeneralDetails.Size = new System.Drawing.Size(219, 141);
            GroupGeneralDetails.TabIndex = 2;
            GroupGeneralDetails.TabStop = false;
            GroupGeneralDetails.Text = "General Details";

            /**
             * LabelPlayerName
             */
            LabelPlayerName.AutoSize = true;
            LabelPlayerName.Location = new System.Drawing.Point(6, 16);
            LabelPlayerName.Name = "LabelPlayerName";
            LabelPlayerName.Size = new System.Drawing.Size(70, 13);
            LabelPlayerName.TabIndex = 0;
            LabelPlayerName.Text = "Player Name:";

            /**
             * TextPlayerName
             */
            TextPlayerName.Location = new System.Drawing.Point(9, 32);
            TextPlayerName.Name = "TextPlayerName";
            TextPlayerName.Size = new System.Drawing.Size(166, 20);
            TextPlayerName.TabIndex = 1;

            /**
             * LabelPlayerID
             */
            LabelPlayerID.AutoSize = true;
            LabelPlayerID.Location = new System.Drawing.Point(6, 55);
            LabelPlayerID.Name = "LabelPlayerID";
            LabelPlayerID.Size = new System.Drawing.Size(21, 13);
            LabelPlayerID.TabIndex = 2;
            LabelPlayerID.Text = "ID:";

            /**
             * NumericPlayerID
             */
            NumericPlayerID.Location = new System.Drawing.Point(9, 71);
            NumericPlayerID.Maximum = 255;
            NumericPlayerID.Name = "NumericPlayerID";
            NumericPlayerID.Size = new System.Drawing.Size(38, 20);
            NumericPlayerID.TabIndex = 3;
            NumericPlayerID.Value = 0;

            /**
             * LabelPlayerSubID
             */
            LabelPlayerSubID.AutoSize = true;
            LabelPlayerSubID.Location = new System.Drawing.Point(50, 55);
            LabelPlayerSubID.Name = "LabelPlayerSubID";
            LabelPlayerSubID.Size = new System.Drawing.Size(40, 13);
            LabelPlayerSubID.TabIndex = 4;
            LabelPlayerSubID.Text = "SubID:";

            /**
             * NumericPlayerSubID
             */
            NumericPlayerSubID.Location = new System.Drawing.Point(53, 71);
            NumericPlayerSubID.Maximum = 255;
            NumericPlayerSubID.Name = "NumericPlayerSubID";
            NumericPlayerSubID.Size = new System.Drawing.Size(38, 20);
            NumericPlayerSubID.TabIndex = 5;
            NumericPlayerSubID.Value = 0;

            /**
             * LabelAvatar
             */
            LabelAvatar.AutoSize = true;
            LabelAvatar.Location = new System.Drawing.Point(97, 55);
            LabelAvatar.Name = "LabelAvatar";
            LabelAvatar.Size = new System.Drawing.Size(41, 13);
            LabelAvatar.TabIndex = 6;
            LabelAvatar.Text = "Avatar:";

            /**
             * ComboAvatar
             */
            ComboAvatar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboAvatar.FormattingEnabled = true;
            ComboAvatar.Items.AddRange(new object[] {
                "Terry",
                "[Female Default Variant]",
                "Watson",
                "King",
                "Tom"
            });
            ComboAvatar.Location = new System.Drawing.Point(100, 71);
            ComboAvatar.Name = "ComboAvatar";
            ComboAvatar.SelectedIndex = 0;
            ComboAvatar.Size = new System.Drawing.Size(113, 21);
            ComboAvatar.TabIndex = 7;

            /**
             * PictureAvatar
             */
            PictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PictureAvatar.Location = new System.Drawing.Point(181, 20);
            PictureAvatar.Name = "PictureAvatar";
            PictureAvatar.Size = new System.Drawing.Size(32, 32);
            PictureAvatar.TabIndex = 1;
            PictureAvatar.TabStop = false;

            /**
             * LabelGroup
             */
            LabelGroup.AutoSize = true;
            LabelGroup.Location = new System.Drawing.Point(6, 94);
            LabelGroup.Name = "LabelGroup";
            LabelGroup.Size = new System.Drawing.Size(39, 13);
            LabelGroup.TabIndex = 8;
            LabelGroup.Text = "Group:";

            /**
             * TextGroup
             */
            TextGroup.Location = new System.Drawing.Point(9, 110);
            TextGroup.Name = "TextGroup";
            TextGroup.Size = new System.Drawing.Size(204, 20);
            TextGroup.TabIndex = 9;


            /**
             * GroupStatDetails
             */
            GroupStatDetails.Controls.Add(LabelPlayerHealth);
            GroupStatDetails.Controls.Add(NumericPlayerHealth);
            GroupStatDetails.Controls.Add(LabelPlayerMaxHealth);
            GroupStatDetails.Controls.Add(NumericPlayerMaxHealth);
            GroupStatDetails.Controls.Add(LabelPlayerEXP);
            GroupStatDetails.Controls.Add(NumericPlayerEXP);
            GroupStatDetails.Controls.Add(LabelPlayerReqEXP);
            GroupStatDetails.Controls.Add(NumericPlayerReqEXP);
            GroupStatDetails.Controls.Add(LabelPlayerLevel);
            GroupStatDetails.Controls.Add(NumericPlayerLevel);
            GroupStatDetails.Controls.Add(LabelSpeed);
            GroupStatDetails.Controls.Add(TextSpeed);
            GroupStatDetails.Controls.Add(LabelChunkX);
            GroupStatDetails.Controls.Add(NumericChunkX);
            GroupStatDetails.Controls.Add(LabelChunkY);
            GroupStatDetails.Controls.Add(NumericChunkY);
            GroupStatDetails.Controls.Add(LabelPositionX);
            GroupStatDetails.Controls.Add(TextPositionX);
            GroupStatDetails.Controls.Add(LabelPositionY);
            GroupStatDetails.Controls.Add(TextPositionY);
            GroupStatDetails.Location = new System.Drawing.Point(12, 177);
            GroupStatDetails.Name = "GroupStatDetails";
            GroupStatDetails.Size = new System.Drawing.Size(219, 220);
            GroupStatDetails.TabIndex = 3;
            GroupStatDetails.TabStop = false;
            GroupStatDetails.Text = "Stat Details";

            /**
             * LabelPlayerHealth
             */
            LabelPlayerHealth.AutoSize = true;
            LabelPlayerHealth.Location = new System.Drawing.Point(6, 16);
            LabelPlayerHealth.Name = "LabelPlayerHealth";
            LabelPlayerHealth.Size = new System.Drawing.Size(41, 13);
            LabelPlayerHealth.TabIndex = 0;
            LabelPlayerHealth.Text = "Health:";

            /**
             * NumericPlayerHealth
             */
            NumericPlayerHealth.Location = new System.Drawing.Point(9, 32);
            NumericPlayerHealth.Maximum = 100;
            NumericPlayerHealth.Name = "NumericPlayerHealth";
            NumericPlayerHealth.Size = new System.Drawing.Size(97, 20);
            NumericPlayerHealth.TabIndex = 1;
            NumericPlayerHealth.Value = 100;

            /**
             * LabelPlayerMaxHealth
             */
            LabelPlayerMaxHealth.AutoSize = true;
            LabelPlayerMaxHealth.Location = new System.Drawing.Point(109, 16);
            LabelPlayerMaxHealth.Name = "LabelPlayerMaxHealth";
            LabelPlayerMaxHealth.Size = new System.Drawing.Size(64, 13);
            LabelPlayerMaxHealth.TabIndex = 2;
            LabelPlayerMaxHealth.Text = "Max Health:";

            /**
             * NumericPlayerMaxHealth
             */
            NumericPlayerMaxHealth.Location = new System.Drawing.Point(112, 32);
            NumericPlayerMaxHealth.Maximum = 100;
            NumericPlayerMaxHealth.Name = "NumericPlayerMaxHealth";
            NumericPlayerMaxHealth.Size = new System.Drawing.Size(101, 20);
            NumericPlayerMaxHealth.TabIndex = 3;
            NumericPlayerMaxHealth.Value = 100;

            /**
             * LabelPlayerEXP
             */
            LabelPlayerEXP.AutoSize = true;
            LabelPlayerEXP.Location = new System.Drawing.Point(6, 55);
            LabelPlayerEXP.Name = "LabelPlayerEXP";
            LabelPlayerEXP.Size = new System.Drawing.Size(31, 13);
            LabelPlayerEXP.TabIndex = 4;
            LabelPlayerEXP.Text = "EXP:";

            /**
             * NumericPlayerEXP
             */
            NumericPlayerEXP.Location = new System.Drawing.Point(9, 71);
            NumericPlayerEXP.Maximum = 1000; // Change this when the exp curve is known
            NumericPlayerEXP.Name = "NumericPlayerEXP";
            NumericPlayerEXP.Size = new System.Drawing.Size(97, 20);
            NumericPlayerEXP.TabIndex = 5;
            NumericPlayerEXP.Value = 0;

            /**
             * LabelPlayerReqEXP
             */
            LabelPlayerReqEXP.AutoSize = true;
            LabelPlayerReqEXP.Location = new System.Drawing.Point(109, 55);
            LabelPlayerReqEXP.Name = "LabelPlayerReqEXP";
            LabelPlayerReqEXP.Size = new System.Drawing.Size(77, 13);
            LabelPlayerReqEXP.TabIndex = 6;
            LabelPlayerReqEXP.Text = "Required EXP:";

            /**
             * NumericPlayerReqEXP
             */
            NumericPlayerReqEXP.Location = new System.Drawing.Point(112, 71);
            NumericPlayerReqEXP.Maximum = int.MaxValue;
            NumericPlayerReqEXP.Name = "NumericPlayerReqEXP";
            NumericPlayerReqEXP.Size = new System.Drawing.Size(101, 20);
            NumericPlayerReqEXP.TabIndex = 7;
            NumericPlayerReqEXP.Value = 1000;

            /**
             * LabelPlayerLevel
             */
            LabelPlayerLevel.AutoSize = true;
            LabelPlayerLevel.Location = new System.Drawing.Point(6, 94);
            LabelPlayerLevel.Name = "LabelPlayerLevel";
            LabelPlayerLevel.Size = new System.Drawing.Size(36, 13);
            LabelPlayerLevel.TabIndex = 8;
            LabelPlayerLevel.Text = "Level:";

            /**
             * NumericPlayerLevel
             */
            NumericPlayerLevel.Location = new System.Drawing.Point(9, 110);
            NumericPlayerLevel.Maximum = 1000;
            NumericPlayerLevel.Name = "NumericPlayerLevel";
            NumericPlayerLevel.Size = new System.Drawing.Size(97, 20);
            NumericPlayerLevel.TabIndex = 9;
            NumericPlayerLevel.Value = 1;

            /**
             * LabelSpeed
             */
            LabelSpeed.AutoSize = true;
            LabelSpeed.Location = new System.Drawing.Point(109, 94);
            LabelSpeed.Name = "LabelSpeed";
            LabelSpeed.Size = new System.Drawing.Size(41, 13);
            LabelSpeed.TabIndex = 10;
            LabelSpeed.Text = "Speed:";

            /**
             * TextSpeed
             */
            TextSpeed.Location = new System.Drawing.Point(112, 110);
            TextSpeed.Name = "TextSpeed";
            TextSpeed.Size = new System.Drawing.Size(101, 20);
            TextSpeed.TabIndex = 11;

            /**
             * LabelChunkX
             */
            LabelChunkX.AutoSize = true;
            LabelChunkX.Location = new System.Drawing.Point(6, 133);
            LabelChunkX.Name = "LabelChunkX";
            LabelChunkX.Size = new System.Drawing.Size(51, 13);
            LabelChunkX.TabIndex = 12;
            LabelChunkX.Text = "Chunk X:";

            /**
             * NumericChunkX
             */
            NumericChunkX.Location = new System.Drawing.Point(9, 149);
            NumericChunkX.Maximum = int.MaxValue;
            NumericChunkX.Name = "NumericChunkX";
            NumericChunkX.Size = new System.Drawing.Size(67, 20);
            NumericChunkX.TabIndex = 13;
            NumericChunkX.Value = 0;

            /**
             * LabelChunkY
             */
            LabelChunkY.AutoSize = true;
            LabelChunkY.Location = new System.Drawing.Point(80, 133);
            LabelChunkY.Name = "LabelChunkY";
            LabelChunkY.Size = new System.Drawing.Size(51, 13);
            LabelChunkY.TabIndex = 14;
            LabelChunkY.Text = "Chunk Y:";

            /**
             * NumericChunkY
             */
            NumericChunkY.Location = new System.Drawing.Point(83, 149);
            NumericChunkY.Maximum = int.MaxValue;
            NumericChunkY.Name = "NumericChunkY";
            NumericChunkY.Size = new System.Drawing.Size(67, 20);
            NumericChunkY.TabIndex = 15;
            NumericChunkY.Value = 0;

            /**
             * LabelPositionX
             */
            LabelPositionX.AutoSize = true;
            LabelPositionX.Location = new System.Drawing.Point(6, 172);
            LabelPositionX.Name = "LabelPositionX";
            LabelPositionX.Size = new System.Drawing.Size(57, 13);
            LabelPositionX.TabIndex = 16;
            LabelPositionX.Text = "Position X:";

            /**
             * TextPositionX
             */
            TextPositionX.Location = new System.Drawing.Point(9, 188);
            TextPositionX.Name = "TextPositionX";
            TextPositionX.Size = new System.Drawing.Size(68, 20);
            TextPositionX.TabIndex = 20;

            /**
             * LabelPositionY
             */
            LabelPositionY.AutoSize = true;
            LabelPositionY.Location = new System.Drawing.Point(80, 172);
            LabelPositionY.Name = "LabelPositionY";
            LabelPositionY.Size = new System.Drawing.Size(57, 13);
            LabelPositionY.TabIndex = 18;
            LabelPositionY.Text = "Position Y:";

            /**
             * TextPositionY
             */
            TextPositionY.Location = new System.Drawing.Point(83, 188);
            TextPositionY.Name = "TextPositionY";
            TextPositionY.Size = new System.Drawing.Size(68, 20);
            TextPositionY.TabIndex = 21;


            /**
             * GroupInventory
             */
            GroupInventory.Controls.Add(ListInventory);
            GroupInventory.Controls.Add(ButtonAdd);
            GroupInventory.Controls.Add(ButtonEdit);
            GroupInventory.Controls.Add(ButtonRemove);
            GroupInventory.Controls.Add(ButtonClone);
            GroupInventory.Location = new System.Drawing.Point(237, 6);
            GroupInventory.Name = "GroupInventory";
            GroupInventory.Size = new System.Drawing.Size(355, 488);
            GroupInventory.TabIndex = 4;
            GroupInventory.TabStop = false;
            GroupInventory.Text = "Inventory";

            /**
             * ListInventory
             */
            ListInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                ColumnID,
                ColumnItem,
                ColumnGivenName,
                ColumnUpgrades,
                ColumnQuantity
            });
            ListInventory.Location = new System.Drawing.Point(6, 19);
            ListInventory.Name = "ListInventory";
            ListInventory.Size = new System.Drawing.Size(343, 434);
            ListInventory.TabIndex = 0;
            ListInventory.UseCompatibleStateImageBehavior = false;
            ListInventory.View = System.Windows.Forms.View.Details;

            /**
             * ColumnID
             */
            ColumnID.Text = "ID";
            ColumnID.Width = 25;

            /**
             * ColumnItem
             */
            ColumnItem.Text = "Item";
            ColumnItem.Width = 73;

            /**
             * ColumnGivenName
             */
            ColumnGivenName.Text = "Given Name";
            ColumnGivenName.Width = 86;

            /**
             * ColumnUpgrades
             */
            ColumnUpgrades.Text = "Upgrades";
            ColumnUpgrades.Width = 93;

            /**
             * ColumnQuantity
             */
            ColumnQuantity.Text = "Quantity";

            /**
             * ButtonAdd
             */
            ButtonAdd.Location = new System.Drawing.Point(6, 459);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new System.Drawing.Size(75, 23);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Add...";
            ButtonAdd.UseVisualStyleBackColor = true;

            /**
             * ButtonEdit
             */
            ButtonEdit.Location = new System.Drawing.Point(87, 459);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(75, 23);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Edit...";
            ButtonEdit.UseVisualStyleBackColor = true;

            /**
             * ButtonRemove
             */
            ButtonRemove.Location = new System.Drawing.Point(168, 459);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new System.Drawing.Size(75, 23);
            ButtonRemove.TabIndex = 3;
            ButtonRemove.Text = "Remove...";
            ButtonRemove.UseVisualStyleBackColor = true;

            /**
             * ButtonClone
             */
            ButtonClone.Location = new System.Drawing.Point(249, 459);
            ButtonClone.Name = "ButtonClone";
            ButtonClone.Size = new System.Drawing.Size(75, 23);
            ButtonClone.TabIndex = 4;
            ButtonClone.Text = "Clone Slot...";
            ButtonClone.UseVisualStyleBackColor = true;


            /**
             * GroupPet
             */
            GroupPet.Controls.Add(LabelPetType);
            GroupPet.Controls.Add(ComboPetType);
            GroupPet.Controls.Add(PicturePetType);
            GroupPet.Controls.Add(LabelPetName);
            GroupPet.Controls.Add(TextPetName);
            GroupPet.Controls.Add(LabelPetHealth);
            GroupPet.Controls.Add(NumericPetHealth);
            GroupPet.Controls.Add(LabelPetMaxHealth);
            GroupPet.Controls.Add(NumericPetMaxHealth);
            GroupPet.Controls.Add(LabelPetEXP);
            GroupPet.Controls.Add(NumericPetEXP);
            GroupPet.Controls.Add(LabelPetReqEXP);
            GroupPet.Controls.Add(NumericPetReqEXP);
            GroupPet.Controls.Add(LabelPetLevel);
            GroupPet.Controls.Add(NumericPetLevel);
            GroupPet.Controls.Add(LabelPetPosition);
            GroupPet.Controls.Add(ComboPetPosition);
            GroupPet.Location = new System.Drawing.Point(598, 6);
            GroupPet.Name = "GroupPet";
            GroupPet.Size = new System.Drawing.Size(200, 223);
            GroupPet.TabIndex = 5;
            GroupPet.TabStop = false;
            GroupPet.Text = "Pet Details";

            /**
             * LabelPetType
             */
            LabelPetType.AutoSize = true;
            LabelPetType.Location = new System.Drawing.Point(3, 16);
            LabelPetType.Name = "LabelPetType";
            LabelPetType.Size = new System.Drawing.Size(53, 13);
            LabelPetType.TabIndex = 10;
            LabelPetType.Text = "Pet Type:";

            /**
             * ComboPetType
             */
            ComboPetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboPetType.FormattingEnabled = true;
            ComboPetType.Items.AddRange(new object[] {
                "None",
                "Dalmation",
                "Generic Black Cat",
                "Tiger (Generic Ginger Cat)",
                "Actual Tiger",
                "Tonka Truck",
                "Chimp",
                "Chimp with a Hat",
                "A Massive Gorilla",
                "Elephant",
                "Computer with Wheels",
                "Night Fury",
                "Deadly Nadder",
                "BT Van"
            });
            ComboPetType.Location = new System.Drawing.Point(6, 32);
            ComboPetType.Name = "ComboPetType";
            ComboPetType.SelectedIndex = 0;
            ComboPetType.Size = new System.Drawing.Size(150, 21);
            ComboPetType.TabIndex = 10;

            /**
             * PicturePetType
             */
            PicturePetType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PicturePetType.Location = new System.Drawing.Point(162, 19);
            PicturePetType.Name = "PicturePetType";
            PicturePetType.Size = new System.Drawing.Size(32, 32);
            PicturePetType.TabIndex = 10;
            PicturePetType.TabStop = false;

            /**
             * LabelPetName
             */
            LabelPetName.AutoSize = true;
            LabelPetName.Location = new System.Drawing.Point(3, 56);
            LabelPetName.Name = "LabelPetName";
            LabelPetName.Size = new System.Drawing.Size(57, 13);
            LabelPetName.TabIndex = 11;
            LabelPetName.Text = "Pet Name:";

            /**
             * TextPetName
             */
            TextPetName.Location = new System.Drawing.Point(6, 72);
            TextPetName.Name = "TextPetName";
            TextPetName.Size = new System.Drawing.Size(188, 20);
            TextPetName.TabIndex = 12;

            /**
             * LabelPetHealth
             */
            LabelPetHealth.AutoSize = true;
            LabelPetHealth.Location = new System.Drawing.Point(3, 95);
            LabelPetHealth.Name = "LabelPetHealth";
            LabelPetHealth.Size = new System.Drawing.Size(41, 13);
            LabelPetHealth.TabIndex = 13;
            LabelPetHealth.Text = "Health:";

            /**
             * NumericPetHealth
             */
            NumericPetHealth.Location = new System.Drawing.Point(6, 111);
            NumericPetHealth.Maximum = 100;
            NumericPetHealth.Name = "NumericPetHealth";
            NumericPetHealth.Size = new System.Drawing.Size(87, 20);
            NumericPetHealth.TabIndex = 14;
            NumericPetHealth.Value = 100;

            /**
             * LabelPetMaxHealth
             */
            LabelPetMaxHealth.AutoSize = true;
            LabelPetMaxHealth.Location = new System.Drawing.Point(96, 95);
            LabelPetMaxHealth.Name = "LabelPetMaxHealth";
            LabelPetMaxHealth.Size = new System.Drawing.Size(64, 13);
            LabelPetMaxHealth.TabIndex = 15;
            LabelPetMaxHealth.Text = "Max Health:";

            /**
             * NumericPetMaxHealth
             */
            NumericPetMaxHealth.Location = new System.Drawing.Point(99, 111);
            NumericPetMaxHealth.Maximum = 100;
            NumericPetMaxHealth.Name = "NumericPetMaxHealth";
            NumericPetMaxHealth.Size = new System.Drawing.Size(95, 20);
            NumericPetMaxHealth.TabIndex = 16;
            NumericPetMaxHealth.Value = 100;

            /**
             * LabelPetEXP
             */
            LabelPetEXP.AutoSize = true;
            LabelPetEXP.Location = new System.Drawing.Point(3, 134);
            LabelPetEXP.Name = "LabelPetEXP";
            LabelPetEXP.Size = new System.Drawing.Size(31, 13);
            LabelPetEXP.TabIndex = 17;
            LabelPetEXP.Text = "EXP:";

            /**
             * NumericPetEXP
             */
            NumericPetEXP.Location = new System.Drawing.Point(6, 150);
            NumericPetEXP.Maximum = 250; // Change this when the exp curve is known
            NumericPetEXP.Name = "NumericPetEXP";
            NumericPetEXP.Size = new System.Drawing.Size(87, 20);
            NumericPetEXP.TabIndex = 18;
            NumericPetEXP.Value = 0;

            /**
             * LabelPetReqEXP
             */
            LabelPetReqEXP.AutoSize = true;
            LabelPetReqEXP.Location = new System.Drawing.Point(96, 134);
            LabelPetReqEXP.Name = "LabelPetReqEXP";
            LabelPetReqEXP.Size = new System.Drawing.Size(77, 13);
            LabelPetReqEXP.TabIndex = 19;
            LabelPetReqEXP.Text = "Required EXP:";

            /**
             * NumericPetReqEXP
             */
            NumericPetReqEXP.Location = new System.Drawing.Point(99, 150);
            NumericPetReqEXP.Maximum = int.MaxValue;
            NumericPetReqEXP.Name = "NumericPetReqEXP";
            NumericPetReqEXP.Size = new System.Drawing.Size(95, 20);
            NumericPetReqEXP.TabIndex = 20;
            NumericPetReqEXP.Value = 250;

            /**
             * LabelPetLevel
             */
            LabelPetLevel.AutoSize = true;
            LabelPetLevel.Location = new System.Drawing.Point(3, 173);
            LabelPetLevel.Name = "LabelPetLevel";
            LabelPetLevel.Size = new System.Drawing.Size(36, 13);
            LabelPetLevel.TabIndex = 21;
            LabelPetLevel.Text = "Level:";

            /**
             * NumericPetLevel
             */
            NumericPetLevel.Location = new System.Drawing.Point(6, 189);
            NumericPetLevel.Maximum = 1000;
            NumericPetLevel.Name = "NumericPetLevel";
            NumericPetLevel.Size = new System.Drawing.Size(87, 20);
            NumericPetLevel.TabIndex = 22;
            NumericPetLevel.Value = 1;

            /**
             * LabelPetPosition
             */
            LabelPetPosition.AutoSize = true;
            LabelPetPosition.Location = new System.Drawing.Point(96, 173);
            LabelPetPosition.Name = "LabelPetPosition";
            LabelPetPosition.Size = new System.Drawing.Size(89, 13);
            LabelPetPosition.TabIndex = 23;
            LabelPetPosition.Text = "Relative Position:";

            /**
             * ComboPetPosition
             */
            ComboPetPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboPetPosition.FormattingEnabled = true;
            ComboPetPosition.Items.AddRange(new object[] {
                "Centre",
                "Up",
                "Right",
                "Down",
                "Left"
            });
            ComboPetPosition.Location = new System.Drawing.Point(99, 189);
            ComboPetPosition.Name = "ComboPetPosition";
            ComboPetPosition.SelectedIndex = 0;
            ComboPetPosition.Size = new System.Drawing.Size(95, 21);
            ComboPetPosition.TabIndex = 24;

            #endregion

            if (file == "")
            {
                Text = "Player - *";
                IsUnsaved = true;
            }
            else
            {
                Text = "Player - " + Path.GetFileName(file);
            }
        }
    }
}
