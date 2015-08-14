namespace RozWorld_Editor.Dialog
{
    partial class EditElement
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
            this.LabelTagSelectedFile = new System.Windows.Forms.Label();
            this.LabelSelectedFile = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupDetails = new System.Windows.Forms.GroupBox();
            this.NumericYOffset = new System.Windows.Forms.NumericUpDown();
            this.LabelYOffset = new System.Windows.Forms.Label();
            this.NumericXOffset = new System.Windows.Forms.NumericUpDown();
            this.LabelXOffset = new System.Windows.Forms.Label();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.GroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTagDialogDescription
            // 
            this.LabelTagDialogDescription.Location = new System.Drawing.Point(12, 9);
            this.LabelTagDialogDescription.Name = "LabelTagDialogDescription";
            this.LabelTagDialogDescription.Size = new System.Drawing.Size(359, 44);
            this.LabelTagDialogDescription.TabIndex = 0;
            this.LabelTagDialogDescription.Text = "Edit the texture details of the \'$ELEMENT\' GUI element. $EXTRAINFO";
            // 
            // LabelTagSelectedFile
            // 
            this.LabelTagSelectedFile.AutoSize = true;
            this.LabelTagSelectedFile.Location = new System.Drawing.Point(12, 53);
            this.LabelTagSelectedFile.Name = "LabelTagSelectedFile";
            this.LabelTagSelectedFile.Size = new System.Drawing.Size(71, 13);
            this.LabelTagSelectedFile.TabIndex = 1;
            this.LabelTagSelectedFile.Text = "Selected File:";
            // 
            // LabelSelectedFile
            // 
            this.LabelSelectedFile.AutoEllipsis = true;
            this.LabelSelectedFile.Location = new System.Drawing.Point(12, 68);
            this.LabelSelectedFile.Name = "LabelSelectedFile";
            this.LabelSelectedFile.Size = new System.Drawing.Size(359, 16);
            this.LabelSelectedFile.TabIndex = 2;
            this.LabelSelectedFile.Text = "$FILE";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(12, 87);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 3;
            this.ButtonBrowse.Text = "Browse...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(296, 87);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(215, 87);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // GroupDetails
            // 
            this.GroupDetails.Controls.Add(this.NumericYOffset);
            this.GroupDetails.Controls.Add(this.LabelYOffset);
            this.GroupDetails.Controls.Add(this.NumericXOffset);
            this.GroupDetails.Controls.Add(this.LabelXOffset);
            this.GroupDetails.Location = new System.Drawing.Point(12, 116);
            this.GroupDetails.Name = "GroupDetails";
            this.GroupDetails.Size = new System.Drawing.Size(75, 107);
            this.GroupDetails.TabIndex = 6;
            this.GroupDetails.TabStop = false;
            this.GroupDetails.Text = "Details";
            // 
            // NumericYOffset
            // 
            this.NumericYOffset.Location = new System.Drawing.Point(9, 75);
            this.NumericYOffset.Name = "NumericYOffset";
            this.NumericYOffset.Size = new System.Drawing.Size(56, 20);
            this.NumericYOffset.TabIndex = 10;
            this.NumericYOffset.ValueChanged += new System.EventHandler(this.NumericYOffset_ValueChanged);
            // 
            // LabelYOffset
            // 
            this.LabelYOffset.AutoSize = true;
            this.LabelYOffset.Location = new System.Drawing.Point(6, 59);
            this.LabelYOffset.Name = "LabelYOffset";
            this.LabelYOffset.Size = new System.Drawing.Size(45, 13);
            this.LabelYOffset.TabIndex = 9;
            this.LabelYOffset.Text = "Y Offset";
            // 
            // NumericXOffset
            // 
            this.NumericXOffset.Location = new System.Drawing.Point(9, 32);
            this.NumericXOffset.Name = "NumericXOffset";
            this.NumericXOffset.Size = new System.Drawing.Size(56, 20);
            this.NumericXOffset.TabIndex = 8;
            this.NumericXOffset.ValueChanged += new System.EventHandler(this.NumericXOffset_ValueChanged);
            // 
            // LabelXOffset
            // 
            this.LabelXOffset.AutoSize = true;
            this.LabelXOffset.Location = new System.Drawing.Point(6, 16);
            this.LabelXOffset.Name = "LabelXOffset";
            this.LabelXOffset.Size = new System.Drawing.Size(45, 13);
            this.LabelXOffset.TabIndex = 7;
            this.LabelXOffset.Text = "X Offset";
            // 
            // PicturePreview
            // 
            this.PicturePreview.Location = new System.Drawing.Point(93, 116);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(278, 107);
            this.PicturePreview.TabIndex = 7;
            this.PicturePreview.TabStop = false;
            // 
            // EditElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 239);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.GroupDetails);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.LabelSelectedFile);
            this.Controls.Add(this.LabelTagSelectedFile);
            this.Controls.Add(this.LabelTagDialogDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditElement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit GUI Element...";
            this.TopMost = true;
            this.GroupDetails.ResumeLayout(false);
            this.GroupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTagDialogDescription;
        private System.Windows.Forms.Label LabelTagSelectedFile;
        private System.Windows.Forms.Label LabelSelectedFile;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.GroupBox GroupDetails;
        private System.Windows.Forms.Label LabelXOffset;
        private System.Windows.Forms.NumericUpDown NumericYOffset;
        private System.Windows.Forms.Label LabelYOffset;
        private System.Windows.Forms.NumericUpDown NumericXOffset;
        private System.Windows.Forms.PictureBox PicturePreview;
    }
}