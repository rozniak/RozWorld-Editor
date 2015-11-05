namespace RozWorld_Editor.Dialog
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelAboutSummary = new System.Windows.Forms.Label();
            this.PictureEditorLogo = new System.Windows.Forms.PictureBox();
            this.LinkOddmatics = new System.Windows.Forms.LinkLabel();
            this.LabelAboutLicence = new System.Windows.Forms.Label();
            this.LinkRepository = new System.Windows.Forms.LinkLabel();
            this.LinkLicence = new System.Windows.Forms.LinkLabel();
            this.LabelAlphaWarning = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAboutSummary
            // 
            this.LabelAboutSummary.AutoSize = true;
            this.LabelAboutSummary.Location = new System.Drawing.Point(114, 21);
            this.LabelAboutSummary.Name = "LabelAboutSummary";
            this.LabelAboutSummary.Size = new System.Drawing.Size(247, 52);
            this.LabelAboutSummary.TabIndex = 1;
            this.LabelAboutSummary.Text = "RozWorld Editor for Windows (Version $VERSION)\r\nProgramming and Design by Rory Fe" +
    "well (rozniak)\r\n\r\nOddmatics 2015";
            // 
            // PictureEditorLogo
            // 
            this.PictureEditorLogo.Image = global::RozWorld_Editor.Properties.Resources.EditorIconLogo;
            this.PictureEditorLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureEditorLogo.Name = "PictureEditorLogo";
            this.PictureEditorLogo.Size = new System.Drawing.Size(96, 96);
            this.PictureEditorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureEditorLogo.TabIndex = 0;
            this.PictureEditorLogo.TabStop = false;
            // 
            // LinkOddmatics
            // 
            this.LinkOddmatics.AutoSize = true;
            this.LinkOddmatics.Location = new System.Drawing.Point(114, 73);
            this.LinkOddmatics.Name = "LinkOddmatics";
            this.LinkOddmatics.Size = new System.Drawing.Size(128, 13);
            this.LinkOddmatics.TabIndex = 2;
            this.LinkOddmatics.TabStop = true;
            this.LinkOddmatics.Text = "http://www.oddmatics.uk";
            this.LinkOddmatics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkOddmatics_LinkClicked);
            // 
            // LabelAboutLicence
            // 
            this.LabelAboutLicence.AutoSize = true;
            this.LabelAboutLicence.Location = new System.Drawing.Point(114, 114);
            this.LabelAboutLicence.Name = "LabelAboutLicence";
            this.LabelAboutLicence.Size = new System.Drawing.Size(358, 65);
            this.LabelAboutLicence.TabIndex = 3;
            this.LabelAboutLicence.Text = "All code and content assets of this program are freeware and open-source.\r\n\r\n\r\nTh" +
    "is project is under the Creative Commons Attribution-NonCommercial 4.0\r\nInternat" +
    "ional licence. ";
            // 
            // LinkRepository
            // 
            this.LinkRepository.AutoSize = true;
            this.LinkRepository.Location = new System.Drawing.Point(114, 127);
            this.LinkRepository.Name = "LinkRepository";
            this.LinkRepository.Size = new System.Drawing.Size(216, 13);
            this.LinkRepository.TabIndex = 2;
            this.LinkRepository.TabStop = true;
            this.LinkRepository.Text = "https://github.com/rozniak/RozWorld-Editor";
            this.LinkRepository.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepository_LinkClicked);
            // 
            // LinkLicence
            // 
            this.LinkLicence.AutoSize = true;
            this.LinkLicence.Location = new System.Drawing.Point(114, 179);
            this.LinkLicence.Name = "LinkLicence";
            this.LinkLicence.Size = new System.Drawing.Size(284, 13);
            this.LinkLicence.TabIndex = 2;
            this.LinkLicence.TabStop = true;
            this.LinkLicence.Text = "http://creativecommons.org/licenses/by-nc/4.0/legalcode";
            this.LinkLicence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLicence_LinkClicked);
            // 
            // LabelAlphaWarning
            // 
            this.LabelAlphaWarning.AutoSize = true;
            this.LabelAlphaWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlphaWarning.Location = new System.Drawing.Point(114, 220);
            this.LabelAlphaWarning.Name = "LabelAlphaWarning";
            this.LabelAlphaWarning.Size = new System.Drawing.Size(382, 26);
            this.LabelAlphaWarning.TabIndex = 4;
            this.LabelAlphaWarning.Text = "This is a development build of the RozWorld Editor, some features\r\nmay remain uni" +
    "mplemented or broken.";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(419, 296);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 331);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.LabelAlphaWarning);
            this.Controls.Add(this.LinkLicence);
            this.Controls.Add(this.LinkRepository);
            this.Controls.Add(this.LabelAboutLicence);
            this.Controls.Add(this.LinkOddmatics);
            this.Controls.Add(this.LabelAboutSummary);
            this.Controls.Add(this.PictureEditorLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditorLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureEditorLogo;
        private System.Windows.Forms.Label LabelAboutSummary;
        private System.Windows.Forms.LinkLabel LinkOddmatics;
        private System.Windows.Forms.Label LabelAboutLicence;
        private System.Windows.Forms.LinkLabel LinkRepository;
        private System.Windows.Forms.LinkLabel LinkLicence;
        private System.Windows.Forms.Label LabelAlphaWarning;
        private System.Windows.Forms.Button ButtonOK;
    }
}