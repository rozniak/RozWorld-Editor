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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RozWorld_Editor.Dialog
{
    public partial class AddCharacter : Form
    {
        private readonly string[] CurrentCharacters;
        private bool LegalCharacterInput;
        private char CharacterToReturn;


        public AddCharacter(string[] currentCharacters, char charReference)
        {
            InitializeComponent();

            this.CharacterToReturn = charReference;
        }


        /// <summary>
        /// [Event] Character input textbox text changed.
        /// </summary>
        private void TextCharacter_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

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
    }
}
