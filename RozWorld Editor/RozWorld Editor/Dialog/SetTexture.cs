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
        private Texture TextureReference;


        public SetTexture(string textureTarget, Texture textureReference)
        {
            InitializeComponent();

            this.TextureReference = textureReference;

            this.LabelTagDialogDescription.Text = this.LabelTagDialogDescription.Text.Replace("$NAME", textureTarget);
            this.LabelSelectedFile.Text = "No File Selected";

            if (textureReference != null)
            {
                if (textureReference.Source != null)
                {
                    this.LabelSelectedFile.Text = textureReference.Source;
                }

                if (textureReference.Data != null)
                {
                    SetPreviewPanelImage();
                }
            }
        }


        /// <summary>
        /// Updates the image seen in the panel with the current selected image.
        /// </summary>
        private void SetPreviewPanelImage()
        {
            if (this.TextureReference.Data != null)
            {
                this.PanelPreview.AutoScrollMinSize = this.TextureReference.Data.Size;
                this.PanelPreview.BackgroundImage = this.TextureReference.Data;
            }
        }


        private void SetTextureDialog_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openDialog.Title = "Select Texture...";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.TextureReference.Source = openDialog.FileName;
                this.TextureReference.Data = Image.FromFile(openDialog.FileName);

                SetPreviewPanelImage();
            }
        }
    }
}
