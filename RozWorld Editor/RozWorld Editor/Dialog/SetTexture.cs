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

namespace RozWorld_Editor.Dialog
{
    public partial class SetTexture : Form
    {
        private Tuple<string, Image> TextureReference;


        public SetTexture(string textureTarget, Tuple<string, Image> textureReference)
        {
            InitializeComponent();

            this.TextureReference = textureReference;

            this.LabelTagDialogDescription.Text = this.LabelTagDialogDescription.Text.Replace("$NAME", textureTarget);
            this.LabelSelectedFile.Text = "No File Selected";

            if (textureReference != null)
            {
                if (textureReference.Item1 != null)
                {
                    this.LabelSelectedFile.Text = textureReference.Item1;
                }

                if (textureReference.Item2 != null)
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
            // TODO: Finish this
        }


        private void SetTextureDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
