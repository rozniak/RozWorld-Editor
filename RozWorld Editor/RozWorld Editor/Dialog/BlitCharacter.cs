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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RozWorld_Editor.DataClasses;

namespace RozWorld_Editor.Dialog
{
    public partial class BlitCharacter : Form
    {
        private CharacterInfo CharInfoEditing;
        private CharacterInfo CharInfoReference;


        public BlitCharacter(char charTarget, CharacterInfo charInfoReference)
        {
            InitializeComponent();

            CharInfoReference = charInfoReference;

            ComboSelectionMode.SelectedIndex = 0;
            LabelTagDialogDescription.Text = LabelTagDialogDescription.Text.Replace("$CHAR", charTarget.ToString());

            CharInfoEditing = charInfoReference != null ?
                charInfoReference.Clone() :
                new CharacterInfo();
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
    }
}
