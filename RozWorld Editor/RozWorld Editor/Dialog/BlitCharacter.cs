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
        private Brush BrushBlitFill;
        private Graphics GFX;

        private bool LegalValueInput;


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

            PenBlitOrigin = new Pen(Color.Red);
            PenBlitDestination = new Pen(Color.Blue);
            BrushBlitFill = new SolidBrush(Color.FromArgb(100, Color.Magenta));

            NumericBlitOriginX.Maximum = texture.Size.Width;
            NumericBlitOriginY.Maximum = texture.Size.Height;
            NumericBlitDestinationX.Maximum = texture.Size.Width;
            NumericBlitDestinationY.Maximum = texture.Size.Height;

            try
            {
                NumericBlitOriginX.Value = charInfoReference.BlitOrigin.X;
                NumericBlitOriginY.Value = charInfoReference.BlitOrigin.Y;
                NumericBlitDestinationX.Value = charInfoReference.BlitDestination.X;
                NumericBlitDestinationY.Value = charInfoReference.BlitDestination.Y;
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                // The blitting coordinates are invalid, alert the user
                if (MessageBox.Show("The blitting coordinates appear to be out of range of this texture, this may happen if the texture selected is not the same as the original used to create these coordinates.\n\nWould you like to continue and reset the coordinates anyway?",
                    "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NumericBlitOriginX.Value = 0;
                    NumericBlitOriginY.Value = 0;
                    NumericBlitDestinationX.Value = 0;
                    NumericBlitDestinationY.Value = 0;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            PicturePreview.Image = new Bitmap(texture.Size.Width, texture.Size.Height);

            LegalValueInput = true;

            UpdatePreview();
        }


        /// <summary>
        /// Updates the texture blitting preview box.
        /// </summary>
        private void UpdatePreview()
        {
            Point blitOrigin = CharInfoEditing.BlitOrigin;
            Point blitDestination = CharInfoEditing.BlitDestination;
            Size textureSize = PicturePreview.BackgroundImage.Size;
            Bitmap croppingPreview = new Bitmap(textureSize.Width, textureSize.Height);

            GFX = Graphics.FromImage(croppingPreview);

            if (blitDestination.X - blitOrigin.X > 0 &&
                blitOrigin.Y - blitDestination.Y > 0)
            {
                GFX.FillRectangle(BrushBlitFill,
                    CharInfoEditing.GetBlitRectangle());

                SetLegalStatus(true);
            }
            else
            {
                SetLegalStatus(false);
            }

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

            // Dispose the last bitmap before we set it to a new one
            if (PicturePreview.Image != null) PicturePreview.Image.Dispose();

            PicturePreview.Image = (Bitmap)croppingPreview.Clone();

            // Dump the bitmap, we're finished with it
            croppingPreview.Dispose();

            // Garbage collect the bitmaps, otherwise memory will fill quickly
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        /// <summary>
        /// Set the legal status of input in this form and update fields as appropriate.
        /// </summary>
        /// <param name="status">The new status.</param>
        private void SetLegalStatus(bool status)
        {
            if (LegalValueInput != status)
            {
                if (status)
                {
                    NumericBlitOriginX.BackColor = Color.White;
                    NumericBlitOriginX.ForeColor = Color.Black;
                    NumericBlitOriginY.BackColor = Color.White;
                    NumericBlitOriginY.ForeColor = Color.Black;
                    NumericBlitDestinationX.BackColor = Color.White;
                    NumericBlitDestinationX.ForeColor = Color.Black;
                    NumericBlitDestinationY.BackColor = Color.White;
                    NumericBlitDestinationY.ForeColor = Color.Black;
                }
                else
                {
                    NumericBlitOriginX.BackColor = Color.Red;
                    NumericBlitOriginX.ForeColor = Color.White;
                    NumericBlitOriginY.BackColor = Color.Red;
                    NumericBlitOriginY.ForeColor = Color.White;
                    NumericBlitDestinationX.BackColor = Color.Red;
                    NumericBlitDestinationX.ForeColor = Color.White;
                    NumericBlitDestinationY.BackColor = Color.Red;
                    NumericBlitDestinationY.ForeColor = Color.White;
                }
            }

            LegalValueInput = status;
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
        /// [Event] "Blit Destination > X" Numeric slider value changed.
        /// </summary>
        private void NumericBlitDestinationX_ValueChanged(object sender, EventArgs e)
        {
            CharInfoEditing.BlitDestination.X = (int)NumericBlitDestinationX.Value;
            UpdatePreview();
        }

        /// <summary>
        /// [Event] "Blit Destination > Y" Numeric slider value changed.
        /// </summary>
        private void NumericBlitDestinationY_ValueChanged(object sender, EventArgs e)
        {
            CharInfoEditing.BlitDestination.Y = (int)NumericBlitDestinationY.Value;
            UpdatePreview();
        }


        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (LegalValueInput)
            {
                CharInfoReference.AssignBlitting(CharInfoEditing.BlitOrigin,
                CharInfoEditing.BlitDestination);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Error.Show(Error.INVALID_BLITTING_COORDINATES);
            }
        }


        /// <summary>
        /// [Event] "Blit Origin > Y" Numeric slider value changed.
        /// </summary>
        private void NumericBlitOriginY_ValueChanged(object sender, EventArgs e)
        {
            CharInfoEditing.BlitOrigin.Y = (int)NumericBlitOriginY.Value;
            UpdatePreview();
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
            Point mousePoint = PicturePreview.PointToClient(Cursor.Position);

            if (ComboSelectionMode.SelectedIndex == 0) // Blit origin mode
            {
                if (mousePoint.X >= 0 && mousePoint.Y >= 0 &&
                    mousePoint.X <= PicturePreview.Width && mousePoint.Y <= PicturePreview.Height)
                {
                    CharInfoEditing.BlitOrigin = mousePoint;
                    NumericBlitOriginX.Value = mousePoint.X;
                    NumericBlitOriginY.Value = mousePoint.Y;
                }
            }
            else // Blit destination mode
            {
                if (mousePoint.X >= 0 && mousePoint.Y >= 0 &&
                    mousePoint.X <= PicturePreview.Width && mousePoint.Y <= PicturePreview.Height)
                {
                    CharInfoEditing.BlitDestination = mousePoint;
                    NumericBlitDestinationX.Value = mousePoint.X;
                    NumericBlitDestinationY.Value = mousePoint.Y;
                }
            }

            UpdatePreview();
        }

        /// <summary>
        /// [Event] "Blit Origin > X" Numeric slider value changed.
        /// </summary>
        private void NumericBlitOriginX_ValueChanged(object sender, EventArgs e)
        {
            CharInfoEditing.BlitOrigin.X = (int)NumericBlitOriginX.Value;
            UpdatePreview();
        }
    }
}
