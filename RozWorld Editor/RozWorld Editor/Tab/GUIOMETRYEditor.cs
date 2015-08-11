/**
 * RozWorld_Editor.Tab.GUIOMETRYEditor -- GUIOMETRY Editor Tab
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using RozWorld_Editor.DataClasses;

namespace RozWorld_Editor.Tab
{
    public class GUIOMETRYEditor : EditorTab
    {
        #region Windows Forms Controls

        private Label LabelTabTitle = new Label();

        private GroupBox GroupFontEditor = new GroupBox();
        private Label LabelFont = new Label();
        private ComboBox ComboFont = new ComboBox();
        private Label LabelCharacter = new Label();
        private ListBox ListCharacter = new ListBox();
        private Button ButtonAddCharacter = new Button();
        private Button ButtonRemoveCharacter = new Button();
        private Label LabelFontTexture = new Label();
        private Button ButtonFontTexture = new Button();
        //
        private GroupBox GroupCharacterDetails = new GroupBox();
        private Button ButtonCharacterBlit = new Button();
        private Label LabelCharPreview = new Label();
        private PictureBox PictureCharPreview = new PictureBox();
        private Label LabelCharBefore = new Label();
        private NumericUpDown NumericCharBefore = new NumericUpDown();
        private Label LabelCharAfter = new Label();
        private NumericUpDown NumericCharAfter = new NumericUpDown();
        private Label LabelCharYOffset = new Label();
        private NumericUpDown NumericCharYOffset = new NumericUpDown();
        //
        private Label LabelSpaceWidth = new Label();
        private NumericUpDown NumericSpaceWidth = new NumericUpDown();
        private Label LabelLineHeight = new Label();
        private NumericUpDown NumericLineHeight = new NumericUpDown();

        private GroupBox GroupButtonEditor = new GroupBox();
        private Label LabelButtonBody = new Label();
        private PictureBox PictureButtonBody = new PictureBox();
        private Button ButtonButtonBody = new Button();
        private Label LabelButtonTop = new Label();
        private PictureBox PictureButtonTop = new PictureBox();
        private Button ButtonButtonTop = new Button();
        private Label LabelButtonSide = new Label();
        private PictureBox PictureButtonSide = new PictureBox();
        private Button ButtonButtonSide = new Button();
        private Label LabelButtonEdgeSW = new Label();
        private PictureBox PictureButtonEdgeSW = new PictureBox();
        private Button ButtonButtonEdgeSW = new Button();
        private Label LabelButtonEdgeNE = new Label();
        private PictureBox PictureButtonEdgeNE = new PictureBox();
        private Button ButtonButtonEdgeNE = new Button();
        //
        private GroupBox GroupButtonText = new GroupBox();
        private CheckBox CheckButtonCentreText = new CheckBox();
        private Label LabelButtonTextYOffset = new Label();
        private NumericUpDown NumericButtonTextYOffset = new NumericUpDown();
        private Label LabelButtonTextXOffset = new Label();
        private NumericUpDown NumericButtonTextXOffset = new NumericUpDown();

        private GroupBox GroupTextEditor = new GroupBox();
        private Label LabelTextBody = new Label();
        private PictureBox PictureTextBody = new PictureBox();
        private Button ButtonTextBody = new Button();
        private Label LabelTextTop = new Label();
        private PictureBox PictureTextTop = new PictureBox();
        private Button ButtonTextTop = new Button();
        private Label LabelTextSide = new Label();
        private PictureBox PictureTextSide = new PictureBox();
        private Button ButtonTextSide = new Button();
        private Label LabelTextEdgeSW = new Label();
        private PictureBox PictureTextEdgeSW = new PictureBox();
        private Button ButtonTextEdgeSW = new Button();
        private Label LabelTextEdgeNE = new Label();
        private PictureBox PictureTextEdgeNE = new PictureBox();
        private Button ButtonTextEdgeNE = new Button();
        //
        private GroupBox GroupTextText = new GroupBox();
        private CheckBox CheckTextCentreText = new CheckBox();
        private Label LabelTextTextYOffset = new Label();
        private NumericUpDown NumericTextTextYOffset = new NumericUpDown();
        private Label LabelTextTextXOffset = new Label();
        private NumericUpDown NumericTextTextXOffset = new NumericUpDown();

        private GroupBox GroupCheckEditor = new GroupBox();
        private Label LabelCheckBody = new Label();
        private PictureBox PictureCheckBody = new PictureBox();
        private Button ButtonCheckBody = new Button();
        private Label LabelCheckTop = new Label();
        private PictureBox PictureCheckTop = new PictureBox();
        private Button ButtonCheckTop = new Button();
        private Label LabelCheckSide = new Label();
        private PictureBox PictureCheckSide = new PictureBox();
        private Button ButtonCheckSide = new Button();
        private Label LabelCheckEdgeSW = new Label();
        private PictureBox PictureCheckEdgeSW = new PictureBox();
        private Button ButtonCheckEdgeSW = new Button();
        private Label LabelCheckEdgeNE = new Label();
        private PictureBox PictureCheckEdgeNE = new PictureBox();
        private Button ButtonCheckEdgeNE = new Button();
        private Label LabelCheckTick = new Label();
        private PictureBox PictureCheckTick = new PictureBox();
        private Button ButtonCheckTick = new Button();

        private ToolTip TooltipGlobal = new ToolTip();

        #endregion

        #region Font Information Classes

        private FontInfo InfoChatFont = new FontInfo();
        private FontInfo InfoSmallFont = new FontInfo();
        private FontInfo InfoMediumFont = new FontInfo();
        private FontInfo InfoHugeFont = new FontInfo();

        #endregion

        /**
         * Keep track of the last picked font and character, so saving the lists can work
         */
        private string LastSelectedFont;
        private char LastSelectedCharacter;


        public GUIOMETRYEditor(TabControl parentTabUI, int uniqueID, string file = "")
        {
            #region Windows Forms Initialisation

            this.ParentTabUI = parentTabUI;
            this.ParentForm = (MainForm)parentTabUI.Parent;

            this.Controls.Add(LabelTabTitle);

            this.Controls.Add(GroupFontEditor);
            this.Controls.Add(GroupButtonEditor);
            this.Controls.Add(GroupTextEditor);
            this.Controls.Add(GroupCheckEditor);


            /**
             * GUIOMETRYEditor
             */
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "GUIOMETRYEditor" + uniqueID.ToString();
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(806, 530);
            this.TabIndex = 3;
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
            LabelTabTitle.Size = new System.Drawing.Size(243, 24);
            LabelTabTitle.TabIndex = 1;
            LabelTabTitle.Text = "GUIOMETRY.BIN Editor";


            /**
             * GroupFontEditor
             */
            GroupFontEditor.Controls.Add(NumericLineHeight);
            GroupFontEditor.Controls.Add(LabelLineHeight);
            GroupFontEditor.Controls.Add(NumericSpaceWidth);
            GroupFontEditor.Controls.Add(LabelSpaceWidth);
            GroupFontEditor.Controls.Add(LabelFontTexture);
            GroupFontEditor.Controls.Add(ButtonFontTexture);
            GroupFontEditor.Controls.Add(GroupCharacterDetails);
            GroupFontEditor.Controls.Add(ButtonRemoveCharacter);
            GroupFontEditor.Controls.Add(ButtonAddCharacter);
            GroupFontEditor.Controls.Add(ListCharacter);
            GroupFontEditor.Controls.Add(LabelCharacter);
            GroupFontEditor.Controls.Add(LabelFont);
            GroupFontEditor.Controls.Add(ComboFont);
            GroupFontEditor.Location = new System.Drawing.Point(12, 30);
            GroupFontEditor.Name = "GroupFontEditor";
            GroupFontEditor.Size = new System.Drawing.Size(356, 299);
            GroupFontEditor.TabIndex = 0;
            GroupFontEditor.TabStop = false;
            GroupFontEditor.Text = "Font Editor";

            /**
             * LabelFont
             */
            LabelFont.AutoSize = true;
            LabelFont.Location = new System.Drawing.Point(6, 22);
            LabelFont.Name = "LabelFont";
            LabelFont.Size = new System.Drawing.Size(31, 13);
            LabelFont.TabIndex = 1;
            LabelFont.Text = "Font:";

            /**
             * ComboFont
             */
            ComboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboFont.FormattingEnabled = true;
            ComboFont.Items.AddRange(new object[] {
            "Chat Font",
            "Small Font",
            "Medium Font",
            "Huge Font"});
            ComboFont.Location = new System.Drawing.Point(43, 19);
            ComboFont.Name = "ComboFont";
            ComboFont.SelectedIndex = 0;
            ComboFont.Size = new System.Drawing.Size(149, 21);
            ComboFont.TabIndex = 0;
            ComboFont.SelectedIndexChanged += new EventHandler(ComboFont_SelectedIndexChanged);

            /**
             * LabelCharacter
             */
            LabelCharacter.AutoSize = true;
            LabelCharacter.Location = new System.Drawing.Point(198, 22);
            LabelCharacter.Name = "LabelCharacter";
            LabelCharacter.Size = new System.Drawing.Size(56, 13);
            LabelCharacter.TabIndex = 4;
            LabelCharacter.Text = "Character:";

            /**
             * ListCharacter
             */
            ListCharacter.FormattingEnabled = true;
            ListCharacter.Location = new System.Drawing.Point(260, 19);
            ListCharacter.Name = "ListCharacter";
            ListCharacter.Size = new System.Drawing.Size(90, 43);
            ListCharacter.TabIndex = 5;
            ListCharacter.SelectedIndexChanged += new EventHandler(ListCharacter_SelectedIndexChanged);

            /**
             * ButtonAddCharacter
             */
            ButtonAddCharacter.Location = new System.Drawing.Point(201, 40);
            ButtonAddCharacter.Name = "ButtonAddCharacter";
            ButtonAddCharacter.Size = new System.Drawing.Size(21, 23);
            ButtonAddCharacter.TabIndex = 6;
            ButtonAddCharacter.Text = "+";
            ButtonAddCharacter.UseVisualStyleBackColor = true;
            ButtonAddCharacter.Click += new EventHandler(ButtonAddCharacter_Click);

            /**
             * ButtonRemoveCharacter
             */
            ButtonRemoveCharacter.Enabled = false;
            ButtonRemoveCharacter.Location = new System.Drawing.Point(228, 40);
            ButtonRemoveCharacter.Name = "ButtonRemoveCharacter";
            ButtonRemoveCharacter.Size = new System.Drawing.Size(21, 23);
            ButtonRemoveCharacter.TabIndex = 6;
            ButtonRemoveCharacter.Text = "-";
            ButtonRemoveCharacter.UseVisualStyleBackColor = true;
            ButtonRemoveCharacter.Click += new EventHandler(ButtonRemoveCharacter_Click);

            /**
             * LabelFontTexture
             */
            LabelFontTexture.AutoSize = true;
            LabelFontTexture.Location = new System.Drawing.Point(6, 49);
            LabelFontTexture.Name = "LabelFontTexture";
            LabelFontTexture.Size = new System.Drawing.Size(46, 13);
            LabelFontTexture.TabIndex = 14;
            LabelFontTexture.Text = "Texture:";

            /**
             * ButtonFontTexture
             */
            ButtonFontTexture.Location = new System.Drawing.Point(117, 46);
            ButtonFontTexture.Name = "ButtonFontTexture";
            ButtonFontTexture.Size = new System.Drawing.Size(75, 23);
            ButtonFontTexture.TabIndex = 13;
            ButtonFontTexture.Text = "Set...";
            ButtonFontTexture.UseVisualStyleBackColor = true;
            ButtonFontTexture.Click +=new EventHandler(SetTextureButton_Click);

            /**
             * LabelSpaceWidth
             */
            LabelSpaceWidth.AutoSize = true;
            LabelSpaceWidth.Location = new System.Drawing.Point(6, 273);
            LabelSpaceWidth.Name = "LabelSpaceWidth";
            LabelSpaceWidth.Size = new System.Drawing.Size(80, 13);
            LabelSpaceWidth.TabIndex = 15;
            LabelSpaceWidth.Text = "Spacing Width:";

            /**
             * NumericSpaceWidth
             */
            NumericSpaceWidth.Location = new System.Drawing.Point(92, 271);
            NumericSpaceWidth.Name = "NumericSpaceWidth";
            NumericSpaceWidth.Size = new System.Drawing.Size(78, 20);
            NumericSpaceWidth.TabIndex = 14;

            /**
             * LabelLineHeight
             */
            LabelLineHeight.AutoSize = true;
            LabelLineHeight.Location = new System.Drawing.Point(199, 273);
            LabelLineHeight.Name = "LabelLineHeight";
            LabelLineHeight.Size = new System.Drawing.Size(64, 13);
            LabelLineHeight.TabIndex = 17;
            LabelLineHeight.Text = "Line Height:";

            /**
             * NumericLineHeight
             */
            NumericLineHeight.Location = new System.Drawing.Point(269, 271);
            NumericLineHeight.Name = "NumericLineHeight";
            NumericLineHeight.Size = new System.Drawing.Size(78, 20);
            NumericLineHeight.TabIndex = 16;


            /**
             * GroupCharacterDetails
             */
            GroupCharacterDetails.Controls.Add(LabelCharYOffset);
            GroupCharacterDetails.Controls.Add(NumericCharYOffset);
            GroupCharacterDetails.Controls.Add(NumericCharAfter);
            GroupCharacterDetails.Controls.Add(NumericCharBefore);
            GroupCharacterDetails.Controls.Add(ButtonCharacterBlit);
            GroupCharacterDetails.Controls.Add(PictureCharPreview);
            GroupCharacterDetails.Controls.Add(LabelCharAfter);
            GroupCharacterDetails.Controls.Add(LabelCharPreview);
            GroupCharacterDetails.Controls.Add(LabelCharBefore);
            GroupCharacterDetails.Location = new System.Drawing.Point(9, 69);
            GroupCharacterDetails.Name = "GroupCharacterDetails";
            GroupCharacterDetails.Size = new System.Drawing.Size(338, 189);
            GroupCharacterDetails.TabIndex = 12;
            GroupCharacterDetails.TabStop = false;
            GroupCharacterDetails.Text = "Character Details";

            /**
             * ButtonCharacterBlit
             */
            ButtonCharacterBlit.Enabled = false;
            ButtonCharacterBlit.Location = new System.Drawing.Point(219, 19);
            ButtonCharacterBlit.Name = "ButtonCharacterBlit";
            ButtonCharacterBlit.Size = new System.Drawing.Size(103, 23);
            ButtonCharacterBlit.TabIndex = 11;
            ButtonCharacterBlit.Text = "Blitting...";
            ButtonCharacterBlit.UseVisualStyleBackColor = true;
            ButtonCharacterBlit.Click += new EventHandler(ButtonCharacterBlit_Click);

            /**
             * LabelCharPreview
             */
            LabelCharPreview.AutoSize = true;
            LabelCharPreview.Location = new System.Drawing.Point(6, 34);
            LabelCharPreview.Name = "LabelCharPreview";
            LabelCharPreview.Size = new System.Drawing.Size(97, 13);
            LabelCharPreview.TabIndex = 3;
            LabelCharPreview.Text = "Character Preview:";

            /**
             * PictureCharPreview
             */
            PictureCharPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            PictureCharPreview.Location = new System.Drawing.Point(6, 50);
            PictureCharPreview.Name = "PictureCharPreview";
            PictureCharPreview.Size = new System.Drawing.Size(136, 127);
            PictureCharPreview.TabIndex = 2;
            PictureCharPreview.TabStop = false;

            /**
             * LabelCharBefore
             */
            LabelCharBefore.AutoSize = true;
            LabelCharBefore.Location = new System.Drawing.Point(145, 51);
            LabelCharBefore.Name = "LabelCharBefore";
            LabelCharBefore.Size = new System.Drawing.Size(41, 13);
            LabelCharBefore.TabIndex = 8;
            LabelCharBefore.Text = "Before:";

            /**
             * NumericCharBefore
             */
            NumericCharBefore.Enabled = false;
            NumericCharBefore.Location = new System.Drawing.Point(148, 67);
            NumericCharBefore.Maximum = 255;
            NumericCharBefore.Name = "NumericCharBefore";
            NumericCharBefore.Size = new System.Drawing.Size(78, 20);
            NumericCharBefore.TabIndex = 7;

            /**
             * LabelCharAfter
             */
            LabelCharAfter.AutoSize = true;
            LabelCharAfter.Location = new System.Drawing.Point(229, 51);
            LabelCharAfter.Name = "LabelCharAfter";
            LabelCharAfter.Size = new System.Drawing.Size(32, 13);
            LabelCharAfter.TabIndex = 10;
            LabelCharAfter.Text = "After:";

            /**
             * NumericCharAfter
             */
            NumericCharAfter.Enabled = false;
            NumericCharAfter.Location = new System.Drawing.Point(232, 67);
            NumericCharAfter.Maximum = 255;
            NumericCharAfter.Name = "NumericCharAfter";
            NumericCharAfter.Size = new System.Drawing.Size(78, 20);
            NumericCharAfter.TabIndex = 7;

            /**
             * LabelCharYOffset
             */
            LabelCharYOffset.AutoSize = true;
            LabelCharYOffset.Location = new System.Drawing.Point(145, 90);
            LabelCharYOffset.Name = "LabelCharYOffset";
            LabelCharYOffset.Size = new System.Drawing.Size(48, 13);
            LabelCharYOffset.TabIndex = 13;
            LabelCharYOffset.Text = "Y Offset:";

            /**
             * NumericCharYOffset
             */
            NumericCharYOffset.Enabled = false;
            NumericCharYOffset.Location = new System.Drawing.Point(148, 106);
            NumericCharYOffset.Maximum = 255;
            NumericCharYOffset.Name = "NumericCharYOffset";
            NumericCharYOffset.Size = new System.Drawing.Size(78, 20);
            NumericCharYOffset.TabIndex = 7;


            /**
             * GroupButtonEditor
             */
            GroupButtonEditor.Controls.Add(GroupButtonText);
            GroupButtonEditor.Controls.Add(ButtonButtonEdgeNE);
            GroupButtonEditor.Controls.Add(LabelButtonEdgeNE);
            GroupButtonEditor.Controls.Add(PictureButtonEdgeNE);
            GroupButtonEditor.Controls.Add(ButtonButtonEdgeSW);
            GroupButtonEditor.Controls.Add(LabelButtonEdgeSW);
            GroupButtonEditor.Controls.Add(PictureButtonEdgeSW);
            GroupButtonEditor.Controls.Add(ButtonButtonSide);
            GroupButtonEditor.Controls.Add(LabelButtonSide);
            GroupButtonEditor.Controls.Add(PictureButtonSide);
            GroupButtonEditor.Controls.Add(ButtonButtonTop);
            GroupButtonEditor.Controls.Add(LabelButtonTop);
            GroupButtonEditor.Controls.Add(PictureButtonTop);
            GroupButtonEditor.Controls.Add(ButtonButtonBody);
            GroupButtonEditor.Controls.Add(LabelButtonBody);
            GroupButtonEditor.Controls.Add(PictureButtonBody);
            GroupButtonEditor.Location = new System.Drawing.Point(374, 6);
            GroupButtonEditor.Name = "GroupButtonEditor";
            GroupButtonEditor.Size = new System.Drawing.Size(424, 125);
            GroupButtonEditor.TabIndex = 2;
            GroupButtonEditor.TabStop = false;
            GroupButtonEditor.Text = "Button Editor";

            /**
             * LabelButtonBody
             */
            LabelButtonBody.AutoSize = true;
            LabelButtonBody.Location = new System.Drawing.Point(6, 16);
            LabelButtonBody.Name = "LabelButtonBody";
            LabelButtonBody.Size = new System.Drawing.Size(34, 13);
            LabelButtonBody.TabIndex = 1;
            LabelButtonBody.Text = "Body:";

            /**
             * PictureButtonBody
             */
            PictureButtonBody.Location = new System.Drawing.Point(9, 32);
            PictureButtonBody.Name = "PictureButtonBody";
            PictureButtonBody.Size = new System.Drawing.Size(48, 48);
            PictureButtonBody.TabIndex = 0;
            PictureButtonBody.TabStop = false;

            /**
             * ButtonButtonBody
             */
            ButtonButtonBody.Location = new System.Drawing.Point(9, 86);
            ButtonButtonBody.Name = "ButtonButtonBody";
            ButtonButtonBody.Size = new System.Drawing.Size(48, 23);
            ButtonButtonBody.TabIndex = 2;
            ButtonButtonBody.Text = "Set...";
            ButtonButtonBody.UseVisualStyleBackColor = true;

            /**
             * LabelButtonTop
             */
            LabelButtonTop.AutoSize = true;
            LabelButtonTop.Location = new System.Drawing.Point(60, 16);
            LabelButtonTop.Name = "LabelButtonTop";
            LabelButtonTop.Size = new System.Drawing.Size(29, 13);
            LabelButtonTop.TabIndex = 4;
            LabelButtonTop.Text = "Top:";

            /**
             * PictureButtonTop
             */
            PictureButtonTop.Location = new System.Drawing.Point(63, 32);
            PictureButtonTop.Name = "PictureButtonTop";
            PictureButtonTop.Size = new System.Drawing.Size(48, 48);
            PictureButtonTop.TabIndex = 3;
            PictureButtonTop.TabStop = false;

            /**
             * ButtonButtonTop
             */
            ButtonButtonTop.Location = new System.Drawing.Point(63, 86);
            ButtonButtonTop.Name = "ButtonButtonTop";
            ButtonButtonTop.Size = new System.Drawing.Size(48, 23);
            ButtonButtonTop.TabIndex = 5;
            ButtonButtonTop.Text = "Set...";
            ButtonButtonTop.UseVisualStyleBackColor = true;

            /**
             * LabelButtonSide
             */
            LabelButtonSide.AutoSize = true;
            LabelButtonSide.Location = new System.Drawing.Point(114, 16);
            LabelButtonSide.Name = "LabelButtonSide";
            LabelButtonSide.Size = new System.Drawing.Size(31, 13);
            LabelButtonSide.TabIndex = 7;
            LabelButtonSide.Text = "Side:";

            /**
             * PictureButtonSide
             */
            PictureButtonSide.Location = new System.Drawing.Point(117, 32);
            PictureButtonSide.Name = "PictureButtonSide";
            PictureButtonSide.Size = new System.Drawing.Size(48, 48);
            PictureButtonSide.TabIndex = 6;
            PictureButtonSide.TabStop = false;

            /**
             * ButtonButtonSide
             */
            ButtonButtonSide.Location = new System.Drawing.Point(117, 86);
            ButtonButtonSide.Name = "ButtonButtonSide";
            ButtonButtonSide.Size = new System.Drawing.Size(48, 23);
            ButtonButtonSide.TabIndex = 8;
            ButtonButtonSide.Text = "Set...";
            ButtonButtonSide.UseVisualStyleBackColor = true;

            /**
             * LabelButtonEdgeSW
             */
            LabelButtonEdgeSW.AutoSize = true;
            LabelButtonEdgeSW.Location = new System.Drawing.Point(168, 16);
            LabelButtonEdgeSW.Name = "LabelButtonEdgeSW";
            LabelButtonEdgeSW.Size = new System.Drawing.Size(56, 13);
            LabelButtonEdgeSW.TabIndex = 10;
            LabelButtonEdgeSW.Text = "Edge SW:";

            /**
             * PictureButtonEdgeSW
             */
            PictureButtonEdgeSW.Location = new System.Drawing.Point(171, 32);
            PictureButtonEdgeSW.Name = "PictureButtonEdgeSW";
            PictureButtonEdgeSW.Size = new System.Drawing.Size(48, 48);
            PictureButtonEdgeSW.TabIndex = 9;
            PictureButtonEdgeSW.TabStop = false;

            /**
             * ButtonButtonEdgeSW
             */
            ButtonButtonEdgeSW.Location = new System.Drawing.Point(171, 86);
            ButtonButtonEdgeSW.Name = "ButtonButtonEdgeSW";
            ButtonButtonEdgeSW.Size = new System.Drawing.Size(48, 23);
            ButtonButtonEdgeSW.TabIndex = 11;
            ButtonButtonEdgeSW.Text = "Set...";
            ButtonButtonEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelButtonEdgeNE
             */
            LabelButtonEdgeNE.AutoSize = true;
            LabelButtonEdgeNE.Location = new System.Drawing.Point(222, 16);
            LabelButtonEdgeNE.Name = "LabelButtonEdgeNE";
            LabelButtonEdgeNE.Size = new System.Drawing.Size(53, 13);
            LabelButtonEdgeNE.TabIndex = 13;
            LabelButtonEdgeNE.Text = "Edge NE:";

            /**
             * PictureButtonEdgeNE
             */
            PictureButtonEdgeNE.Location = new System.Drawing.Point(225, 32);
            PictureButtonEdgeNE.Name = "PictureButtonEdgeNE";
            PictureButtonEdgeNE.Size = new System.Drawing.Size(48, 48);
            PictureButtonEdgeNE.TabIndex = 12;
            PictureButtonEdgeNE.TabStop = false;

            /**
             * ButtonButtonEdgeNE
             */
            ButtonButtonEdgeNE.Location = new System.Drawing.Point(225, 86);
            ButtonButtonEdgeNE.Name = "ButtonButtonEdgeNE";
            ButtonButtonEdgeNE.Size = new System.Drawing.Size(48, 23);
            ButtonButtonEdgeNE.TabIndex = 14;
            ButtonButtonEdgeNE.Text = "Set...";
            ButtonButtonEdgeNE.UseVisualStyleBackColor = true;


            /**
             * GroupButtonText
             */
            GroupButtonText.Controls.Add(NumericButtonTextXOffset);
            GroupButtonText.Controls.Add(LabelButtonTextXOffset);
            GroupButtonText.Controls.Add(NumericButtonTextYOffset);
            GroupButtonText.Controls.Add(LabelButtonTextYOffset);
            GroupButtonText.Controls.Add(CheckButtonCentreText);
            GroupButtonText.Location = new System.Drawing.Point(281, 16);
            GroupButtonText.Name = "GroupButtonText";
            GroupButtonText.Size = new System.Drawing.Size(135, 99);
            GroupButtonText.TabIndex = 16;
            GroupButtonText.TabStop = false;
            GroupButtonText.Text = "Text Details";

            /**
             * CheckButtonCentreText
             */
            CheckButtonCentreText.AutoSize = true;
            CheckButtonCentreText.Checked = true;
            CheckButtonCentreText.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckButtonCentreText.Location = new System.Drawing.Point(6, 19);
            CheckButtonCentreText.Name = "CheckButtonCentreText";
            CheckButtonCentreText.Size = new System.Drawing.Size(81, 17);
            CheckButtonCentreText.TabIndex = 15;
            CheckButtonCentreText.Text = "Centre Text";
            CheckButtonCentreText.UseVisualStyleBackColor = true;

            /**
             * LabelButtonTextYOffset
             */
            LabelButtonTextYOffset.AutoSize = true;
            LabelButtonTextYOffset.Location = new System.Drawing.Point(6, 44);
            LabelButtonTextYOffset.Name = "LabelButtonTextYOffset";
            LabelButtonTextYOffset.Size = new System.Drawing.Size(60, 13);
            LabelButtonTextYOffset.TabIndex = 16;
            LabelButtonTextYOffset.Text = "Offset Top:";

            /**
             * NumericButtonTextYOffset
             */
            NumericButtonTextYOffset.Location = new System.Drawing.Point(72, 42);
            NumericButtonTextYOffset.Name = "NumericButtonTextYOffset";
            NumericButtonTextYOffset.Size = new System.Drawing.Size(57, 20);
            NumericButtonTextYOffset.TabIndex = 17;

            /**
             * LabelButtonTextXOffset
             */
            LabelButtonTextXOffset.AutoSize = true;
            LabelButtonTextXOffset.Location = new System.Drawing.Point(6, 70);
            LabelButtonTextXOffset.Name = "LabelButtonTextXOffset";
            LabelButtonTextXOffset.Size = new System.Drawing.Size(59, 13);
            LabelButtonTextXOffset.TabIndex = 18;
            LabelButtonTextXOffset.Text = "Offset Left:";

            /**
             * NumericButtonTextXOffset
             */
            NumericButtonTextXOffset.Location = new System.Drawing.Point(72, 68);
            NumericButtonTextXOffset.Name = "NumericButtonTextXOffset";
            NumericButtonTextXOffset.Size = new System.Drawing.Size(57, 20);
            NumericButtonTextXOffset.TabIndex = 19;


            /**
             * GroupTextEditor
             */
            GroupTextEditor.Controls.Add(GroupTextText);
            GroupTextEditor.Controls.Add(ButtonTextEdgeNE);
            GroupTextEditor.Controls.Add(LabelTextEdgeNE);
            GroupTextEditor.Controls.Add(PictureTextEdgeNE);
            GroupTextEditor.Controls.Add(ButtonTextEdgeSW);
            GroupTextEditor.Controls.Add(LabelTextEdgeSW);
            GroupTextEditor.Controls.Add(PictureTextEdgeSW);
            GroupTextEditor.Controls.Add(ButtonTextSide);
            GroupTextEditor.Controls.Add(LabelTextSide);
            GroupTextEditor.Controls.Add(PictureTextSide);
            GroupTextEditor.Controls.Add(ButtonTextTop);
            GroupTextEditor.Controls.Add(LabelTextTop);
            GroupTextEditor.Controls.Add(PictureTextTop);
            GroupTextEditor.Controls.Add(ButtonTextBody);
            GroupTextEditor.Controls.Add(LabelTextBody);
            GroupTextEditor.Controls.Add(PictureTextBody);
            GroupTextEditor.Location = new System.Drawing.Point(374, 137);
            GroupTextEditor.Name = "GroupTextEditor";
            GroupTextEditor.Size = new System.Drawing.Size(424, 125);
            GroupTextEditor.TabIndex = 17;
            GroupTextEditor.TabStop = false;
            GroupTextEditor.Text = "TextBox Editor";

            /**
             * LabelTextBody
             */
            LabelTextBody.AutoSize = true;
            LabelTextBody.Location = new System.Drawing.Point(6, 16);
            LabelTextBody.Name = "LabelTextBody";
            LabelTextBody.Size = new System.Drawing.Size(34, 13);
            LabelTextBody.TabIndex = 1;
            LabelTextBody.Text = "Body:";

            /**
             * PictureTextBody
             */
            PictureTextBody.Location = new System.Drawing.Point(9, 32);
            PictureTextBody.Name = "PictureTextBody";
            PictureTextBody.Size = new System.Drawing.Size(48, 48);
            PictureTextBody.TabIndex = 0;
            PictureTextBody.TabStop = false;

            /**
             * ButtonTextBody
             */
            ButtonTextBody.Location = new System.Drawing.Point(9, 86);
            ButtonTextBody.Name = "ButtonTextBody";
            ButtonTextBody.Size = new System.Drawing.Size(48, 23);
            ButtonTextBody.TabIndex = 2;
            ButtonTextBody.Text = "Set...";
            ButtonTextBody.UseVisualStyleBackColor = true;

            /**
             * LabelTextTop
             */
            LabelTextTop.AutoSize = true;
            LabelTextTop.Location = new System.Drawing.Point(60, 16);
            LabelTextTop.Name = "LabelTextTop";
            LabelTextTop.Size = new System.Drawing.Size(29, 13);
            LabelTextTop.TabIndex = 4;
            LabelTextTop.Text = "Top:";

            /**
             * PictureTextTop
             */
            PictureTextTop.Location = new System.Drawing.Point(63, 32);
            PictureTextTop.Name = "PictureTextTop";
            PictureTextTop.Size = new System.Drawing.Size(48, 48);
            PictureTextTop.TabIndex = 3;
            PictureTextTop.TabStop = false;

            /**
             * ButtonTextTop
             */
            ButtonTextTop.Location = new System.Drawing.Point(63, 86);
            ButtonTextTop.Name = "ButtonTextTop";
            ButtonTextTop.Size = new System.Drawing.Size(48, 23);
            ButtonTextTop.TabIndex = 5;
            ButtonTextTop.Text = "Set...";
            ButtonTextTop.UseVisualStyleBackColor = true;

            /**
             * LabelTextSide
             */
            LabelTextSide.AutoSize = true;
            LabelTextSide.Location = new System.Drawing.Point(114, 16);
            LabelTextSide.Name = "LabelTextSide";
            LabelTextSide.Size = new System.Drawing.Size(31, 13);
            LabelTextSide.TabIndex = 7;
            LabelTextSide.Text = "Side:";

            /**
             * PictureTextSide
             */
            PictureTextSide.Location = new System.Drawing.Point(117, 32);
            PictureTextSide.Name = "PictureTextSide";
            PictureTextSide.Size = new System.Drawing.Size(48, 48);
            PictureTextSide.TabIndex = 6;
            PictureTextSide.TabStop = false;

            /**
             * ButtonTextSide
             */
            ButtonTextSide.Location = new System.Drawing.Point(117, 86);
            ButtonTextSide.Name = "ButtonTextSide";
            ButtonTextSide.Size = new System.Drawing.Size(48, 23);
            ButtonTextSide.TabIndex = 8;
            ButtonTextSide.Text = "Set...";
            ButtonTextSide.UseVisualStyleBackColor = true;

            /**
             * LabelTextEdgeSW
             */
            LabelTextEdgeSW.AutoSize = true;
            LabelTextEdgeSW.Location = new System.Drawing.Point(168, 16);
            LabelTextEdgeSW.Name = "LabelTextEdgeSW";
            LabelTextEdgeSW.Size = new System.Drawing.Size(56, 13);
            LabelTextEdgeSW.TabIndex = 10;
            LabelTextEdgeSW.Text = "Edge SW:";

            /**
             * PictureTextEdgeSW
             */
            PictureTextEdgeSW.Location = new System.Drawing.Point(171, 32);
            PictureTextEdgeSW.Name = "PictureTextEdgeSW";
            PictureTextEdgeSW.Size = new System.Drawing.Size(48, 48);
            PictureTextEdgeSW.TabIndex = 9;
            PictureTextEdgeSW.TabStop = false;

            /**
             * ButtonTextEdgeSW
             */
            ButtonTextEdgeSW.Location = new System.Drawing.Point(171, 86);
            ButtonTextEdgeSW.Name = "ButtonTextEdgeSW";
            ButtonTextEdgeSW.Size = new System.Drawing.Size(48, 23);
            ButtonTextEdgeSW.TabIndex = 11;
            ButtonTextEdgeSW.Text = "Set...";
            ButtonTextEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelTextEdgeNE
             */
            LabelTextEdgeNE.AutoSize = true;
            LabelTextEdgeNE.Location = new System.Drawing.Point(222, 16);
            LabelTextEdgeNE.Name = "LabelTextEdgeNE";
            LabelTextEdgeNE.Size = new System.Drawing.Size(53, 13);
            LabelTextEdgeNE.TabIndex = 13;
            LabelTextEdgeNE.Text = "Edge NE:";

            /**
             * PictureTextEdgeNE
             */
            PictureTextEdgeNE.Location = new System.Drawing.Point(225, 32);
            PictureTextEdgeNE.Name = "PictureTextEdgeNE";
            PictureTextEdgeNE.Size = new System.Drawing.Size(48, 48);
            PictureTextEdgeNE.TabIndex = 12;
            PictureTextEdgeNE.TabStop = false;

            /**
             * ButtonTextEdgeNE
             */
            ButtonTextEdgeNE.Location = new System.Drawing.Point(225, 86);
            ButtonTextEdgeNE.Name = "ButtonTextEdgeNE";
            ButtonTextEdgeNE.Size = new System.Drawing.Size(48, 23);
            ButtonTextEdgeNE.TabIndex = 14;
            ButtonTextEdgeNE.Text = "Set...";
            ButtonTextEdgeNE.UseVisualStyleBackColor = true;

            
            /**
             * GroupTextText
             */
            GroupTextText.Controls.Add(NumericTextTextXOffset);
            GroupTextText.Controls.Add(LabelTextTextXOffset);
            GroupTextText.Controls.Add(NumericTextTextYOffset);
            GroupTextText.Controls.Add(LabelTextTextYOffset);
            GroupTextText.Controls.Add(CheckTextCentreText);
            GroupTextText.Location = new System.Drawing.Point(281, 16);
            GroupTextText.Name = "GroupTextText";
            GroupTextText.Size = new System.Drawing.Size(135, 99);
            GroupTextText.TabIndex = 16;
            GroupTextText.TabStop = false;
            GroupTextText.Text = "Text Details";

            /**
             * CheckTextCentreText
             */
            CheckTextCentreText.AutoSize = true;
            CheckTextCentreText.Location = new System.Drawing.Point(6, 19);
            CheckTextCentreText.Name = "CheckTextCentreText";
            CheckTextCentreText.Size = new System.Drawing.Size(81, 17);
            CheckTextCentreText.TabIndex = 15;
            CheckTextCentreText.Text = "Centre Text";
            CheckTextCentreText.UseVisualStyleBackColor = true;

            /**
             * LabelTextTextYOffset
             */
            LabelTextTextYOffset.AutoSize = true;
            LabelTextTextYOffset.Location = new System.Drawing.Point(6, 44);
            LabelTextTextYOffset.Name = "LabelTextTextYOffset";
            LabelTextTextYOffset.Size = new System.Drawing.Size(60, 13);
            LabelTextTextYOffset.TabIndex = 16;
            LabelTextTextYOffset.Text = "Offset Top:";

            /**
             * NumericTextTextYOffset
             */
            NumericTextTextYOffset.Location = new System.Drawing.Point(72, 42);
            NumericTextTextYOffset.Name = "NumericTextTextYOffset";
            NumericTextTextYOffset.Size = new System.Drawing.Size(57, 20);
            NumericTextTextYOffset.TabIndex = 17;

            /**
             * LabelTextTextXOffset
             */
            LabelTextTextXOffset.AutoSize = true;
            LabelTextTextXOffset.Location = new System.Drawing.Point(6, 70);
            LabelTextTextXOffset.Name = "LabelTextTextXOffset";
            LabelTextTextXOffset.Size = new System.Drawing.Size(59, 13);
            LabelTextTextXOffset.TabIndex = 18;
            LabelTextTextXOffset.Text = "Offset Left:";

            /**
             * NumericTextTextXOffset
             */
            NumericTextTextXOffset.Location = new System.Drawing.Point(72, 68);
            NumericTextTextXOffset.Name = "NumericTextTextXOffset";
            NumericTextTextXOffset.Size = new System.Drawing.Size(57, 20);
            NumericTextTextXOffset.TabIndex = 19;


            /**
             * GroupCheckEditor
             */
            GroupCheckEditor.Controls.Add(ButtonCheckTick);
            GroupCheckEditor.Controls.Add(LabelCheckTick);
            GroupCheckEditor.Controls.Add(PictureCheckTick);
            GroupCheckEditor.Controls.Add(ButtonCheckEdgeNE);
            GroupCheckEditor.Controls.Add(LabelCheckEdgeNE);
            GroupCheckEditor.Controls.Add(PictureCheckEdgeNE);
            GroupCheckEditor.Controls.Add(ButtonCheckEdgeSW);
            GroupCheckEditor.Controls.Add(LabelCheckEdgeSW);
            GroupCheckEditor.Controls.Add(PictureCheckEdgeSW);
            GroupCheckEditor.Controls.Add(ButtonCheckSide);
            GroupCheckEditor.Controls.Add(LabelCheckSide);
            GroupCheckEditor.Controls.Add(PictureCheckSide);
            GroupCheckEditor.Controls.Add(ButtonCheckTop);
            GroupCheckEditor.Controls.Add(LabelCheckTop);
            GroupCheckEditor.Controls.Add(PictureCheckTop);
            GroupCheckEditor.Controls.Add(ButtonCheckBody);
            GroupCheckEditor.Controls.Add(LabelCheckBody);
            GroupCheckEditor.Controls.Add(PictureCheckBody);
            GroupCheckEditor.Location = new System.Drawing.Point(374, 268);
            GroupCheckEditor.Name = "GroupCheckEditor";
            GroupCheckEditor.Size = new System.Drawing.Size(424, 125);
            GroupCheckEditor.TabIndex = 18;
            GroupCheckEditor.TabStop = false;
            GroupCheckEditor.Text = "CheckBox Editor";

            /**
             * LabelCheckBody
             */
            LabelCheckBody.AutoSize = true;
            LabelCheckBody.Location = new System.Drawing.Point(6, 16);
            LabelCheckBody.Name = "LabelCheckBody";
            LabelCheckBody.Size = new System.Drawing.Size(34, 13);
            LabelCheckBody.TabIndex = 1;
            LabelCheckBody.Text = "Body:";

            /**
             * PictureCheckBody
             */
            PictureCheckBody.Location = new System.Drawing.Point(9, 32);
            PictureCheckBody.Name = "PictureCheckBody";
            PictureCheckBody.Size = new System.Drawing.Size(48, 48);
            PictureCheckBody.TabIndex = 0;
            PictureCheckBody.TabStop = false;

            /**
             * ButtonCheckBody
             */
            ButtonCheckBody.Location = new System.Drawing.Point(9, 86);
            ButtonCheckBody.Name = "ButtonCheckBody";
            ButtonCheckBody.Size = new System.Drawing.Size(48, 23);
            ButtonCheckBody.TabIndex = 2;
            ButtonCheckBody.Text = "Set...";
            ButtonCheckBody.UseVisualStyleBackColor = true;

            /**
             * LabelCheckTop
             */
            LabelCheckTop.AutoSize = true;
            LabelCheckTop.Location = new System.Drawing.Point(60, 16);
            LabelCheckTop.Name = "LabelCheckTop";
            LabelCheckTop.Size = new System.Drawing.Size(29, 13);
            LabelCheckTop.TabIndex = 4;
            LabelCheckTop.Text = "Top:";

            /**
             * PictureCheckTop
             */
            PictureCheckTop.Location = new System.Drawing.Point(63, 32);
            PictureCheckTop.Name = "PictureCheckTop";
            PictureCheckTop.Size = new System.Drawing.Size(48, 48);
            PictureCheckTop.TabIndex = 3;
            PictureCheckTop.TabStop = false;

            /**
             * ButtonCheckTop
             */
            ButtonCheckTop.Location = new System.Drawing.Point(63, 86);
            ButtonCheckTop.Name = "ButtonCheckTop";
            ButtonCheckTop.Size = new System.Drawing.Size(48, 23);
            ButtonCheckTop.TabIndex = 5;
            ButtonCheckTop.Text = "Set...";
            ButtonCheckTop.UseVisualStyleBackColor = true;

            /**
             * LabelCheckSide
             */
            LabelCheckSide.AutoSize = true;
            LabelCheckSide.Location = new System.Drawing.Point(114, 16);
            LabelCheckSide.Name = "LabelCheckSide";
            LabelCheckSide.Size = new System.Drawing.Size(31, 13);
            LabelCheckSide.TabIndex = 7;
            LabelCheckSide.Text = "Side:";

            /**
             * PictureCheckSide
             */
            PictureCheckSide.Location = new System.Drawing.Point(117, 32);
            PictureCheckSide.Name = "PictureCheckSide";
            PictureCheckSide.Size = new System.Drawing.Size(48, 48);
            PictureCheckSide.TabIndex = 6;
            PictureCheckSide.TabStop = false;

            /**
             * ButtonCheckSide
             */
            ButtonCheckSide.Location = new System.Drawing.Point(117, 86);
            ButtonCheckSide.Name = "ButtonCheckSide";
            ButtonCheckSide.Size = new System.Drawing.Size(48, 23);
            ButtonCheckSide.TabIndex = 8;
            ButtonCheckSide.Text = "Set...";
            ButtonCheckSide.UseVisualStyleBackColor = true;

            /**
             * LabelCheckEdgeSW
             */
            LabelCheckEdgeSW.AutoSize = true;
            LabelCheckEdgeSW.Location = new System.Drawing.Point(168, 16);
            LabelCheckEdgeSW.Name = "LabelCheckEdgeSW";
            LabelCheckEdgeSW.Size = new System.Drawing.Size(56, 13);
            LabelCheckEdgeSW.TabIndex = 10;
            LabelCheckEdgeSW.Text = "Edge SW:";

            /**
             * PictureCheckEdgeSW
             */
            PictureCheckEdgeSW.Location = new System.Drawing.Point(171, 32);
            PictureCheckEdgeSW.Name = "PictureCheckEdgeSW";
            PictureCheckEdgeSW.Size = new System.Drawing.Size(48, 48);
            PictureCheckEdgeSW.TabIndex = 9;
            PictureCheckEdgeSW.TabStop = false;

            /**
             * ButtonCheckEdgeSW
             */
            ButtonCheckEdgeSW.Location = new System.Drawing.Point(171, 86);
            ButtonCheckEdgeSW.Name = "ButtonCheckEdgeSW";
            ButtonCheckEdgeSW.Size = new System.Drawing.Size(48, 23);
            ButtonCheckEdgeSW.TabIndex = 11;
            ButtonCheckEdgeSW.Text = "Set...";
            ButtonCheckEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelCheckEdgeNE
             */
            LabelCheckEdgeNE.AutoSize = true;
            LabelCheckEdgeNE.Location = new System.Drawing.Point(222, 16);
            LabelCheckEdgeNE.Name = "LabelCheckEdgeNE";
            LabelCheckEdgeNE.Size = new System.Drawing.Size(53, 13);
            LabelCheckEdgeNE.TabIndex = 13;
            LabelCheckEdgeNE.Text = "Edge NE:";

            /**
             * PictureCheckEdgeNE
             */
            PictureCheckEdgeNE.Location = new System.Drawing.Point(225, 32);
            PictureCheckEdgeNE.Name = "PictureCheckEdgeNE";
            PictureCheckEdgeNE.Size = new System.Drawing.Size(48, 48);
            PictureCheckEdgeNE.TabIndex = 12;
            PictureCheckEdgeNE.TabStop = false;

            /**
             * ButtonCheckEdgeNE
             */
            ButtonCheckEdgeNE.Location = new System.Drawing.Point(225, 86);
            ButtonCheckEdgeNE.Name = "ButtonCheckEdgeNE";
            ButtonCheckEdgeNE.Size = new System.Drawing.Size(48, 23);
            ButtonCheckEdgeNE.TabIndex = 14;
            ButtonCheckEdgeNE.Text = "Set...";
            ButtonCheckEdgeNE.UseVisualStyleBackColor = true;

            /**
             * LabelCheckTick
             */
            LabelCheckTick.AutoSize = true;
            LabelCheckTick.Location = new System.Drawing.Point(276, 16);
            LabelCheckTick.Name = "LabelCheckTick";
            LabelCheckTick.Size = new System.Drawing.Size(31, 13);
            LabelCheckTick.TabIndex = 16;
            LabelCheckTick.Text = "Tick:";

            /**
             * PictureCheckTick
             */
            PictureCheckTick.Location = new System.Drawing.Point(279, 32);
            PictureCheckTick.Name = "PictureCheckTick";
            PictureCheckTick.Size = new System.Drawing.Size(48, 48);
            PictureCheckTick.TabIndex = 15;
            PictureCheckTick.TabStop = false;

            /**
             * ButtonCheckTick
             */
            ButtonCheckTick.Location = new System.Drawing.Point(279, 86);
            ButtonCheckTick.Name = "ButtonCheckTick";
            ButtonCheckTick.Size = new System.Drawing.Size(48, 23);
            ButtonCheckTick.TabIndex = 17;
            ButtonCheckTick.Text = "Set...";
            ButtonCheckTick.UseVisualStyleBackColor = true;

            #endregion

            LastSelectedFont = "Chat Font";

            if (file == "")
            {
                Text = "GUIOMETRY - *";
                IsUnsaved = true;
            }
            else
            {
                Text = "GUIOMETRY - " + Path.GetFileName(file);
            }
        }


        /// <summary>
        /// Gets the font information of the specified font name key.
        /// </summary>
        /// <param name="key">The font's name to get the info of.</param>
        /// <returns>The character's info if it is present, null otherwise.</returns>
        private FontInfo GetFontInfo(string key)
        {
            switch (key)
            {
                default:
                case "Chat Font": return InfoChatFont;
                case "Small Font": return InfoSmallFont;
                case "Medium Font": return InfoMediumFont;
                case "Huge Font": return InfoHugeFont;
            }
        }


        /// <summary>
        /// Try to select the first character from the characters listbox, on failure, disable character controls.
        /// </summary>
        private void TrySelectFirstCharacter()
        {
            if (ListCharacter.Items.Count > 0)
            {
                ListCharacter.SelectedIndex = 0;
            }
            else
            {
                // Disable remove character button
                ButtonRemoveCharacter.Enabled = false;

                // Disable character form controls
                ButtonCharacterBlit.Enabled = false;
                NumericCharBefore.Enabled = false;
                NumericCharBefore.Value = 0;
                NumericCharAfter.Enabled = false;
                NumericCharAfter.Value = 0;
                NumericCharYOffset.Enabled = false;
                NumericCharYOffset.Value = 0;
            }
        }


        /// <summary>
        /// Updates the character preview box from blitting information.
        /// </summary>
        /// <param name="refreshTexture">Whether the texture should be redrawn.</param>
        private void UpdateCharacterBlitPreview(bool refreshTexture = false)
        {
            char charSelected = (char)ListCharacter.SelectedItem;
            string fontSelected = (string)ComboFont.SelectedItem;
            FontInfo fontInfo = GetFontInfo(fontSelected);
            CharacterInfo charInfo = fontInfo.GetCharacter(charSelected);
            Rectangle blitRect = charInfo.GetBlitRectangle();
            Graphics GFX;

            using (Bitmap detailBitmap = new Bitmap(blitRect.Width, blitRect.Height))
            {
                Pen penBefore = new Pen(Color.Red);
                Pen penAfter = new Pen(Color.Blue);
                Pen penYOffset = new Pen(Color.Purple);

                // Dispose current image if there is one
                if(PictureCharPreview.Image != null) PictureCharPreview.Image.Dispose();

                // Draw all the graphics we need
                GFX = Graphics.FromImage(detailBitmap);

                GFX.DrawLine(penBefore,
                    new Point(charInfo.Before, 0),
                    new Point(charInfo.Before, PictureCharPreview.Height));

                GFX.DrawLine(penAfter,
                    new Point(charInfo.After, 0),
                    new Point(charInfo.After, PictureCharPreview.Height));

                GFX.DrawLine(penYOffset,
                    new Point(0, charInfo.YOffset),
                    new Point(PictureCharPreview.Width, charInfo.YOffset));

                PictureCharPreview.Image = (Bitmap)detailBitmap.Clone();

                // Dispose the pens
                penBefore.Dispose();
                penAfter.Dispose();
                penYOffset.Dispose();
            }


            // Dispose the graphics instance
            GFX.Dispose();

            
        }


        /// <summary>
        /// Update the character details into the relevant font information.
        /// </summary>
        /// <param name="lastCharacter">Whether the character to update was the last or the current selected.</param>
        /// <param name="lastFont">Whether the font to update the character in was the last or the current selected.</param>
        private void UpdateCharacterDetails(bool lastCharacter, bool lastFont)
        {
            bool charHasValue = false;
            char charToUpdate = ' ';

            if (lastCharacter)
            {
                charToUpdate = LastSelectedCharacter;
                charHasValue = true;
            }
            else
            {
                if (ListCharacter.SelectedItem != null)
                {
                    charToUpdate = (char)ListCharacter.SelectedItem;
                    charHasValue = true;
                }
            }

            string fontString = lastFont ?
                LastSelectedFont :
                (string)ComboFont.SelectedItem;

            if (charHasValue)
            {
                CharacterInfo charInfo = GetFontInfo(fontString).GetCharacter(charToUpdate);

                if (charInfo != null)
                {
                    charInfo.Before = (byte)NumericCharBefore.Value;
                    charInfo.After = (byte)NumericCharAfter.Value;
                    charInfo.YOffset = (byte)NumericCharYOffset.Value;
                }
            }
        }


        /// <summary>
        /// Updates the character form fields with the selected character's information.
        /// </summary>
        private void UpdateCharacterForms()
        {
            string fontSelected = (string)ComboFont.SelectedItem;
            char charSelected = (char)ListCharacter.SelectedItem;
            CharacterInfo charInfo = GetFontInfo(fontSelected).GetCharacter(charSelected);

            ButtonCharacterBlit.Enabled = true;
            NumericCharBefore.Enabled = true;
            NumericCharBefore.Value = charInfo.Before;
            NumericCharAfter.Enabled = true;
            NumericCharAfter.Value = charInfo.After;
            NumericCharYOffset.Enabled = true;
            NumericCharYOffset.Value = charInfo.YOffset;
        }


        /// <summary>
        /// Update the font details into the relevant font information.
        /// </summary>
        /// <param name="lastFont">Whether the font to update the details in was the last or the currently selected.</param>
        private void UpdateFontDetails(bool lastFont)
        {
            string fontSelected = lastFont ?
                LastSelectedFont :
                (string)ComboFont.SelectedItem;
            FontInfo fontInfo = GetFontInfo(fontSelected);

            fontInfo.LineHeight = (byte)NumericLineHeight.Value;
            fontInfo.SpacingWidth = (byte)NumericSpaceWidth.Value;
        }


        /// <summary>
        /// Updates elements in this tab related to font information.
        /// </summary>
        private void UpdateFontTexturePreviews()
        {
            Texture selectedFontTexture = GetFontInfo((string)ComboFont.SelectedItem).Texture;

            if (selectedFontTexture.Source != null && selectedFontTexture.Data != null)
            {
                LabelFontTexture.Text = selectedFontTexture.Source.Length > 11 ?
                    "Texture:..." + selectedFontTexture.Source.Substring(selectedFontTexture.Source.Length - 11) :
                    "Texture:" + selectedFontTexture.Source;

                TooltipGlobal.SetToolTip(LabelFontTexture, selectedFontTexture.Source);

                // Update character preview here
            }
            else
            {
                LabelFontTexture.Text = "Texture:";
                TooltipGlobal.SetToolTip(LabelFontTexture, "");
                PictureCharPreview.Image = null;
            }
        }


        /// <summary>
        /// "Set..." button clicked.
        /// </summary>
        private void SetTextureButton_Click(object sender, EventArgs e)
        {
            Dialog.SetTexture setTextureDialog;

            switch (((Button)sender).Name)
            {
                /**
                 * Font texture "Set..." button.
                 */
                case "ButtonFontTexture":
                    string fontSelected = (string)ComboFont.SelectedItem;
                    setTextureDialog = new Dialog.SetTexture(fontSelected, GetFontInfo(fontSelected).Texture);

                    break;


                /**
                 * Unknown button clicked.
                 */
                default:
                    setTextureDialog = new Dialog.SetTexture("No Target", new Texture(null, null));

                    break;
            }

            if (setTextureDialog.ShowDialog() == DialogResult.OK)
            {
                switch (((Button)sender).Name)
                {
                    case "ButtonFontTexture":
                        UpdateFontTexturePreviews();
                        break;
                }
            }
        }


        /// <summary>
        /// [Event] "+" Add character button clicked.
        /// </summary>
        void ButtonAddCharacter_Click(object sender, EventArgs e)
        {
            // Save the character info before we change the selected character.
            UpdateCharacterDetails(false, false);

            string fontSelected = (string)ComboFont.SelectedItem;
            FontInfo fontInfo = GetFontInfo(fontSelected);

            Dialog.AddCharacter addCharacterDialog = new Dialog.AddCharacter(fontInfo.GetListCharacters());

            if (addCharacterDialog.ShowDialog() == DialogResult.OK)
            {
                fontInfo.AddNewCharacter(addCharacterDialog.Character);

                // Add the new character to the listbox and select it
                ListCharacter.Items.Add(addCharacterDialog.Character);
                ListCharacter.SelectedIndex = ListCharacter.Items.Count - 1;
            }
        }


        /// <summary>
        /// "Blitting..." button clicked.
        /// </summary>
        void ButtonCharacterBlit_Click(object sender, EventArgs e)
        {
            string fontSelected = (string)ComboFont.SelectedItem;
            char charSelected = (char)ListCharacter.SelectedItem;
            FontInfo fontInfo = GetFontInfo(fontSelected);
            CharacterInfo charInfo = fontInfo.GetCharacter(charSelected);

            if (fontInfo.Texture.Data != null)
            {
                Dialog.BlitCharacter blitCharacterDialog = new Dialog.BlitCharacter(charSelected, charInfo, fontInfo.Texture.Data);

                if (blitCharacterDialog.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Update character preview here
                }
            }
            else
            {
                Error.Show(Error.MISSING_FONT_TEXTURE);
            }
        }


        /// <summary>
        /// [Event] "-" Remove character button clicked.
        /// </summary>
        void ButtonRemoveCharacter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this character from this font?", "RozWorld Editor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                char charSelected = (char)ListCharacter.SelectedItem;
                string fontSelected = (string)ComboFont.SelectedItem;
                FontInfo fontInfo = GetFontInfo(fontSelected);

                // Remove character from the font information and from the listbox
                fontInfo.RemoveCharacter(charSelected);
                ListCharacter.Items.RemoveAt(ListCharacter.SelectedIndex);

                // Try to select the first character...
                TrySelectFirstCharacter();
            }
        }


        /// <summary>
        /// [Event] Font drop down selected item changed.
        /// </summary>
        void ComboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontTexturePreviews();

            // Save the current character and font info to the last font picked.
            UpdateCharacterDetails(false, true);
            UpdateFontDetails(true);

            // Update the character listbox
            ListCharacter.Items.Clear();

            string fontSelected = (string)ComboFont.SelectedItem;
            FontInfo fontInfo = GetFontInfo(fontSelected);

            foreach (char character in fontInfo.GetListCharacters())
            {
                ListCharacter.Items.Add(character);
            }

            LastSelectedCharacter = (char)0; // Prevent character details from being overwritten

            // Try to select the first character...
            TrySelectFirstCharacter();

            // Update the font specific fields
            NumericSpaceWidth.Value = fontInfo.SpacingWidth;
            NumericLineHeight.Value = fontInfo.LineHeight;

            // Set the last selected font to what was just picked.
            LastSelectedFont = fontSelected;
        }


        /// <summary>
        /// Font character listbox selection changed.
        /// </summary>
        void ListCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListCharacter.SelectedItem != null)
            {
                if (LastSelectedCharacter != 0)
                {
                    // Save the character info to the last character picked.
                    UpdateCharacterDetails(true, false);
                }

                // Load the selected character's info into the form
                UpdateCharacterForms();

                // Enable remove character button
                ButtonRemoveCharacter.Enabled = true;

                // Set the last selected character to what was just picked.
                LastSelectedCharacter = (char)ListCharacter.SelectedItem;
            }
        }
    }
}
