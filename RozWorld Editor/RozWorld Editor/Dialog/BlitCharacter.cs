/**
 * RozWorld_Editor.Dialog.BlitCharacter -- Character Blitting Dialog
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using RozWorld_Editor.DataClasses;

namespace RozWorld_Editor.Dialog
{
    public partial class BlitCharacter : Form
    {
        private CharacterInfo CharInfoEditing;
        private CharacterInfo CharInfoReference;

        private Pen PenBlitOrigin;
        private Pen PenBlitDestination;
        private Graphics GFX;


        public BlitCharacter(char charTarget, CharacterInfo charInfoReference, Image texture)
        {
            InitializeComponent();

            CharInfoReference = charInfoReference;

            ComboSelectionMode.SelectedIndex = 0;
            LabelTagDialogDescription.Text = LabelTagDialogDescription.Text.Replace("$CHAR", charTarget.ToString());

            CharInfoEditing = charInfoReference != null ?
                charInfoReference.Clone() :
                new CharacterInfo();

            PicturePreview.BackgroundImage = texture;
            PicturePreview.Size = texture.Size;
            PanelPreviewContainer.AutoScrollMinSize = texture.Size;

            PicturePreview.Image = new Bitmap(texture.Size.Width, texture.Size.Height);
            GFX = Graphics.FromImage(PicturePreview.Image);
        }


        private void UpdatePreview()
        {
            Point blitOrigin = CharInfoEditing.BlitOrigin;
            Point blitDestination = CharInfoEditing.BlitDestination;
            Size textureSize = PicturePreview.BackgroundImage.Size;

            GFX.Clear(Color.Transparent);

            GFX.DrawLine(PenBlitOrigin,
                new Point(blitOrigin.X, 0),
                new Point(blitOrigin.X, textureSize.Height));
            GFX.DrawLine(PenBlitOrigin,
                new Point(0, blitOrigin.Y),
                new Point(textureSize.Width, blitOrigin.Y));

            GFX.DrawLine(PenBlitDestination,
                new Point(blitDestination.X, 0),
                new Point(blitDestination.X, textureSize.Height));
            GFX.DrawLine(PenBlitDestination,
                new Point(0, blitDestination.Y),
                new Point(textureSize.Width, blitDestination.Y));
        }


        /// <summary>
        /// [Event] "Cancel" button clicked.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CharInfoReference.AssignBlitting(CharInfoEditing.BlitOrigin,
                CharInfoEditing.BlitDestination);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// [Event] Manual selection preview picture mouse down.
        /// </summary>
        private void PicturePreview_MouseDown(object sender, MouseEventArgs e)
        {
            TimerPreviewSelection.Enabled = true;
            TimerPreviewSelection.Start();
        }


        /// <summary>
        /// [Event] Manual selection preview picture mouse leave.
        /// </summary>
        private void PicturePreview_MouseLeave(object sender, EventArgs e)
        {
            TimerPreviewSelection.Stop();
        }


        /// <summary>
        /// [Event] Manual selection preview picture mouse up.
        /// </summary>
        private void PicturePreview_MouseUp(object sender, MouseEventArgs e)
        {
            TimerPreviewSelection.Stop();
        }


        /// <summary>
        /// [Event] Manual preview selection timer tick.
        /// </summary>
        private void TimerPreviewSelection_Tick(object sender, EventArgs e)
        {
            UpdatePreview();

            
        }
    }
}
