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
            this.PanelPreviewContainer = new System.Windows.Forms.Panel();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDialogIcon)).BeginInit();
            this.PanelPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
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
            this.LabelSelectedFile.AutoEllipsis = true;
            this.LabelSelectedFile.Location = new System.Drawing.Point(9, 72);
            this.LabelSelectedFile.Name = "LabelSelectedFile";
            this.LabelSelectedFile.Size = new System.Drawing.Size(382, 16);
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
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
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
            // PanelPreviewContainer
            // 
            this.PanelPreviewContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelPreviewContainer.Controls.Add(this.PicturePreview);
            this.PanelPreviewContainer.Location = new System.Drawing.Point(12, 141);
            this.PanelPreviewContainer.Name = "PanelPreviewContainer";
            this.PanelPreviewContainer.Size = new System.Drawing.Size(379, 178);
            this.PanelPreviewContainer.TabIndex = 6;
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.White;
            this.PicturePreview.Location = new System.Drawing.Point(0, 0);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(379, 178);
            this.PicturePreview.TabIndex = 0;
            this.PicturePreview.TabStop = false;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(316, 89);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(235, 89);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SetTexture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 331);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.PanelPreviewContainer);
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureDialogIcon)).EndInit();
            this.PanelPreviewContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
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
        private System.Windows.Forms.Panel PanelPreviewContainer;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}