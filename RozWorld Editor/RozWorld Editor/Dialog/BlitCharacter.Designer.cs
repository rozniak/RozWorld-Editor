namespace RozWorld_Editor.Dialog
{
    partial class BlitCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlitCharacter));
            this.PanelPreviewContainer = new System.Windows.Forms.Panel();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelTagDialogDescription = new System.Windows.Forms.Label();
            this.LabelSelectionMode = new System.Windows.Forms.Label();
            this.ComboSelectionMode = new System.Windows.Forms.ComboBox();
            this.LabelBlitOrigin = new System.Windows.Forms.Label();
            this.LabelBlitOriginX = new System.Windows.Forms.Label();
            this.NumericBlitOriginX = new System.Windows.Forms.NumericUpDown();
            this.NumericBlitOriginY = new System.Windows.Forms.NumericUpDown();
            this.LabelBlitOriginY = new System.Windows.Forms.Label();
            this.NumericBlittingDestinationY = new System.Windows.Forms.NumericUpDown();
            this.LabelBlittingDestinationY = new System.Windows.Forms.Label();
            this.NumericBlittingDestinationX = new System.Windows.Forms.NumericUpDown();
            this.LabelBlittingDestinationX = new System.Windows.Forms.Label();
            this.LabelBittingDestination = new System.Windows.Forms.Label();
            this.PanelPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlittingDestinationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlittingDestinationX)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPreviewContainer
            // 
            this.PanelPreviewContainer.Controls.Add(this.PicturePreview);
            this.PanelPreviewContainer.Location = new System.Drawing.Point(12, 12);
            this.PanelPreviewContainer.Name = "PanelPreviewContainer";
            this.PanelPreviewContainer.Size = new System.Drawing.Size(268, 322);
            this.PanelPreviewContainer.TabIndex = 0;
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.White;
            this.PicturePreview.Location = new System.Drawing.Point(0, 0);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(268, 322);
            this.PicturePreview.TabIndex = 0;
            this.PicturePreview.TabStop = false;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(375, 311);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(294, 311);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // LabelTagDialogDescription
            // 
            this.LabelTagDialogDescription.Location = new System.Drawing.Point(291, 12);
            this.LabelTagDialogDescription.Name = "LabelTagDialogDescription";
            this.LabelTagDialogDescription.Size = new System.Drawing.Size(159, 140);
            this.LabelTagDialogDescription.TabIndex = 3;
            this.LabelTagDialogDescription.Text = resources.GetString("LabelTagDialogDescription.Text");
            // 
            // LabelSelectionMode
            // 
            this.LabelSelectionMode.AutoSize = true;
            this.LabelSelectionMode.Location = new System.Drawing.Point(291, 155);
            this.LabelSelectionMode.Name = "LabelSelectionMode";
            this.LabelSelectionMode.Size = new System.Drawing.Size(84, 13);
            this.LabelSelectionMode.TabIndex = 4;
            this.LabelSelectionMode.Text = "Selection Mode:";
            // 
            // ComboSelectionMode
            // 
            this.ComboSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSelectionMode.FormattingEnabled = true;
            this.ComboSelectionMode.Items.AddRange(new object[] {
            "Blit Origin Point",
            "Blit Destination Point"});
            this.ComboSelectionMode.Location = new System.Drawing.Point(294, 171);
            this.ComboSelectionMode.Name = "ComboSelectionMode";
            this.ComboSelectionMode.Size = new System.Drawing.Size(156, 21);
            this.ComboSelectionMode.TabIndex = 5;
            // 
            // LabelBlitOrigin
            // 
            this.LabelBlitOrigin.AutoSize = true;
            this.LabelBlitOrigin.Location = new System.Drawing.Point(291, 204);
            this.LabelBlitOrigin.Name = "LabelBlitOrigin";
            this.LabelBlitOrigin.Size = new System.Drawing.Size(71, 13);
            this.LabelBlitOrigin.TabIndex = 6;
            this.LabelBlitOrigin.Text = "Blitting Origin:";
            // 
            // LabelBlitOriginX
            // 
            this.LabelBlitOriginX.AutoSize = true;
            this.LabelBlitOriginX.Location = new System.Drawing.Point(291, 222);
            this.LabelBlitOriginX.Name = "LabelBlitOriginX";
            this.LabelBlitOriginX.Size = new System.Drawing.Size(17, 13);
            this.LabelBlitOriginX.TabIndex = 7;
            this.LabelBlitOriginX.Text = "X:";
            // 
            // NumericBlitOriginX
            // 
            this.NumericBlitOriginX.Location = new System.Drawing.Point(314, 220);
            this.NumericBlitOriginX.Name = "NumericBlitOriginX";
            this.NumericBlitOriginX.Size = new System.Drawing.Size(55, 20);
            this.NumericBlitOriginX.TabIndex = 8;
            // 
            // NumericBlitOriginY
            // 
            this.NumericBlitOriginY.Location = new System.Drawing.Point(395, 220);
            this.NumericBlitOriginY.Name = "NumericBlitOriginY";
            this.NumericBlitOriginY.Size = new System.Drawing.Size(55, 20);
            this.NumericBlitOriginY.TabIndex = 10;
            // 
            // LabelBlitOriginY
            // 
            this.LabelBlitOriginY.AutoSize = true;
            this.LabelBlitOriginY.Location = new System.Drawing.Point(372, 222);
            this.LabelBlitOriginY.Name = "LabelBlitOriginY";
            this.LabelBlitOriginY.Size = new System.Drawing.Size(17, 13);
            this.LabelBlitOriginY.TabIndex = 9;
            this.LabelBlitOriginY.Text = "Y:";
            // 
            // NumericBlittingDestinationY
            // 
            this.NumericBlittingDestinationY.Location = new System.Drawing.Point(395, 267);
            this.NumericBlittingDestinationY.Name = "NumericBlittingDestinationY";
            this.NumericBlittingDestinationY.Size = new System.Drawing.Size(55, 20);
            this.NumericBlittingDestinationY.TabIndex = 15;
            // 
            // LabelBlittingDestinationY
            // 
            this.LabelBlittingDestinationY.AutoSize = true;
            this.LabelBlittingDestinationY.Location = new System.Drawing.Point(372, 269);
            this.LabelBlittingDestinationY.Name = "LabelBlittingDestinationY";
            this.LabelBlittingDestinationY.Size = new System.Drawing.Size(17, 13);
            this.LabelBlittingDestinationY.TabIndex = 14;
            this.LabelBlittingDestinationY.Text = "Y:";
            // 
            // NumericBlittingDestinationX
            // 
            this.NumericBlittingDestinationX.Location = new System.Drawing.Point(314, 267);
            this.NumericBlittingDestinationX.Name = "NumericBlittingDestinationX";
            this.NumericBlittingDestinationX.Size = new System.Drawing.Size(55, 20);
            this.NumericBlittingDestinationX.TabIndex = 13;
            // 
            // LabelBlittingDestinationX
            // 
            this.LabelBlittingDestinationX.AutoSize = true;
            this.LabelBlittingDestinationX.Location = new System.Drawing.Point(291, 269);
            this.LabelBlittingDestinationX.Name = "LabelBlittingDestinationX";
            this.LabelBlittingDestinationX.Size = new System.Drawing.Size(17, 13);
            this.LabelBlittingDestinationX.TabIndex = 12;
            this.LabelBlittingDestinationX.Text = "X:";
            // 
            // LabelBittingDestination
            // 
            this.LabelBittingDestination.AutoSize = true;
            this.LabelBittingDestination.Location = new System.Drawing.Point(291, 251);
            this.LabelBittingDestination.Name = "LabelBittingDestination";
            this.LabelBittingDestination.Size = new System.Drawing.Size(97, 13);
            this.LabelBittingDestination.TabIndex = 11;
            this.LabelBittingDestination.Text = "Blitting Destination:";
            // 
            // BlitCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.NumericBlittingDestinationY);
            this.Controls.Add(this.LabelBlittingDestinationY);
            this.Controls.Add(this.NumericBlittingDestinationX);
            this.Controls.Add(this.LabelBlittingDestinationX);
            this.Controls.Add(this.LabelBittingDestination);
            this.Controls.Add(this.NumericBlitOriginY);
            this.Controls.Add(this.LabelBlitOriginY);
            this.Controls.Add(this.NumericBlitOriginX);
            this.Controls.Add(this.LabelBlitOriginX);
            this.Controls.Add(this.LabelBlitOrigin);
            this.Controls.Add(this.ComboSelectionMode);
            this.Controls.Add(this.LabelSelectionMode);
            this.Controls.Add(this.LabelTagDialogDescription);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.PanelPreviewContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlitCharacter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Blit Character...";
            this.TopMost = true;
            this.PanelPreviewContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlittingDestinationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlittingDestinationX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelPreviewContainer;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelTagDialogDescription;
        private System.Windows.Forms.Label LabelSelectionMode;
        private System.Windows.Forms.ComboBox ComboSelectionMode;
        private System.Windows.Forms.Label LabelBlitOrigin;
        private System.Windows.Forms.Label LabelBlitOriginX;
        private System.Windows.Forms.NumericUpDown NumericBlitOriginX;
        private System.Windows.Forms.NumericUpDown NumericBlitOriginY;
        private System.Windows.Forms.Label LabelBlitOriginY;
        private System.Windows.Forms.NumericUpDown NumericBlittingDestinationY;
        private System.Windows.Forms.Label LabelBlittingDestinationY;
        private System.Windows.Forms.NumericUpDown NumericBlittingDestinationX;
        private System.Windows.Forms.Label LabelBlittingDestinationX;
        private System.Windows.Forms.Label LabelBittingDestination;
    }
}