/**
 * RozWorld_Editor.Dialog.AddCharacter -- Add Character Dialog
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

namespace RozWorld_Editor.Dialog
{
    public partial class AddCharacter : Form
    {
        private IList<char> CurrentCharacters;
        private bool LegalCharacterInput;

        public char Character;


        public AddCharacter(IList<char> currentCharacters)
        {
            InitializeComponent();

            CurrentCharacters = currentCharacters;

            VerifyValidInput();
        }


        /// <summary>
        /// Updates form information relevant to the validity of character input.
        /// </summary>
        private void VerifyValidInput()
        {
            TextBox textBox = TextCharacter;

            if (textBox.Text != "" && !CurrentCharacters.Contains(textBox.Text[0]))
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                LegalCharacterInput = true;
            }
            else
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                LegalCharacterInput = false;
            }
        }


        /// <summary>
        /// [Event] Character input textbox text changed.
        /// </summary>
        private void TextCharacter_TextChanged(object sender, EventArgs e)
        {
            VerifyValidInput();
        }


        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (LegalCharacterInput)
            {
                this.DialogResult = DialogResult.OK;
                Character = TextCharacter.Text[0];
                this.Close();
            }
            else
            {
                Error.Show(Error.INVALID_OR_DUPLICATE_CHARACTER);
            }
        }


        /// <summary>
        /// [Event] "Cancel" button clicked.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
