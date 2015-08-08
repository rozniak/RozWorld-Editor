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

        #region Texture References

        /**
         * Font textures, strings contain the source of the texture, Image is the texture itself.
         */
        private Texture TextureChatFont = new Texture(null, null);
        private Texture TextureSmallFont = new Texture(null, null);
        private Texture TextureMediumFont = new Texture(null, null);
        private Texture TextureHugeFont = new Texture(null, null);

        #endregion

        #region Font Character Lists

        private List<char> CharactersChatFont = new List<char>();
        private List<char> CharactersSmallFont = new List<char>();
        private List<char> CharactersMediumFont = new List<char>();
        private List<char> CharactersHugeFont = new List<char>();

        #endregion

        /**
         * Keep track of the last picked font, so that the character list saving can work.
         */
        private string LastSelectedFont;


        public GUIOMETRYEditor(TabControl parentTabUI, int uniqueID, string file = "")
        {
            #region Windows Forms Initialisation

            this.ParentTabUI = parentTabUI;
            this.ParentForm = (MainForm)parentTabUI.Parent;

            this.Controls.Add(this.LabelTabTitle);

            this.Controls.Add(this.GroupFontEditor);
            this.Controls.Add(this.GroupButtonEditor);
            this.Controls.Add(this.GroupTextEditor);
            this.Controls.Add(this.GroupCheckEditor);


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
            this.LabelTabTitle.AutoSize = true;
            this.LabelTabTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTabTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelTabTitle.Location = new System.Drawing.Point(8, 3);
            this.LabelTabTitle.Name = "LabelTabTitle";
            this.LabelTabTitle.Size = new System.Drawing.Size(243, 24);
            this.LabelTabTitle.TabIndex = 1;
            this.LabelTabTitle.Text = "GUIOMETRY.BIN Editor";


            /**
             * GroupFontEditor
             */
            this.GroupFontEditor.Controls.Add(this.NumericLineHeight);
            this.GroupFontEditor.Controls.Add(this.LabelLineHeight);
            this.GroupFontEditor.Controls.Add(this.NumericSpaceWidth);
            this.GroupFontEditor.Controls.Add(this.LabelSpaceWidth);
            this.GroupFontEditor.Controls.Add(this.LabelFontTexture);
            this.GroupFontEditor.Controls.Add(this.ButtonFontTexture);
            this.GroupFontEditor.Controls.Add(this.GroupCharacterDetails);
            this.GroupFontEditor.Controls.Add(this.ButtonRemoveCharacter);
            this.GroupFontEditor.Controls.Add(this.ButtonAddCharacter);
            this.GroupFontEditor.Controls.Add(this.ListCharacter);
            this.GroupFontEditor.Controls.Add(this.LabelCharacter);
            this.GroupFontEditor.Controls.Add(this.LabelFont);
            this.GroupFontEditor.Controls.Add(this.ComboFont);
            this.GroupFontEditor.Location = new System.Drawing.Point(12, 30);
            this.GroupFontEditor.Name = "GroupFontEditor";
            this.GroupFontEditor.Size = new System.Drawing.Size(356, 299);
            this.GroupFontEditor.TabIndex = 0;
            this.GroupFontEditor.TabStop = false;
            this.GroupFontEditor.Text = "Font Editor";

            /**
             * LabelFont
             */
            this.LabelFont.AutoSize = true;
            this.LabelFont.Location = new System.Drawing.Point(6, 22);
            this.LabelFont.Name = "LabelFont";
            this.LabelFont.Size = new System.Drawing.Size(31, 13);
            this.LabelFont.TabIndex = 1;
            this.LabelFont.Text = "Font:";

            /**
             * ComboFont
             */
            this.ComboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFont.FormattingEnabled = true;
            this.ComboFont.Items.AddRange(new object[] {
            "Chat Font",
            "Small Font",
            "Medium Font",
            "Huge Font"});
            this.ComboFont.Location = new System.Drawing.Point(43, 19);
            this.ComboFont.Name = "ComboFont";
            this.ComboFont.SelectedIndex = 0;
            this.ComboFont.Size = new System.Drawing.Size(149, 21);
            this.ComboFont.TabIndex = 0;
            this.ComboFont.SelectedIndexChanged += new EventHandler(ComboFont_SelectedIndexChanged);

            /**
             * LabelCharacter
             */
            this.LabelCharacter.AutoSize = true;
            this.LabelCharacter.Location = new System.Drawing.Point(198, 22);
            this.LabelCharacter.Name = "LabelCharacter";
            this.LabelCharacter.Size = new System.Drawing.Size(56, 13);
            this.LabelCharacter.TabIndex = 4;
            this.LabelCharacter.Text = "Character:";

            /**
             * ListCharacter
             */
            this.ListCharacter.FormattingEnabled = true;
            this.ListCharacter.Location = new System.Drawing.Point(260, 19);
            this.ListCharacter.Name = "ListCharacter";
            this.ListCharacter.Size = new System.Drawing.Size(90, 43);
            this.ListCharacter.TabIndex = 5;

            /**
             * ButtonAddCharacter
             */
            this.ButtonAddCharacter.Location = new System.Drawing.Point(201, 40);
            this.ButtonAddCharacter.Name = "ButtonAddCharacter";
            this.ButtonAddCharacter.Size = new System.Drawing.Size(21, 23);
            this.ButtonAddCharacter.TabIndex = 6;
            this.ButtonAddCharacter.Text = "+";
            this.ButtonAddCharacter.UseVisualStyleBackColor = true;
            this.ButtonAddCharacter.Click += new EventHandler(ButtonAddCharacter_Click);

            /**
             * ButtonRemoveCharacter
             */
            this.ButtonRemoveCharacter.Location = new System.Drawing.Point(228, 40);
            this.ButtonRemoveCharacter.Name = "ButtonRemoveCharacter";
            this.ButtonRemoveCharacter.Size = new System.Drawing.Size(21, 23);
            this.ButtonRemoveCharacter.TabIndex = 6;
            this.ButtonRemoveCharacter.Text = "-";
            this.ButtonRemoveCharacter.UseVisualStyleBackColor = true;
            this.ButtonRemoveCharacter.Click += new EventHandler(ButtonRemoveCharacter_Click);

            /**
             * LabelFontTexture
             */
            this.LabelFontTexture.AutoSize = true;
            this.LabelFontTexture.Location = new System.Drawing.Point(6, 49);
            this.LabelFontTexture.Name = "LabelFontTexture";
            this.LabelFontTexture.Size = new System.Drawing.Size(46, 13);
            this.LabelFontTexture.TabIndex = 14;
            this.LabelFontTexture.Text = "Texture:";

            /**
             * ButtonFontTexture
             */
            this.ButtonFontTexture.Location = new System.Drawing.Point(117, 46);
            this.ButtonFontTexture.Name = "ButtonFontTexture";
            this.ButtonFontTexture.Size = new System.Drawing.Size(75, 23);
            this.ButtonFontTexture.TabIndex = 13;
            this.ButtonFontTexture.Text = "Set...";
            this.ButtonFontTexture.UseVisualStyleBackColor = true;
            this.ButtonFontTexture.Click +=new EventHandler(this.SetTextureButton_Click);

            /**
             * LabelSpaceWidth
             */
            this.LabelSpaceWidth.AutoSize = true;
            this.LabelSpaceWidth.Location = new System.Drawing.Point(6, 273);
            this.LabelSpaceWidth.Name = "LabelSpaceWidth";
            this.LabelSpaceWidth.Size = new System.Drawing.Size(80, 13);
            this.LabelSpaceWidth.TabIndex = 15;
            this.LabelSpaceWidth.Text = "Spacing Width:";

            /**
             * NumericSpaceWidth
             */
            this.NumericSpaceWidth.Location = new System.Drawing.Point(92, 271);
            this.NumericSpaceWidth.Name = "NumericSpaceWidth";
            this.NumericSpaceWidth.Size = new System.Drawing.Size(78, 20);
            this.NumericSpaceWidth.TabIndex = 14;

            /**
             * LabelLineHeight
             */
            this.LabelLineHeight.AutoSize = true;
            this.LabelLineHeight.Location = new System.Drawing.Point(199, 273);
            this.LabelLineHeight.Name = "LabelLineHeight";
            this.LabelLineHeight.Size = new System.Drawing.Size(64, 13);
            this.LabelLineHeight.TabIndex = 17;
            this.LabelLineHeight.Text = "Line Height:";

            /**
             * NumericLineHeight
             */
            this.NumericLineHeight.Location = new System.Drawing.Point(269, 271);
            this.NumericLineHeight.Name = "NumericLineHeight";
            this.NumericLineHeight.Size = new System.Drawing.Size(78, 20);
            this.NumericLineHeight.TabIndex = 16;


            /**
             * GroupCharacterDetails
             */
            this.GroupCharacterDetails.Controls.Add(this.LabelCharYOffset);
            this.GroupCharacterDetails.Controls.Add(this.NumericCharYOffset);
            this.GroupCharacterDetails.Controls.Add(this.NumericCharAfter);
            this.GroupCharacterDetails.Controls.Add(this.NumericCharBefore);
            this.GroupCharacterDetails.Controls.Add(this.ButtonCharacterBlit);
            this.GroupCharacterDetails.Controls.Add(this.PictureCharPreview);
            this.GroupCharacterDetails.Controls.Add(this.LabelCharAfter);
            this.GroupCharacterDetails.Controls.Add(this.LabelCharPreview);
            this.GroupCharacterDetails.Controls.Add(this.LabelCharBefore);
            this.GroupCharacterDetails.Location = new System.Drawing.Point(9, 69);
            this.GroupCharacterDetails.Name = "GroupCharacterDetails";
            this.GroupCharacterDetails.Size = new System.Drawing.Size(338, 189);
            this.GroupCharacterDetails.TabIndex = 12;
            this.GroupCharacterDetails.TabStop = false;
            this.GroupCharacterDetails.Text = "Character Details";

            /**
             * ButtonCharacterBlit
             */
            this.ButtonCharacterBlit.Enabled = false;
            this.ButtonCharacterBlit.Location = new System.Drawing.Point(219, 19);
            this.ButtonCharacterBlit.Name = "ButtonCharacterBlit";
            this.ButtonCharacterBlit.Size = new System.Drawing.Size(103, 23);
            this.ButtonCharacterBlit.TabIndex = 11;
            this.ButtonCharacterBlit.Text = "Blitting...";
            this.ButtonCharacterBlit.UseVisualStyleBackColor = true;

            /**
             * LabelCharPreview
             */
            this.LabelCharPreview.AutoSize = true;
            this.LabelCharPreview.Location = new System.Drawing.Point(6, 34);
            this.LabelCharPreview.Name = "LabelCharPreview";
            this.LabelCharPreview.Size = new System.Drawing.Size(97, 13);
            this.LabelCharPreview.TabIndex = 3;
            this.LabelCharPreview.Text = "Character Preview:";

            /**
             * PictureCharPreview
             */
            this.PictureCharPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureCharPreview.Location = new System.Drawing.Point(6, 50);
            this.PictureCharPreview.Name = "PictureCharPreview";
            this.PictureCharPreview.Size = new System.Drawing.Size(136, 127);
            this.PictureCharPreview.TabIndex = 2;
            this.PictureCharPreview.TabStop = false;

            /**
             * LabelCharBefore
             */
            this.LabelCharBefore.AutoSize = true;
            this.LabelCharBefore.Location = new System.Drawing.Point(145, 51);
            this.LabelCharBefore.Name = "LabelCharBefore";
            this.LabelCharBefore.Size = new System.Drawing.Size(41, 13);
            this.LabelCharBefore.TabIndex = 8;
            this.LabelCharBefore.Text = "Before:";

            /**
             * NumericCharBefore
             */
            this.NumericCharBefore.Enabled = false;
            this.NumericCharBefore.Location = new System.Drawing.Point(148, 67);
            this.NumericCharBefore.Name = "NumericCharBefore";
            this.NumericCharBefore.Size = new System.Drawing.Size(78, 20);
            this.NumericCharBefore.TabIndex = 7;

            /**
             * LabelCharAfter
             */
            this.LabelCharAfter.AutoSize = true;
            this.LabelCharAfter.Location = new System.Drawing.Point(229, 51);
            this.LabelCharAfter.Name = "LabelCharAfter";
            this.LabelCharAfter.Size = new System.Drawing.Size(32, 13);
            this.LabelCharAfter.TabIndex = 10;
            this.LabelCharAfter.Text = "After:";

            /**
             * NumericCharAfter
             */
            this.NumericCharAfter.Enabled = false;
            this.NumericCharAfter.Location = new System.Drawing.Point(232, 67);
            this.NumericCharAfter.Name = "NumericCharAfter";
            this.NumericCharAfter.Size = new System.Drawing.Size(78, 20);
            this.NumericCharAfter.TabIndex = 7;

            /**
             * LabelCharYOffset
             */
            this.LabelCharYOffset.AutoSize = true;
            this.LabelCharYOffset.Location = new System.Drawing.Point(145, 90);
            this.LabelCharYOffset.Name = "LabelCharYOffset";
            this.LabelCharYOffset.Size = new System.Drawing.Size(48, 13);
            this.LabelCharYOffset.TabIndex = 13;
            this.LabelCharYOffset.Text = "Y Offset:";

            /**
             * NumericCharYOffset
             */
            this.NumericCharYOffset.Enabled = false;
            this.NumericCharYOffset.Location = new System.Drawing.Point(148, 106);
            this.NumericCharYOffset.Name = "NumericCharYOffset";
            this.NumericCharYOffset.Size = new System.Drawing.Size(78, 20);
            this.NumericCharYOffset.TabIndex = 7;


            /**
             * GroupButtonEditor
             */
            this.GroupButtonEditor.Controls.Add(this.GroupButtonText);
            this.GroupButtonEditor.Controls.Add(this.ButtonButtonEdgeNE);
            this.GroupButtonEditor.Controls.Add(this.LabelButtonEdgeNE);
            this.GroupButtonEditor.Controls.Add(this.PictureButtonEdgeNE);
            this.GroupButtonEditor.Controls.Add(this.ButtonButtonEdgeSW);
            this.GroupButtonEditor.Controls.Add(this.LabelButtonEdgeSW);
            this.GroupButtonEditor.Controls.Add(this.PictureButtonEdgeSW);
            this.GroupButtonEditor.Controls.Add(this.ButtonButtonSide);
            this.GroupButtonEditor.Controls.Add(this.LabelButtonSide);
            this.GroupButtonEditor.Controls.Add(this.PictureButtonSide);
            this.GroupButtonEditor.Controls.Add(this.ButtonButtonTop);
            this.GroupButtonEditor.Controls.Add(this.LabelButtonTop);
            this.GroupButtonEditor.Controls.Add(this.PictureButtonTop);
            this.GroupButtonEditor.Controls.Add(this.ButtonButtonBody);
            this.GroupButtonEditor.Controls.Add(this.LabelButtonBody);
            this.GroupButtonEditor.Controls.Add(this.PictureButtonBody);
            this.GroupButtonEditor.Location = new System.Drawing.Point(374, 6);
            this.GroupButtonEditor.Name = "GroupButtonEditor";
            this.GroupButtonEditor.Size = new System.Drawing.Size(424, 125);
            this.GroupButtonEditor.TabIndex = 2;
            this.GroupButtonEditor.TabStop = false;
            this.GroupButtonEditor.Text = "Button Editor";

            /**
             * LabelButtonBody
             */
            this.LabelButtonBody.AutoSize = true;
            this.LabelButtonBody.Location = new System.Drawing.Point(6, 16);
            this.LabelButtonBody.Name = "LabelButtonBody";
            this.LabelButtonBody.Size = new System.Drawing.Size(34, 13);
            this.LabelButtonBody.TabIndex = 1;
            this.LabelButtonBody.Text = "Body:";

            /**
             * PictureButtonBody
             */
            this.PictureButtonBody.Location = new System.Drawing.Point(9, 32);
            this.PictureButtonBody.Name = "PictureButtonBody";
            this.PictureButtonBody.Size = new System.Drawing.Size(48, 48);
            this.PictureButtonBody.TabIndex = 0;
            this.PictureButtonBody.TabStop = false;

            /**
             * ButtonButtonBody
             */
            this.ButtonButtonBody.Location = new System.Drawing.Point(9, 86);
            this.ButtonButtonBody.Name = "ButtonButtonBody";
            this.ButtonButtonBody.Size = new System.Drawing.Size(48, 23);
            this.ButtonButtonBody.TabIndex = 2;
            this.ButtonButtonBody.Text = "Set...";
            this.ButtonButtonBody.UseVisualStyleBackColor = true;

            /**
             * LabelButtonTop
             */
            this.LabelButtonTop.AutoSize = true;
            this.LabelButtonTop.Location = new System.Drawing.Point(60, 16);
            this.LabelButtonTop.Name = "LabelButtonTop";
            this.LabelButtonTop.Size = new System.Drawing.Size(29, 13);
            this.LabelButtonTop.TabIndex = 4;
            this.LabelButtonTop.Text = "Top:";

            /**
             * PictureButtonTop
             */
            this.PictureButtonTop.Location = new System.Drawing.Point(63, 32);
            this.PictureButtonTop.Name = "PictureButtonTop";
            this.PictureButtonTop.Size = new System.Drawing.Size(48, 48);
            this.PictureButtonTop.TabIndex = 3;
            this.PictureButtonTop.TabStop = false;

            /**
             * ButtonButtonTop
             */
            this.ButtonButtonTop.Location = new System.Drawing.Point(63, 86);
            this.ButtonButtonTop.Name = "ButtonButtonTop";
            this.ButtonButtonTop.Size = new System.Drawing.Size(48, 23);
            this.ButtonButtonTop.TabIndex = 5;
            this.ButtonButtonTop.Text = "Set...";
            this.ButtonButtonTop.UseVisualStyleBackColor = true;

            /**
             * LabelButtonSide
             */
            this.LabelButtonSide.AutoSize = true;
            this.LabelButtonSide.Location = new System.Drawing.Point(114, 16);
            this.LabelButtonSide.Name = "LabelButtonSide";
            this.LabelButtonSide.Size = new System.Drawing.Size(31, 13);
            this.LabelButtonSide.TabIndex = 7;
            this.LabelButtonSide.Text = "Side:";

            /**
             * PictureButtonSide
             */
            this.PictureButtonSide.Location = new System.Drawing.Point(117, 32);
            this.PictureButtonSide.Name = "PictureButtonSide";
            this.PictureButtonSide.Size = new System.Drawing.Size(48, 48);
            this.PictureButtonSide.TabIndex = 6;
            this.PictureButtonSide.TabStop = false;

            /**
             * ButtonButtonSide
             */
            this.ButtonButtonSide.Location = new System.Drawing.Point(117, 86);
            this.ButtonButtonSide.Name = "ButtonButtonSide";
            this.ButtonButtonSide.Size = new System.Drawing.Size(48, 23);
            this.ButtonButtonSide.TabIndex = 8;
            this.ButtonButtonSide.Text = "Set...";
            this.ButtonButtonSide.UseVisualStyleBackColor = true;

            /**
             * LabelButtonEdgeSW
             */
            this.LabelButtonEdgeSW.AutoSize = true;
            this.LabelButtonEdgeSW.Location = new System.Drawing.Point(168, 16);
            this.LabelButtonEdgeSW.Name = "LabelButtonEdgeSW";
            this.LabelButtonEdgeSW.Size = new System.Drawing.Size(56, 13);
            this.LabelButtonEdgeSW.TabIndex = 10;
            this.LabelButtonEdgeSW.Text = "Edge SW:";

            /**
             * PictureButtonEdgeSW
             */
            this.PictureButtonEdgeSW.Location = new System.Drawing.Point(171, 32);
            this.PictureButtonEdgeSW.Name = "PictureButtonEdgeSW";
            this.PictureButtonEdgeSW.Size = new System.Drawing.Size(48, 48);
            this.PictureButtonEdgeSW.TabIndex = 9;
            this.PictureButtonEdgeSW.TabStop = false;

            /**
             * ButtonButtonEdgeSW
             */
            this.ButtonButtonEdgeSW.Location = new System.Drawing.Point(171, 86);
            this.ButtonButtonEdgeSW.Name = "ButtonButtonEdgeSW";
            this.ButtonButtonEdgeSW.Size = new System.Drawing.Size(48, 23);
            this.ButtonButtonEdgeSW.TabIndex = 11;
            this.ButtonButtonEdgeSW.Text = "Set...";
            this.ButtonButtonEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelButtonEdgeNE
             */
            this.LabelButtonEdgeNE.AutoSize = true;
            this.LabelButtonEdgeNE.Location = new System.Drawing.Point(222, 16);
            this.LabelButtonEdgeNE.Name = "LabelButtonEdgeNE";
            this.LabelButtonEdgeNE.Size = new System.Drawing.Size(53, 13);
            this.LabelButtonEdgeNE.TabIndex = 13;
            this.LabelButtonEdgeNE.Text = "Edge NE:";

            /**
             * PictureButtonEdgeNE
             */
            this.PictureButtonEdgeNE.Location = new System.Drawing.Point(225, 32);
            this.PictureButtonEdgeNE.Name = "PictureButtonEdgeNE";
            this.PictureButtonEdgeNE.Size = new System.Drawing.Size(48, 48);
            this.PictureButtonEdgeNE.TabIndex = 12;
            this.PictureButtonEdgeNE.TabStop = false;

            /**
             * ButtonButtonEdgeNE
             */
            this.ButtonButtonEdgeNE.Location = new System.Drawing.Point(225, 86);
            this.ButtonButtonEdgeNE.Name = "ButtonButtonEdgeNE";
            this.ButtonButtonEdgeNE.Size = new System.Drawing.Size(48, 23);
            this.ButtonButtonEdgeNE.TabIndex = 14;
            this.ButtonButtonEdgeNE.Text = "Set...";
            this.ButtonButtonEdgeNE.UseVisualStyleBackColor = true;


            /**
             * GroupButtonText
             */
            this.GroupButtonText.Controls.Add(this.NumericButtonTextXOffset);
            this.GroupButtonText.Controls.Add(this.LabelButtonTextXOffset);
            this.GroupButtonText.Controls.Add(this.NumericButtonTextYOffset);
            this.GroupButtonText.Controls.Add(this.LabelButtonTextYOffset);
            this.GroupButtonText.Controls.Add(this.CheckButtonCentreText);
            this.GroupButtonText.Location = new System.Drawing.Point(281, 16);
            this.GroupButtonText.Name = "GroupButtonText";
            this.GroupButtonText.Size = new System.Drawing.Size(135, 99);
            this.GroupButtonText.TabIndex = 16;
            this.GroupButtonText.TabStop = false;
            this.GroupButtonText.Text = "Text Details";

            /**
             * CheckButtonCentreText
             */
            this.CheckButtonCentreText.AutoSize = true;
            this.CheckButtonCentreText.Checked = true;
            this.CheckButtonCentreText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckButtonCentreText.Location = new System.Drawing.Point(6, 19);
            this.CheckButtonCentreText.Name = "CheckButtonCentreText";
            this.CheckButtonCentreText.Size = new System.Drawing.Size(81, 17);
            this.CheckButtonCentreText.TabIndex = 15;
            this.CheckButtonCentreText.Text = "Centre Text";
            this.CheckButtonCentreText.UseVisualStyleBackColor = true;

            /**
             * LabelButtonTextYOffset
             */
            this.LabelButtonTextYOffset.AutoSize = true;
            this.LabelButtonTextYOffset.Location = new System.Drawing.Point(6, 44);
            this.LabelButtonTextYOffset.Name = "LabelButtonTextYOffset";
            this.LabelButtonTextYOffset.Size = new System.Drawing.Size(60, 13);
            this.LabelButtonTextYOffset.TabIndex = 16;
            this.LabelButtonTextYOffset.Text = "Offset Top:";

            /**
             * NumericButtonTextYOffset
             */
            this.NumericButtonTextYOffset.Location = new System.Drawing.Point(72, 42);
            this.NumericButtonTextYOffset.Name = "NumericButtonTextYOffset";
            this.NumericButtonTextYOffset.Size = new System.Drawing.Size(57, 20);
            this.NumericButtonTextYOffset.TabIndex = 17;

            /**
             * LabelButtonTextXOffset
             */
            this.LabelButtonTextXOffset.AutoSize = true;
            this.LabelButtonTextXOffset.Location = new System.Drawing.Point(6, 70);
            this.LabelButtonTextXOffset.Name = "LabelButtonTextXOffset";
            this.LabelButtonTextXOffset.Size = new System.Drawing.Size(59, 13);
            this.LabelButtonTextXOffset.TabIndex = 18;
            this.LabelButtonTextXOffset.Text = "Offset Left:";

            /**
             * NumericButtonTextXOffset
             */
            this.NumericButtonTextXOffset.Location = new System.Drawing.Point(72, 68);
            this.NumericButtonTextXOffset.Name = "NumericButtonTextXOffset";
            this.NumericButtonTextXOffset.Size = new System.Drawing.Size(57, 20);
            this.NumericButtonTextXOffset.TabIndex = 19;


            /**
             * GroupTextEditor
             */
            this.GroupTextEditor.Controls.Add(this.GroupTextText);
            this.GroupTextEditor.Controls.Add(this.ButtonTextEdgeNE);
            this.GroupTextEditor.Controls.Add(this.LabelTextEdgeNE);
            this.GroupTextEditor.Controls.Add(this.PictureTextEdgeNE);
            this.GroupTextEditor.Controls.Add(this.ButtonTextEdgeSW);
            this.GroupTextEditor.Controls.Add(this.LabelTextEdgeSW);
            this.GroupTextEditor.Controls.Add(this.PictureTextEdgeSW);
            this.GroupTextEditor.Controls.Add(this.ButtonTextSide);
            this.GroupTextEditor.Controls.Add(this.LabelTextSide);
            this.GroupTextEditor.Controls.Add(this.PictureTextSide);
            this.GroupTextEditor.Controls.Add(this.ButtonTextTop);
            this.GroupTextEditor.Controls.Add(this.LabelTextTop);
            this.GroupTextEditor.Controls.Add(this.PictureTextTop);
            this.GroupTextEditor.Controls.Add(this.ButtonTextBody);
            this.GroupTextEditor.Controls.Add(this.LabelTextBody);
            this.GroupTextEditor.Controls.Add(this.PictureTextBody);
            this.GroupTextEditor.Location = new System.Drawing.Point(374, 137);
            this.GroupTextEditor.Name = "GroupTextEditor";
            this.GroupTextEditor.Size = new System.Drawing.Size(424, 125);
            this.GroupTextEditor.TabIndex = 17;
            this.GroupTextEditor.TabStop = false;
            this.GroupTextEditor.Text = "TextBox Editor";

            /**
             * LabelTextBody
             */
            this.LabelTextBody.AutoSize = true;
            this.LabelTextBody.Location = new System.Drawing.Point(6, 16);
            this.LabelTextBody.Name = "LabelTextBody";
            this.LabelTextBody.Size = new System.Drawing.Size(34, 13);
            this.LabelTextBody.TabIndex = 1;
            this.LabelTextBody.Text = "Body:";

            /**
             * PictureTextBody
             */
            this.PictureTextBody.Location = new System.Drawing.Point(9, 32);
            this.PictureTextBody.Name = "PictureTextBody";
            this.PictureTextBody.Size = new System.Drawing.Size(48, 48);
            this.PictureTextBody.TabIndex = 0;
            this.PictureTextBody.TabStop = false;

            /**
             * ButtonTextBody
             */
            this.ButtonTextBody.Location = new System.Drawing.Point(9, 86);
            this.ButtonTextBody.Name = "ButtonTextBody";
            this.ButtonTextBody.Size = new System.Drawing.Size(48, 23);
            this.ButtonTextBody.TabIndex = 2;
            this.ButtonTextBody.Text = "Set...";
            this.ButtonTextBody.UseVisualStyleBackColor = true;

            /**
             * LabelTextTop
             */
            this.LabelTextTop.AutoSize = true;
            this.LabelTextTop.Location = new System.Drawing.Point(60, 16);
            this.LabelTextTop.Name = "LabelTextTop";
            this.LabelTextTop.Size = new System.Drawing.Size(29, 13);
            this.LabelTextTop.TabIndex = 4;
            this.LabelTextTop.Text = "Top:";

            /**
             * PictureTextTop
             */
            this.PictureTextTop.Location = new System.Drawing.Point(63, 32);
            this.PictureTextTop.Name = "PictureTextTop";
            this.PictureTextTop.Size = new System.Drawing.Size(48, 48);
            this.PictureTextTop.TabIndex = 3;
            this.PictureTextTop.TabStop = false;

            /**
             * ButtonTextTop
             */
            this.ButtonTextTop.Location = new System.Drawing.Point(63, 86);
            this.ButtonTextTop.Name = "ButtonTextTop";
            this.ButtonTextTop.Size = new System.Drawing.Size(48, 23);
            this.ButtonTextTop.TabIndex = 5;
            this.ButtonTextTop.Text = "Set...";
            this.ButtonTextTop.UseVisualStyleBackColor = true;

            /**
             * LabelTextSide
             */
            this.LabelTextSide.AutoSize = true;
            this.LabelTextSide.Location = new System.Drawing.Point(114, 16);
            this.LabelTextSide.Name = "LabelTextSide";
            this.LabelTextSide.Size = new System.Drawing.Size(31, 13);
            this.LabelTextSide.TabIndex = 7;
            this.LabelTextSide.Text = "Side:";

            /**
             * PictureTextSide
             */
            this.PictureTextSide.Location = new System.Drawing.Point(117, 32);
            this.PictureTextSide.Name = "PictureTextSide";
            this.PictureTextSide.Size = new System.Drawing.Size(48, 48);
            this.PictureTextSide.TabIndex = 6;
            this.PictureTextSide.TabStop = false;

            /**
             * ButtonTextSide
             */
            this.ButtonTextSide.Location = new System.Drawing.Point(117, 86);
            this.ButtonTextSide.Name = "ButtonTextSide";
            this.ButtonTextSide.Size = new System.Drawing.Size(48, 23);
            this.ButtonTextSide.TabIndex = 8;
            this.ButtonTextSide.Text = "Set...";
            this.ButtonTextSide.UseVisualStyleBackColor = true;

            /**
             * LabelTextEdgeSW
             */
            this.LabelTextEdgeSW.AutoSize = true;
            this.LabelTextEdgeSW.Location = new System.Drawing.Point(168, 16);
            this.LabelTextEdgeSW.Name = "LabelTextEdgeSW";
            this.LabelTextEdgeSW.Size = new System.Drawing.Size(56, 13);
            this.LabelTextEdgeSW.TabIndex = 10;
            this.LabelTextEdgeSW.Text = "Edge SW:";

            /**
             * PictureTextEdgeSW
             */
            this.PictureTextEdgeSW.Location = new System.Drawing.Point(171, 32);
            this.PictureTextEdgeSW.Name = "PictureTextEdgeSW";
            this.PictureTextEdgeSW.Size = new System.Drawing.Size(48, 48);
            this.PictureTextEdgeSW.TabIndex = 9;
            this.PictureTextEdgeSW.TabStop = false;

            /**
             * ButtonTextEdgeSW
             */
            this.ButtonTextEdgeSW.Location = new System.Drawing.Point(171, 86);
            this.ButtonTextEdgeSW.Name = "ButtonTextEdgeSW";
            this.ButtonTextEdgeSW.Size = new System.Drawing.Size(48, 23);
            this.ButtonTextEdgeSW.TabIndex = 11;
            this.ButtonTextEdgeSW.Text = "Set...";
            this.ButtonTextEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelTextEdgeNE
             */
            this.LabelTextEdgeNE.AutoSize = true;
            this.LabelTextEdgeNE.Location = new System.Drawing.Point(222, 16);
            this.LabelTextEdgeNE.Name = "LabelTextEdgeNE";
            this.LabelTextEdgeNE.Size = new System.Drawing.Size(53, 13);
            this.LabelTextEdgeNE.TabIndex = 13;
            this.LabelTextEdgeNE.Text = "Edge NE:";

            /**
             * PictureTextEdgeNE
             */
            this.PictureTextEdgeNE.Location = new System.Drawing.Point(225, 32);
            this.PictureTextEdgeNE.Name = "PictureTextEdgeNE";
            this.PictureTextEdgeNE.Size = new System.Drawing.Size(48, 48);
            this.PictureTextEdgeNE.TabIndex = 12;
            this.PictureTextEdgeNE.TabStop = false;

            /**
             * ButtonTextEdgeNE
             */
            this.ButtonTextEdgeNE.Location = new System.Drawing.Point(225, 86);
            this.ButtonTextEdgeNE.Name = "ButtonTextEdgeNE";
            this.ButtonTextEdgeNE.Size = new System.Drawing.Size(48, 23);
            this.ButtonTextEdgeNE.TabIndex = 14;
            this.ButtonTextEdgeNE.Text = "Set...";
            this.ButtonTextEdgeNE.UseVisualStyleBackColor = true;

            
            /**
             * GroupTextText
             */
            this.GroupTextText.Controls.Add(this.NumericTextTextXOffset);
            this.GroupTextText.Controls.Add(this.LabelTextTextXOffset);
            this.GroupTextText.Controls.Add(this.NumericTextTextYOffset);
            this.GroupTextText.Controls.Add(this.LabelTextTextYOffset);
            this.GroupTextText.Controls.Add(this.CheckTextCentreText);
            this.GroupTextText.Location = new System.Drawing.Point(281, 16);
            this.GroupTextText.Name = "GroupTextText";
            this.GroupTextText.Size = new System.Drawing.Size(135, 99);
            this.GroupTextText.TabIndex = 16;
            this.GroupTextText.TabStop = false;
            this.GroupTextText.Text = "Text Details";

            /**
             * CheckTextCentreText
             */
            this.CheckTextCentreText.AutoSize = true;
            this.CheckTextCentreText.Location = new System.Drawing.Point(6, 19);
            this.CheckTextCentreText.Name = "CheckTextCentreText";
            this.CheckTextCentreText.Size = new System.Drawing.Size(81, 17);
            this.CheckTextCentreText.TabIndex = 15;
            this.CheckTextCentreText.Text = "Centre Text";
            this.CheckTextCentreText.UseVisualStyleBackColor = true;

            /**
             * LabelTextTextYOffset
             */
            this.LabelTextTextYOffset.AutoSize = true;
            this.LabelTextTextYOffset.Location = new System.Drawing.Point(6, 44);
            this.LabelTextTextYOffset.Name = "LabelTextTextYOffset";
            this.LabelTextTextYOffset.Size = new System.Drawing.Size(60, 13);
            this.LabelTextTextYOffset.TabIndex = 16;
            this.LabelTextTextYOffset.Text = "Offset Top:";

            /**
             * NumericTextTextYOffset
             */
            this.NumericTextTextYOffset.Location = new System.Drawing.Point(72, 42);
            this.NumericTextTextYOffset.Name = "NumericTextTextYOffset";
            this.NumericTextTextYOffset.Size = new System.Drawing.Size(57, 20);
            this.NumericTextTextYOffset.TabIndex = 17;

            /**
             * LabelTextTextXOffset
             */
            this.LabelTextTextXOffset.AutoSize = true;
            this.LabelTextTextXOffset.Location = new System.Drawing.Point(6, 70);
            this.LabelTextTextXOffset.Name = "LabelTextTextXOffset";
            this.LabelTextTextXOffset.Size = new System.Drawing.Size(59, 13);
            this.LabelTextTextXOffset.TabIndex = 18;
            this.LabelTextTextXOffset.Text = "Offset Left:";

            /**
             * NumericTextTextXOffset
             */
            this.NumericTextTextXOffset.Location = new System.Drawing.Point(72, 68);
            this.NumericTextTextXOffset.Name = "NumericTextTextXOffset";
            this.NumericTextTextXOffset.Size = new System.Drawing.Size(57, 20);
            this.NumericTextTextXOffset.TabIndex = 19;


            /**
             * GroupCheckEditor
             */
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckTick);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckTick);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckTick);
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckEdgeNE);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckEdgeNE);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckEdgeNE);
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckEdgeSW);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckEdgeSW);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckEdgeSW);
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckSide);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckSide);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckSide);
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckTop);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckTop);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckTop);
            this.GroupCheckEditor.Controls.Add(this.ButtonCheckBody);
            this.GroupCheckEditor.Controls.Add(this.LabelCheckBody);
            this.GroupCheckEditor.Controls.Add(this.PictureCheckBody);
            this.GroupCheckEditor.Location = new System.Drawing.Point(374, 268);
            this.GroupCheckEditor.Name = "GroupCheckEditor";
            this.GroupCheckEditor.Size = new System.Drawing.Size(424, 125);
            this.GroupCheckEditor.TabIndex = 18;
            this.GroupCheckEditor.TabStop = false;
            this.GroupCheckEditor.Text = "CheckBox Editor";

            /**
             * LabelCheckBody
             */
            this.LabelCheckBody.AutoSize = true;
            this.LabelCheckBody.Location = new System.Drawing.Point(6, 16);
            this.LabelCheckBody.Name = "LabelCheckBody";
            this.LabelCheckBody.Size = new System.Drawing.Size(34, 13);
            this.LabelCheckBody.TabIndex = 1;
            this.LabelCheckBody.Text = "Body:";

            /**
             * PictureCheckBody
             */
            this.PictureCheckBody.Location = new System.Drawing.Point(9, 32);
            this.PictureCheckBody.Name = "PictureCheckBody";
            this.PictureCheckBody.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckBody.TabIndex = 0;
            this.PictureCheckBody.TabStop = false;

            /**
             * ButtonCheckBody
             */
            this.ButtonCheckBody.Location = new System.Drawing.Point(9, 86);
            this.ButtonCheckBody.Name = "ButtonCheckBody";
            this.ButtonCheckBody.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckBody.TabIndex = 2;
            this.ButtonCheckBody.Text = "Set...";
            this.ButtonCheckBody.UseVisualStyleBackColor = true;

            /**
             * LabelCheckTop
             */
            this.LabelCheckTop.AutoSize = true;
            this.LabelCheckTop.Location = new System.Drawing.Point(60, 16);
            this.LabelCheckTop.Name = "LabelCheckTop";
            this.LabelCheckTop.Size = new System.Drawing.Size(29, 13);
            this.LabelCheckTop.TabIndex = 4;
            this.LabelCheckTop.Text = "Top:";

            /**
             * PictureCheckTop
             */
            this.PictureCheckTop.Location = new System.Drawing.Point(63, 32);
            this.PictureCheckTop.Name = "PictureCheckTop";
            this.PictureCheckTop.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckTop.TabIndex = 3;
            this.PictureCheckTop.TabStop = false;

            /**
             * ButtonCheckTop
             */
            this.ButtonCheckTop.Location = new System.Drawing.Point(63, 86);
            this.ButtonCheckTop.Name = "ButtonCheckTop";
            this.ButtonCheckTop.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckTop.TabIndex = 5;
            this.ButtonCheckTop.Text = "Set...";
            this.ButtonCheckTop.UseVisualStyleBackColor = true;

            /**
             * LabelCheckSide
             */
            this.LabelCheckSide.AutoSize = true;
            this.LabelCheckSide.Location = new System.Drawing.Point(114, 16);
            this.LabelCheckSide.Name = "LabelCheckSide";
            this.LabelCheckSide.Size = new System.Drawing.Size(31, 13);
            this.LabelCheckSide.TabIndex = 7;
            this.LabelCheckSide.Text = "Side:";

            /**
             * PictureCheckSide
             */
            this.PictureCheckSide.Location = new System.Drawing.Point(117, 32);
            this.PictureCheckSide.Name = "PictureCheckSide";
            this.PictureCheckSide.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckSide.TabIndex = 6;
            this.PictureCheckSide.TabStop = false;

            /**
             * ButtonCheckSide
             */
            this.ButtonCheckSide.Location = new System.Drawing.Point(117, 86);
            this.ButtonCheckSide.Name = "ButtonCheckSide";
            this.ButtonCheckSide.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckSide.TabIndex = 8;
            this.ButtonCheckSide.Text = "Set...";
            this.ButtonCheckSide.UseVisualStyleBackColor = true;

            /**
             * LabelCheckEdgeSW
             */
            this.LabelCheckEdgeSW.AutoSize = true;
            this.LabelCheckEdgeSW.Location = new System.Drawing.Point(168, 16);
            this.LabelCheckEdgeSW.Name = "LabelCheckEdgeSW";
            this.LabelCheckEdgeSW.Size = new System.Drawing.Size(56, 13);
            this.LabelCheckEdgeSW.TabIndex = 10;
            this.LabelCheckEdgeSW.Text = "Edge SW:";

            /**
             * PictureCheckEdgeSW
             */
            this.PictureCheckEdgeSW.Location = new System.Drawing.Point(171, 32);
            this.PictureCheckEdgeSW.Name = "PictureCheckEdgeSW";
            this.PictureCheckEdgeSW.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckEdgeSW.TabIndex = 9;
            this.PictureCheckEdgeSW.TabStop = false;

            /**
             * ButtonCheckEdgeSW
             */
            this.ButtonCheckEdgeSW.Location = new System.Drawing.Point(171, 86);
            this.ButtonCheckEdgeSW.Name = "ButtonCheckEdgeSW";
            this.ButtonCheckEdgeSW.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckEdgeSW.TabIndex = 11;
            this.ButtonCheckEdgeSW.Text = "Set...";
            this.ButtonCheckEdgeSW.UseVisualStyleBackColor = true;

            /**
             * LabelCheckEdgeNE
             */
            this.LabelCheckEdgeNE.AutoSize = true;
            this.LabelCheckEdgeNE.Location = new System.Drawing.Point(222, 16);
            this.LabelCheckEdgeNE.Name = "LabelCheckEdgeNE";
            this.LabelCheckEdgeNE.Size = new System.Drawing.Size(53, 13);
            this.LabelCheckEdgeNE.TabIndex = 13;
            this.LabelCheckEdgeNE.Text = "Edge NE:";

            /**
             * PictureCheckEdgeNE
             */
            this.PictureCheckEdgeNE.Location = new System.Drawing.Point(225, 32);
            this.PictureCheckEdgeNE.Name = "PictureCheckEdgeNE";
            this.PictureCheckEdgeNE.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckEdgeNE.TabIndex = 12;
            this.PictureCheckEdgeNE.TabStop = false;

            /**
             * ButtonCheckEdgeNE
             */
            this.ButtonCheckEdgeNE.Location = new System.Drawing.Point(225, 86);
            this.ButtonCheckEdgeNE.Name = "ButtonCheckEdgeNE";
            this.ButtonCheckEdgeNE.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckEdgeNE.TabIndex = 14;
            this.ButtonCheckEdgeNE.Text = "Set...";
            this.ButtonCheckEdgeNE.UseVisualStyleBackColor = true;

            /**
             * LabelCheckTick
             */
            this.LabelCheckTick.AutoSize = true;
            this.LabelCheckTick.Location = new System.Drawing.Point(276, 16);
            this.LabelCheckTick.Name = "LabelCheckTick";
            this.LabelCheckTick.Size = new System.Drawing.Size(31, 13);
            this.LabelCheckTick.TabIndex = 16;
            this.LabelCheckTick.Text = "Tick:";

            /**
             * PictureCheckTick
             */
            this.PictureCheckTick.Location = new System.Drawing.Point(279, 32);
            this.PictureCheckTick.Name = "PictureCheckTick";
            this.PictureCheckTick.Size = new System.Drawing.Size(48, 48);
            this.PictureCheckTick.TabIndex = 15;
            this.PictureCheckTick.TabStop = false;

            /**
             * ButtonCheckTick
             */
            this.ButtonCheckTick.Location = new System.Drawing.Point(279, 86);
            this.ButtonCheckTick.Name = "ButtonCheckTick";
            this.ButtonCheckTick.Size = new System.Drawing.Size(48, 23);
            this.ButtonCheckTick.TabIndex = 17;
            this.ButtonCheckTick.Text = "Set...";
            this.ButtonCheckTick.UseVisualStyleBackColor = true;

            #endregion

            this.LastSelectedFont = "Chat Font";

            if (file == "")
            {
                this.Text = "GUIOMETRY - *";
                this.IsUnsaved = true;
            }
            else
            {
                this.Text = "GUIOMETRY - " + Path.GetFileName(file);
            }
        }


        private void UpdateFontTexturePreviews()
        {
            Texture selectedFontTexture;

            switch ((string)this.ComboFont.SelectedItem)
            {
                default:
                case "Chat Font":
                    selectedFontTexture = this.TextureChatFont;
                    break;

                case "Small Font":
                    selectedFontTexture = this.TextureSmallFont;
                    break;

                case "Medium Font":
                    selectedFontTexture = this.TextureMediumFont;
                    break;

                case "Huge Font":
                    selectedFontTexture = this.TextureHugeFont;
                    break;
            }

            if (selectedFontTexture.Source != null && selectedFontTexture.Data != null)
            {
                this.LabelFontTexture.Text = selectedFontTexture.Source.Length > 11 ?
                    "Texture:..." + selectedFontTexture.Source.Substring(selectedFontTexture.Source.Length - 11) :
                    "Texture:" + selectedFontTexture.Source;

                this.TooltipGlobal.SetToolTip(LabelFontTexture, selectedFontTexture.Source);

                // Update character preview here
            }
            else
            {
                this.LabelFontTexture.Text = "Texture:";
                this.TooltipGlobal.SetToolTip(LabelFontTexture, "");
                this.PictureCharPreview.Image = null;
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
                    switch ((string)this.ComboFont.SelectedItem)
                    {
                        default:
                        case "Chat Font":
                            setTextureDialog = new Dialog.SetTexture("Chat Font", this.TextureChatFont);
                            break;

                        case "Small Font":
                            setTextureDialog = new Dialog.SetTexture("Small Font", this.TextureSmallFont);
                            break;

                        case "Medium Font":
                            setTextureDialog = new Dialog.SetTexture("Medium Font", this.TextureMediumFont);
                            break;

                        case "Huge Font":
                            setTextureDialog = new Dialog.SetTexture("Huge Font", this.TextureHugeFont);
                            break;
                    }

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
            string[] currentCharacters = new string[this.ListCharacter.Items.Count];

            for (int i = 0; i < this.ListCharacter.Items.Count; i++)
            {
                currentCharacters[i] = this.ListCharacter.Items[i].ToString();
            }

            Dialog.AddCharacter addCharacterDialog = new Dialog.AddCharacter(currentCharacters);

            if (addCharacterDialog.ShowDialog() == DialogResult.OK)
            {
                this.ListCharacter.Items.Add(addCharacterDialog.Character);
            }
        }


        /// <summary>
        /// [Event] "-" Remove character button clicked.
        /// </summary>
        void ButtonRemoveCharacter_Click(object sender, EventArgs e)
        {
            if (this.ListCharacter.SelectedItem != null)
            {
                if(MessageBox.Show("Are you sure you want to remove this character from this font?", "RozWorld Editor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.ListCharacter.Items.RemoveAt(this.ListCharacter.SelectedIndex);
                }
            }
        }


        /// <summary>
        /// [Event] Font drop down selected item changed.
        /// </summary>
        void ComboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontTexturePreviews();

            // Update the characters listbox
            List<char> characterList;

            if (this.LastSelectedFont != null) // Make sure there is a last picked font
            {
                switch (this.LastSelectedFont)
                {
                    default:
                    case "Chat Font":
                        characterList = this.CharactersChatFont;
                        break;

                    case "Small Font":
                        characterList = this.CharactersSmallFont;
                        break;

                    case "Medium Font":
                        characterList = this.CharactersMediumFont;
                        break;

                    case "Huge Font":
                        characterList = this.CharactersHugeFont;
                        break;
                }

                characterList.Clear();

                foreach (char item in this.ListCharacter.Items)
                {
                    characterList.Add(item);
                }
            }

            switch ((string)this.ComboFont.SelectedItem)
            {
                default:
                case "Chat Font":
                    characterList = this.CharactersChatFont;
                    break;

                case "Small Font":
                    characterList = this.CharactersSmallFont;
                    break;

                case "Medium Font":
                    characterList = this.CharactersMediumFont;
                    break;

                case "Huge Font":
                    characterList = this.CharactersHugeFont;
                    break;
            }

            this.ListCharacter.Items.Clear();

            foreach (char item in characterList)
            {
                this.ListCharacter.Items.Add(item);
            }

            this.LastSelectedFont = (string)this.ComboFont.SelectedItem;
        }
    }
}
