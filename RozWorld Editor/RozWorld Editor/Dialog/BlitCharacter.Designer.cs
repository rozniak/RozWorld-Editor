﻿namespace RozWorld_Editor.Dialog
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
            this.components = new System.ComponentModel.Container();
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
            this.NumericBlitDestinationY = new System.Windows.Forms.NumericUpDown();
            this.LabelBlitDestinationY = new System.Windows.Forms.Label();
            this.NumericBlitDestinationX = new System.Windows.Forms.NumericUpDown();
            this.LabelBlitDestinationX = new System.Windows.Forms.Label();
            this.LabelBlitDestination = new System.Windows.Forms.Label();
            this.TimerPreviewSelection = new System.Windows.Forms.Timer(this.components);
            this.PanelPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitDestinationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitDestinationX)).BeginInit();
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
            this.PicturePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicturePreview.Location = new System.Drawing.Point(0, 0);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(268, 322);
            this.PicturePreview.TabIndex = 0;
            this.PicturePreview.TabStop = false;
            this.PicturePreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicturePreview_MouseDown);
            this.PicturePreview.MouseLeave += new System.EventHandler(this.PicturePreview_MouseLeave);
            this.PicturePreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicturePreview_MouseUp);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(375, 311);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(294, 311);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
            this.LabelBlitOrigin.ForeColor = System.Drawing.Color.Red;
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
            this.NumericBlitOriginX.ValueChanged += new System.EventHandler(this.NumericBlitOriginX_ValueChanged);
            // 
            // NumericBlitOriginY
            // 
            this.NumericBlitOriginY.Location = new System.Drawing.Point(395, 220);
            this.NumericBlitOriginY.Name = "NumericBlitOriginY";
            this.NumericBlitOriginY.Size = new System.Drawing.Size(55, 20);
            this.NumericBlitOriginY.TabIndex = 10;
            this.NumericBlitOriginY.ValueChanged += new System.EventHandler(this.NumericBlitOriginY_ValueChanged);
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
            // NumericBlitDestinationY
            // 
            this.NumericBlitDestinationY.Location = new System.Drawing.Point(395, 267);
            this.NumericBlitDestinationY.Name = "NumericBlitDestinationY";
            this.NumericBlitDestinationY.Size = new System.Drawing.Size(55, 20);
            this.NumericBlitDestinationY.TabIndex = 15;
            this.NumericBlitDestinationY.ValueChanged += new System.EventHandler(this.NumericBlitDestinationY_ValueChanged);
            // 
            // LabelBlitDestinationY
            // 
            this.LabelBlitDestinationY.AutoSize = true;
            this.LabelBlitDestinationY.Location = new System.Drawing.Point(372, 269);
            this.LabelBlitDestinationY.Name = "LabelBlitDestinationY";
            this.LabelBlitDestinationY.Size = new System.Drawing.Size(17, 13);
            this.LabelBlitDestinationY.TabIndex = 14;
            this.LabelBlitDestinationY.Text = "Y:";
            // 
            // NumericBlitDestinationX
            // 
            this.NumericBlitDestinationX.Location = new System.Drawing.Point(314, 267);
            this.NumericBlitDestinationX.Name = "NumericBlitDestinationX";
            this.NumericBlitDestinationX.Size = new System.Drawing.Size(55, 20);
            this.NumericBlitDestinationX.TabIndex = 13;
            this.NumericBlitDestinationX.ValueChanged += new System.EventHandler(this.NumericBlitDestinationX_ValueChanged);
            // 
            // LabelBlitDestinationX
            // 
            this.LabelBlitDestinationX.AutoSize = true;
            this.LabelBlitDestinationX.Location = new System.Drawing.Point(291, 269);
            this.LabelBlitDestinationX.Name = "LabelBlitDestinationX";
            this.LabelBlitDestinationX.Size = new System.Drawing.Size(17, 13);
            this.LabelBlitDestinationX.TabIndex = 12;
            this.LabelBlitDestinationX.Text = "X:";
            // 
            // LabelBlitDestination
            // 
            this.LabelBlitDestination.AutoSize = true;
            this.LabelBlitDestination.ForeColor = System.Drawing.Color.Blue;
            this.LabelBlitDestination.Location = new System.Drawing.Point(291, 251);
            this.LabelBlitDestination.Name = "LabelBlitDestination";
            this.LabelBlitDestination.Size = new System.Drawing.Size(97, 13);
            this.LabelBlitDestination.TabIndex = 11;
            this.LabelBlitDestination.Text = "Blitting Destination:";
            // 
            // TimerPreviewSelection
            // 
            this.TimerPreviewSelection.Interval = 5;
            this.TimerPreviewSelection.Tick += new System.EventHandler(this.TimerPreviewSelection_Tick);
            // 
            // BlitCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.NumericBlitDestinationY);
            this.Controls.Add(this.LabelBlitDestinationY);
            this.Controls.Add(this.NumericBlitDestinationX);
            this.Controls.Add(this.LabelBlitDestinationX);
            this.Controls.Add(this.LabelBlitDestination);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlitCharacter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blit Character...";
            this.TopMost = true;
            this.PanelPreviewContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitDestinationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlitDestinationX)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NumericBlitDestinationY;
        private System.Windows.Forms.Label LabelBlitDestinationY;
        private System.Windows.Forms.NumericUpDown NumericBlitDestinationX;
        private System.Windows.Forms.Label LabelBlitDestinationX;
        private System.Windows.Forms.Label LabelBlitDestination;
        private System.Windows.Forms.Timer TimerPreviewSelection;
    }
}