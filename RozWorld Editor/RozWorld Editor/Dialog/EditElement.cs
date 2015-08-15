/**
 * RozWorld_Editor.Dialog.EditElement -- Element Editor Dialog
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
using System.Linq;
using System.Windows.Forms;

using RozWorld_Editor.DataClasses;

namespace RozWorld_Editor.Dialog
{
    public partial class EditElement : Form
    {
        private ElementInfo ElementInfoEditing;
        private ElementInfo ElementInfoReference;

        private Brush BrushBodyFill;
        private Graphics GFX;

        private bool DrawBodyPosition;


        public EditElement(string elementTarget, ElementInfo elementInfoReference)
        {
            InitializeComponent();

            ElementInfoReference = elementInfoReference;
            ElementInfoEditing = elementInfoReference.Clone();

            LabelTagDialogDescription.Text = LabelTagDialogDescription.Text.Replace("$ELEMENT", elementTarget);

            BrushBodyFill = new SolidBrush(Color.FromArgb(100, Color.Magenta));

            // Set this to true because it will only be set to false once
            DrawBodyPosition = true;

            // Get the type of element being edited
            if (elementTarget.EndsWith("Body") || elementTarget.EndsWith("Check"))
            {
                NumericXOffset.Enabled = false;
                NumericYOffset.Enabled = false;
                DrawBodyPosition = false;
            }
            else if (elementTarget.EndsWith("Top"))
            {
                NumericXOffset.Enabled = false;
            }
            else if (elementTarget.EndsWith("Side"))
            {
                NumericYOffset.Enabled = false;
            }
        }


        /// <summary>
        /// Updates the element preview box.
        /// </summary>
        private void UpdatePreview()
        {
            // TODO: Update preview here
        }


        /// <summary>
        /// [Event] "Browse..." button clicked.
        /// </summary>
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            // TODO: Make a new open file dialog and browse for image files
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
            // TODO: Assign vars in the element reference with the editing one
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// [Event] "X Offset" numeric slider changed.
        /// </summary>
        private void NumericXOffset_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Update element details and preview
        }


        /// <summary>
        /// [Event] "Y Offset" numeric slider changed.
        /// </summary>
        private void NumericYOffset_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Update element details and preview
        }
    }
}
