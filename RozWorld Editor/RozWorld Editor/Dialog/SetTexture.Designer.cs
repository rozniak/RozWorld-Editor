namespace RozWorld_Editor.Dialog
{
    partial class SetTexture
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
            this.LabelTagDialogDescription = new System.Windows.Forms.Label();
            this.PictureDialogIcon = new System.Windows.Forms.PictureBox();
            this.LabelTagSelectedFile = new System.Windows.Forms.Label();
            this.LabelSelectedFile = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.LabelTagPreview = new System.Windows.Forms.Label();
            this.PanelPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDialogIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTagDialogDescription
            // 
            this.LabelTagDialogDescription.AutoSize = true;
            this.LabelTagDialogDescription.Location = new System.Drawing.Point(50, 21);
            this.LabelTagDialogDescription.Name = "LabelTagDialogDescription";
            this.LabelTagDialogDescription.Size = new System.Drawing.Size(236, 13);
            this.LabelTagDialogDescription.TabIndex = 0;
            this.LabelTagDialogDescription.Text = "Browse for a texture to use for $NAME previews.";
            // 
            // PictureDialogIcon
            // 
            this.PictureDialogIcon.Image = global::RozWorld_Editor.Properties.Resources.SearchBigIcon;
            this.PictureDialogIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureDialogIcon.Name = "PictureDialogIcon";
            this.PictureDialogIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureDialogIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureDialogIcon.TabIndex = 1;
            this.PictureDialogIcon.TabStop = false;
            // 
            // LabelTagSelectedFile
            // 
            this.LabelTagSelectedFile.AutoSize = true;
            this.LabelTagSelectedFile.Location = new System.Drawing.Point(9, 57);
            this.LabelTagSelectedFile.Name = "LabelTagSelectedFile";
            this.LabelTagSelectedFile.Size = new System.Drawing.Size(71, 13);
            this.LabelTagSelectedFile.TabIndex = 2;
            this.LabelTagSelectedFile.Text = "Selected File:";
            // 
            // LabelSelectedFile
            // 
            this.LabelSelectedFile.AutoSize = true;
            this.LabelSelectedFile.Location = new System.Drawing.Point(9, 73);
            this.LabelSelectedFile.Name = "LabelSelectedFile";
            this.LabelSelectedFile.Size = new System.Drawing.Size(35, 13);
            this.LabelSelectedFile.TabIndex = 3;
            this.LabelSelectedFile.Text = "$FILE";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(12, 89);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 4;
            this.ButtonBrowse.Text = "Browse...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            // 
            // LabelTagPreview
            // 
            this.LabelTagPreview.AutoSize = true;
            this.LabelTagPreview.Location = new System.Drawing.Point(9, 125);
            this.LabelTagPreview.Name = "LabelTagPreview";
            this.LabelTagPreview.Size = new System.Drawing.Size(48, 13);
            this.LabelTagPreview.TabIndex = 5;
            this.LabelTagPreview.Text = "Preview:";
            // 
            // PanelPreview
            // 
            this.PanelPreview.Location = new System.Drawing.Point(12, 141);
            this.PanelPreview.Name = "PanelPreview";
            this.PanelPreview.Size = new System.Drawing.Size(379, 178);
            this.PanelPreview.TabIndex = 6;
            // 
            // SetTexture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 331);
            this.Controls.Add(this.PanelPreview);
            this.Controls.Add(this.LabelTagPreview);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.LabelSelectedFile);
            this.Controls.Add(this.LabelTagSelectedFile);
            this.Controls.Add(this.PictureDialogIcon);
            this.Controls.Add(this.LabelTagDialogDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetTexture";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Texture...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetTextureDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureDialogIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTagDialogDescription;
        private System.Windows.Forms.PictureBox PictureDialogIcon;
        private System.Windows.Forms.Label LabelTagSelectedFile;
        private System.Windows.Forms.Label LabelSelectedFile;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Label LabelTagPreview;
        private System.Windows.Forms.Panel PanelPreview;
    }
}