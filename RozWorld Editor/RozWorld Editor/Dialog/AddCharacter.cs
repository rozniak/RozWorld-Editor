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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RozWorld_Editor.Dialog
{
    public partial class AddCharacter : Form
    {
        private readonly string[] CurrentCharacters;
        private bool LegalCharacterInput;

        public char Character;


        public AddCharacter(string[] currentCharacters)
        {
            InitializeComponent();

            this.CurrentCharacters = currentCharacters;

            this.VerifyValidInput();
        }


        /// <summary>
        /// Updates form information relevant to the validity of character input.
        /// </summary>
        private void VerifyValidInput()
        {
            TextBox textBox = this.TextCharacter;

            if (!CurrentCharacters.Contains(textBox.Text) && textBox.Text != "")
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
                this.LegalCharacterInput = true;
            }
            else
            {
                textBox.BackColor = Color.Red;
                textBox.ForeColor = Color.White;
                this.LegalCharacterInput = false;
            }
        }


        /// <summary>
        /// [Event] Character input textbox text changed.
        /// </summary>
        private void TextCharacter_TextChanged(object sender, EventArgs e)
        {
            this.VerifyValidInput();
        }


        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (this.LegalCharacterInput)
            {
                this.DialogResult = DialogResult.OK;
                this.Character = this.TextCharacter.Text[0];
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
