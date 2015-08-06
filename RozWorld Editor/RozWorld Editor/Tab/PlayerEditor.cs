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

            this.Controls.Add(this.LabelTabTitle);

            this.Controls.Add(this.GroupGeneralDetails);
            this.Controls.Add(this.GroupStatDetails);
            this.Controls.Add(this.GroupInventory);
            this.Controls.Add(this.GroupPet);


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
            this.LabelTabTitle.AutoSize = true;
            this.LabelTabTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTabTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelTabTitle.Location = new System.Drawing.Point(8, 3);
            this.LabelTabTitle.Name = "LabelTabTitle";
            this.LabelTabTitle.Size = new System.Drawing.Size(137, 24);
            this.LabelTabTitle.TabIndex = 4;
            this.LabelTabTitle.Text = "Player Editor";


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
                "Tom"
            });
            this.ComboAvatar.Location = new System.Drawing.Point(100, 71);
            this.ComboAvatar.Name = "ComboAvatar";
            this.ComboAvatar.SelectedIndex = 0;
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
            this.GroupStatDetails.Controls.Add(this.LabelChunkY);
            this.GroupStatDetails.Controls.Add(this.NumericChunkY);
            this.GroupStatDetails.Controls.Add(this.LabelPositionX);
            this.GroupStatDetails.Controls.Add(this.TextPositionX);
            this.GroupStatDetails.Controls.Add(this.LabelPositionY);
            this.GroupStatDetails.Controls.Add(this.TextPositionY);
            this.GroupStatDetails.Location = new System.Drawing.Point(12, 177);
            this.GroupStatDetails.Name = "GroupStatDetails";
            this.GroupStatDetails.Size = new System.Drawing.Size(219, 220);
            this.GroupStatDetails.TabIndex = 3;
            this.GroupStatDetails.TabStop = false;
            this.GroupStatDetails.Text = "Stat Details";

            /**
             * LabelPlayerHealth
             */
            this.LabelPlayerHealth.AutoSize = true;
            this.LabelPlayerHealth.Location = new System.Drawing.Point(6, 16);
            this.LabelPlayerHealth.Name = "LabelPlayerHealth";
            this.LabelPlayerHealth.Size = new System.Drawing.Size(41, 13);
            this.LabelPlayerHealth.TabIndex = 0;
            this.LabelPlayerHealth.Text = "Health:";

            /**
             * NumericPlayerHealth
             */
            this.NumericPlayerHealth.Location = new System.Drawing.Point(9, 32);
            this.NumericPlayerHealth.Maximum = 100;
            this.NumericPlayerHealth.Name = "NumericPlayerHealth";
            this.NumericPlayerHealth.Size = new System.Drawing.Size(97, 20);
            this.NumericPlayerHealth.TabIndex = 1;
            this.NumericPlayerHealth.Value = 100;

            /**
             * LabelPlayerMaxHealth
             */
            this.LabelPlayerMaxHealth.AutoSize = true;
            this.LabelPlayerMaxHealth.Location = new System.Drawing.Point(109, 16);
            this.LabelPlayerMaxHealth.Name = "LabelPlayerMaxHealth";
            this.LabelPlayerMaxHealth.Size = new System.Drawing.Size(64, 13);
            this.LabelPlayerMaxHealth.TabIndex = 2;
            this.LabelPlayerMaxHealth.Text = "Max Health:";

            /**
             * NumericPlayerMaxHealth
             */
            this.NumericPlayerMaxHealth.Location = new System.Drawing.Point(112, 32);
            this.NumericPlayerMaxHealth.Maximum = 100;
            this.NumericPlayerMaxHealth.Name = "NumericPlayerMaxHealth";
            this.NumericPlayerMaxHealth.Size = new System.Drawing.Size(101, 20);
            this.NumericPlayerMaxHealth.TabIndex = 3;
            this.NumericPlayerMaxHealth.Value = 100;

            /**
             * LabelPlayerEXP
             */
            this.LabelPlayerEXP.AutoSize = true;
            this.LabelPlayerEXP.Location = new System.Drawing.Point(6, 55);
            this.LabelPlayerEXP.Name = "LabelPlayerEXP";
            this.LabelPlayerEXP.Size = new System.Drawing.Size(31, 13);
            this.LabelPlayerEXP.TabIndex = 4;
            this.LabelPlayerEXP.Text = "EXP:";

            /**
             * NumericPlayerEXP
             */
            this.NumericPlayerEXP.Location = new System.Drawing.Point(9, 71);
            this.NumericPlayerEXP.Maximum = 1000; // Change this when the exp curve is known
            this.NumericPlayerEXP.Name = "NumericPlayerEXP";
            this.NumericPlayerEXP.Size = new System.Drawing.Size(97, 20);
            this.NumericPlayerEXP.TabIndex = 5;
            this.NumericPlayerEXP.Value = 0;

            /**
             * LabelPlayerReqEXP
             */
            this.LabelPlayerReqEXP.AutoSize = true;
            this.LabelPlayerReqEXP.Location = new System.Drawing.Point(109, 55);
            this.LabelPlayerReqEXP.Name = "LabelPlayerReqEXP";
            this.LabelPlayerReqEXP.Size = new System.Drawing.Size(77, 13);
            this.LabelPlayerReqEXP.TabIndex = 6;
            this.LabelPlayerReqEXP.Text = "Required EXP:";

            /**
             * NumericPlayerReqEXP
             */
            this.NumericPlayerReqEXP.Location = new System.Drawing.Point(112, 71);
            this.NumericPlayerReqEXP.Maximum = int.MaxValue;
            this.NumericPlayerReqEXP.Name = "NumericPlayerReqEXP";
            this.NumericPlayerReqEXP.Size = new System.Drawing.Size(101, 20);
            this.NumericPlayerReqEXP.TabIndex = 7;
            this.NumericPlayerReqEXP.Value = 1000;

            /**
             * LabelPlayerLevel
             */
            this.LabelPlayerLevel.AutoSize = true;
            this.LabelPlayerLevel.Location = new System.Drawing.Point(6, 94);
            this.LabelPlayerLevel.Name = "LabelPlayerLevel";
            this.LabelPlayerLevel.Size = new System.Drawing.Size(36, 13);
            this.LabelPlayerLevel.TabIndex = 8;
            this.LabelPlayerLevel.Text = "Level:";

            /**
             * NumericPlayerLevel
             */
            this.NumericPlayerLevel.Location = new System.Drawing.Point(9, 110);
            this.NumericPlayerLevel.Maximum = 1000;
            this.NumericPlayerLevel.Name = "NumericPlayerLevel";
            this.NumericPlayerLevel.Size = new System.Drawing.Size(97, 20);
            this.NumericPlayerLevel.TabIndex = 9;
            this.NumericPlayerLevel.Value = 1;

            /**
             * LabelSpeed
             */
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(109, 94);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(41, 13);
            this.LabelSpeed.TabIndex = 10;
            this.LabelSpeed.Text = "Speed:";

            /**
             * TextSpeed
             */
            this.TextSpeed.Location = new System.Drawing.Point(112, 110);
            this.TextSpeed.Name = "TextSpeed";
            this.TextSpeed.Size = new System.Drawing.Size(101, 20);
            this.TextSpeed.TabIndex = 11;

            /**
             * LabelChunkX
             */
            this.LabelChunkX.AutoSize = true;
            this.LabelChunkX.Location = new System.Drawing.Point(6, 133);
            this.LabelChunkX.Name = "LabelChunkX";
            this.LabelChunkX.Size = new System.Drawing.Size(51, 13);
            this.LabelChunkX.TabIndex = 12;
            this.LabelChunkX.Text = "Chunk X:";

            /**
             * NumericChunkX
             */
            this.NumericChunkX.Location = new System.Drawing.Point(9, 149);
            this.NumericChunkX.Maximum = int.MaxValue;
            this.NumericChunkX.Name = "NumericChunkX";
            this.NumericChunkX.Size = new System.Drawing.Size(67, 20);
            this.NumericChunkX.TabIndex = 13;
            this.NumericChunkX.Value = 0;

            /**
             * LabelChunkY
             */
            this.LabelChunkY.AutoSize = true;
            this.LabelChunkY.Location = new System.Drawing.Point(80, 133);
            this.LabelChunkY.Name = "LabelChunkY";
            this.LabelChunkY.Size = new System.Drawing.Size(51, 13);
            this.LabelChunkY.TabIndex = 14;
            this.LabelChunkY.Text = "Chunk Y:";

            /**
             * NumericChunkY
             */
            this.NumericChunkY.Location = new System.Drawing.Point(83, 149);
            this.NumericChunkY.Maximum = int.MaxValue;
            this.NumericChunkY.Name = "NumericChunkY";
            this.NumericChunkY.Size = new System.Drawing.Size(67, 20);
            this.NumericChunkY.TabIndex = 15;
            this.NumericChunkY.Value = 0;

            /**
             * LabelPositionX
             */
            this.LabelPositionX.AutoSize = true;
            this.LabelPositionX.Location = new System.Drawing.Point(6, 172);
            this.LabelPositionX.Name = "LabelPositionX";
            this.LabelPositionX.Size = new System.Drawing.Size(57, 13);
            this.LabelPositionX.TabIndex = 16;
            this.LabelPositionX.Text = "Position X:";

            /**
             * TextPositionX
             */
            this.TextPositionX.Location = new System.Drawing.Point(9, 188);
            this.TextPositionX.Name = "TextPositionX";
            this.TextPositionX.Size = new System.Drawing.Size(68, 20);
            this.TextPositionX.TabIndex = 20;

            /**
             * LabelPositionY
             */
            this.LabelPositionY.AutoSize = true;
            this.LabelPositionY.Location = new System.Drawing.Point(80, 172);
            this.LabelPositionY.Name = "LabelPositionY";
            this.LabelPositionY.Size = new System.Drawing.Size(57, 13);
            this.LabelPositionY.TabIndex = 18;
            this.LabelPositionY.Text = "Position Y:";

            /**
             * TextPositionY
             */
            this.TextPositionY.Location = new System.Drawing.Point(83, 188);
            this.TextPositionY.Name = "TextPositionY";
            this.TextPositionY.Size = new System.Drawing.Size(68, 20);
            this.TextPositionY.TabIndex = 21;


            /**
             * GroupInventory
             */
            this.GroupInventory.Controls.Add(this.ListInventory);
            this.GroupInventory.Controls.Add(this.ButtonAdd);
            this.GroupInventory.Controls.Add(this.ButtonEdit);
            this.GroupInventory.Controls.Add(this.ButtonRemove);
            this.GroupInventory.Controls.Add(this.ButtonClone);
            this.GroupInventory.Location = new System.Drawing.Point(237, 6);
            this.GroupInventory.Name = "GroupInventory";
            this.GroupInventory.Size = new System.Drawing.Size(355, 488);
            this.GroupInventory.TabIndex = 4;
            this.GroupInventory.TabStop = false;
            this.GroupInventory.Text = "Inventory";

            /**
             * ListInventory
             */
            this.ListInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.ColumnID,
                this.ColumnItem,
                this.ColumnGivenName,
                this.ColumnUpgrades,
                this.ColumnQuantity
            });
            this.ListInventory.Location = new System.Drawing.Point(6, 19);
            this.ListInventory.Name = "ListInventory";
            this.ListInventory.Size = new System.Drawing.Size(343, 434);
            this.ListInventory.TabIndex = 0;
            this.ListInventory.UseCompatibleStateImageBehavior = false;
            this.ListInventory.View = System.Windows.Forms.View.Details;

            /**
             * ColumnID
             */
            this.ColumnID.Text = "ID";
            this.ColumnID.Width = 25;

            /**
             * ColumnItem
             */
            this.ColumnItem.Text = "Item";
            this.ColumnItem.Width = 73;

            /**
             * ColumnGivenName
             */
            this.ColumnGivenName.Text = "Given Name";
            this.ColumnGivenName.Width = 86;

            /**
             * ColumnUpgrades
             */
            this.ColumnUpgrades.Text = "Upgrades";
            this.ColumnUpgrades.Width = 93;

            /**
             * ColumnQuantity
             */
            this.ColumnQuantity.Text = "Quantity";

            /**
             * ButtonAdd
             */
            this.ButtonAdd.Location = new System.Drawing.Point(6, 459);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add...";
            this.ButtonAdd.UseVisualStyleBackColor = true;

            /**
             * ButtonEdit
             */
            this.ButtonEdit.Location = new System.Drawing.Point(87, 459);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit...";
            this.ButtonEdit.UseVisualStyleBackColor = true;

            /**
             * ButtonRemove
             */
            this.ButtonRemove.Location = new System.Drawing.Point(168, 459);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 3;
            this.ButtonRemove.Text = "Remove...";
            this.ButtonRemove.UseVisualStyleBackColor = true;

            /**
             * ButtonClone
             */
            this.ButtonClone.Location = new System.Drawing.Point(249, 459);
            this.ButtonClone.Name = "ButtonClone";
            this.ButtonClone.Size = new System.Drawing.Size(75, 23);
            this.ButtonClone.TabIndex = 4;
            this.ButtonClone.Text = "Clone Slot...";
            this.ButtonClone.UseVisualStyleBackColor = true;


            /**
             * GroupPet
             */
            this.GroupPet.Controls.Add(this.LabelPetType);
            this.GroupPet.Controls.Add(this.ComboPetType);
            this.GroupPet.Controls.Add(this.PicturePetType);
            this.GroupPet.Controls.Add(this.LabelPetName);
            this.GroupPet.Controls.Add(this.TextPetName);
            this.GroupPet.Controls.Add(this.LabelPetHealth);
            this.GroupPet.Controls.Add(this.NumericPetHealth);
            this.GroupPet.Controls.Add(this.LabelPetMaxHealth);
            this.GroupPet.Controls.Add(this.NumericPetMaxHealth);
            this.GroupPet.Controls.Add(this.LabelPetEXP);
            this.GroupPet.Controls.Add(this.NumericPetEXP);
            this.GroupPet.Controls.Add(this.LabelPetReqEXP);
            this.GroupPet.Controls.Add(this.NumericPetReqEXP);
            this.GroupPet.Controls.Add(this.LabelPetLevel);
            this.GroupPet.Controls.Add(this.NumericPetLevel);
            this.GroupPet.Controls.Add(this.LabelPetPosition);
            this.GroupPet.Controls.Add(this.ComboPetPosition);
            this.GroupPet.Location = new System.Drawing.Point(598, 6);
            this.GroupPet.Name = "GroupPet";
            this.GroupPet.Size = new System.Drawing.Size(200, 223);
            this.GroupPet.TabIndex = 5;
            this.GroupPet.TabStop = false;
            this.GroupPet.Text = "Pet Details";

            /**
             * LabelPetType
             */
            this.LabelPetType.AutoSize = true;
            this.LabelPetType.Location = new System.Drawing.Point(3, 16);
            this.LabelPetType.Name = "LabelPetType";
            this.LabelPetType.Size = new System.Drawing.Size(53, 13);
            this.LabelPetType.TabIndex = 10;
            this.LabelPetType.Text = "Pet Type:";

            /**
             * ComboPetType
             */
            this.ComboPetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPetType.FormattingEnabled = true;
            this.ComboPetType.Items.AddRange(new object[] {
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
            this.ComboPetType.Location = new System.Drawing.Point(6, 32);
            this.ComboPetType.Name = "ComboPetType";
            this.ComboPetType.SelectedIndex = 0;
            this.ComboPetType.Size = new System.Drawing.Size(150, 21);
            this.ComboPetType.TabIndex = 10;

            /**
             * PicturePetType
             */
            this.PicturePetType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicturePetType.Location = new System.Drawing.Point(162, 19);
            this.PicturePetType.Name = "PicturePetType";
            this.PicturePetType.Size = new System.Drawing.Size(32, 32);
            this.PicturePetType.TabIndex = 10;
            this.PicturePetType.TabStop = false;

            /**
             * LabelPetName
             */
            this.LabelPetName.AutoSize = true;
            this.LabelPetName.Location = new System.Drawing.Point(3, 56);
            this.LabelPetName.Name = "LabelPetName";
            this.LabelPetName.Size = new System.Drawing.Size(57, 13);
            this.LabelPetName.TabIndex = 11;
            this.LabelPetName.Text = "Pet Name:";

            /**
             * TextPetName
             */
            this.TextPetName.Location = new System.Drawing.Point(6, 72);
            this.TextPetName.Name = "TextPetName";
            this.TextPetName.Size = new System.Drawing.Size(188, 20);
            this.TextPetName.TabIndex = 12;

            /**
             * LabelPetHealth
             */
            this.LabelPetHealth.AutoSize = true;
            this.LabelPetHealth.Location = new System.Drawing.Point(3, 95);
            this.LabelPetHealth.Name = "LabelPetHealth";
            this.LabelPetHealth.Size = new System.Drawing.Size(41, 13);
            this.LabelPetHealth.TabIndex = 13;
            this.LabelPetHealth.Text = "Health:";

            /**
             * NumericPetHealth
             */
            this.NumericPetHealth.Location = new System.Drawing.Point(6, 111);
            this.NumericPetHealth.Maximum = 100;
            this.NumericPetHealth.Name = "NumericPetHealth";
            this.NumericPetHealth.Size = new System.Drawing.Size(87, 20);
            this.NumericPetHealth.TabIndex = 14;
            this.NumericPetHealth.Value = 100;

            /**
             * LabelPetMaxHealth
             */
            this.LabelPetMaxHealth.AutoSize = true;
            this.LabelPetMaxHealth.Location = new System.Drawing.Point(96, 95);
            this.LabelPetMaxHealth.Name = "LabelPetMaxHealth";
            this.LabelPetMaxHealth.Size = new System.Drawing.Size(64, 13);
            this.LabelPetMaxHealth.TabIndex = 15;
            this.LabelPetMaxHealth.Text = "Max Health:";

            /**
             * NumericPetMaxHealth
             */
            this.NumericPetMaxHealth.Location = new System.Drawing.Point(99, 111);
            this.NumericPetMaxHealth.Maximum = 100;
            this.NumericPetMaxHealth.Name = "NumericPetMaxHealth";
            this.NumericPetMaxHealth.Size = new System.Drawing.Size(95, 20);
            this.NumericPetMaxHealth.TabIndex = 16;
            this.NumericPetMaxHealth.Value = 100;

            /**
             * LabelPetEXP
             */
            this.LabelPetEXP.AutoSize = true;
            this.LabelPetEXP.Location = new System.Drawing.Point(3, 134);
            this.LabelPetEXP.Name = "LabelPetEXP";
            this.LabelPetEXP.Size = new System.Drawing.Size(31, 13);
            this.LabelPetEXP.TabIndex = 17;
            this.LabelPetEXP.Text = "EXP:";

            /**
             * NumericPetEXP
             */
            this.NumericPetEXP.Location = new System.Drawing.Point(6, 150);
            this.NumericPetEXP.Maximum = 250; // Change this when the exp curve is known
            this.NumericPetEXP.Name = "NumericPetEXP";
            this.NumericPetEXP.Size = new System.Drawing.Size(87, 20);
            this.NumericPetEXP.TabIndex = 18;
            this.NumericPetEXP.Value = 0;

            /**
             * LabelPetReqEXP
             */
            this.LabelPetReqEXP.AutoSize = true;
            this.LabelPetReqEXP.Location = new System.Drawing.Point(96, 134);
            this.LabelPetReqEXP.Name = "LabelPetReqEXP";
            this.LabelPetReqEXP.Size = new System.Drawing.Size(77, 13);
            this.LabelPetReqEXP.TabIndex = 19;
            this.LabelPetReqEXP.Text = "Required EXP:";

            /**
             * NumericPetReqEXP
             */
            this.NumericPetReqEXP.Location = new System.Drawing.Point(99, 150);
            this.NumericPetReqEXP.Maximum = int.MaxValue;
            this.NumericPetReqEXP.Name = "NumericPetReqEXP";
            this.NumericPetReqEXP.Size = new System.Drawing.Size(95, 20);
            this.NumericPetReqEXP.TabIndex = 20;
            this.NumericPetReqEXP.Value = 250;

            /**
             * LabelPetLevel
             */
            this.LabelPetLevel.AutoSize = true;
            this.LabelPetLevel.Location = new System.Drawing.Point(3, 173);
            this.LabelPetLevel.Name = "LabelPetLevel";
            this.LabelPetLevel.Size = new System.Drawing.Size(36, 13);
            this.LabelPetLevel.TabIndex = 21;
            this.LabelPetLevel.Text = "Level:";

            /**
             * NumericPetLevel
             */
            this.NumericPetLevel.Location = new System.Drawing.Point(6, 189);
            this.NumericPetLevel.Maximum = 1000;
            this.NumericPetLevel.Name = "NumericPetLevel";
            this.NumericPetLevel.Size = new System.Drawing.Size(87, 20);
            this.NumericPetLevel.TabIndex = 22;
            this.NumericPetLevel.Value = 1;

            /**
             * LabelPetPosition
             */
            this.LabelPetPosition.AutoSize = true;
            this.LabelPetPosition.Location = new System.Drawing.Point(96, 173);
            this.LabelPetPosition.Name = "LabelPetPosition";
            this.LabelPetPosition.Size = new System.Drawing.Size(89, 13);
            this.LabelPetPosition.TabIndex = 23;
            this.LabelPetPosition.Text = "Relative Position:";

            /**
             * ComboPetPosition
             */
            this.ComboPetPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPetPosition.FormattingEnabled = true;
            this.ComboPetPosition.Items.AddRange(new object[] {
                "Centre",
                "Up",
                "Right",
                "Down",
                "Left"
            });
            this.ComboPetPosition.Location = new System.Drawing.Point(99, 189);
            this.ComboPetPosition.Name = "ComboPetPosition";
            this.ComboPetPosition.SelectedIndex = 0;
            this.ComboPetPosition.Size = new System.Drawing.Size(95, 21);
            this.ComboPetPosition.TabIndex = 24;

            #endregion

            if (file == "")
            {
                this.Text = "Player - *";
                this.IsUnsaved = true;
            }
            else
            {
                this.Text = "Player - " + Path.GetFileName(file);
            }
        }
    }
}
