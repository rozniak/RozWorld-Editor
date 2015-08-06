/**
 * RozWorld_Editor.Dialog.SetTextureDialog -- Set Texture Browser Dialog
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
using System.Windows.Forms;

using RozWorld_Editor.DataClasses;

namespace RozWorld_Editor.Dialog
{
    public partial class SetTexture : Form
    {
        private Texture SelectedTexture;
        private Texture TextureReference;


        public SetTexture(string textureTarget, Texture textureReference)
        {
            InitializeComponent();

            this.TextureReference = textureReference;

            this.LabelTagDialogDescription.Text = this.LabelTagDialogDescription.Text.Replace("$NAME", textureTarget);

            this.SelectedTexture = textureReference != null ?
                new Texture(textureReference.Source, textureReference.Data) :
                new Texture(null, null);

            this.LabelSelectedFile.Text = this.SelectedTexture.Source != null ?
                this.SelectedTexture.Source :
                "No File Selected";

            SetPreviewImage();
        }


        /// <summary>
        /// Updates the image seen in the panel with the current selected image.
        /// </summary>
        private void SetPreviewImage()
        {
            if (this.SelectedTexture.Data != null)
            {
                this.PicturePreview.Image = this.SelectedTexture.Data;
                this.PicturePreview.Size = this.SelectedTexture.Data.Size;
                this.PanelPreviewContainer.AutoScrollMinSize = this.PicturePreview.Size;
                this.LabelSelectedFile.Text = this.SelectedTexture.Source;
            }
        }


        /// <summary>
        /// [Event] "Browse..." button clicked.
        /// </summary>
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openDialog.Title = "Select Texture...";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.SelectedTexture.Source = openDialog.FileName;
                this.SelectedTexture.Data = Image.FromFile(openDialog.FileName);

                SetPreviewImage();
            }
        }
        
        
        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.TextureReference.Source = this.SelectedTexture.Source;
            this.TextureReference.Data = this.SelectedTexture.Data;

            this.Close();
        }


        /// <summary>
        /// "Cancel" button clicked.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
