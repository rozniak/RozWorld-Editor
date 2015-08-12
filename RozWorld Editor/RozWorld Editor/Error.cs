/**
 * RozWorld_Editor.Error -- RozWorld Editor Error System
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Windows.Forms;

namespace RozWorld_Editor
{
    public static class Error
    {
        public const short UNKNOWN_ERROR = 0;
        public const short MISSING_INI_DICTIONARY_KEY = 11;
        public const short MISSING_FONT_TEXTURE = 12;
        public const short INVALID_OR_DUPLICATE_CHARACTER = 20;
        public const short INVALID_BLITTING_COORDINATES = 21;
        public const short WARNING_BLITTING_VALIDITY_EXPIRED = 200;


        /// <summary>
        /// Display an error message relevant to the specified error code.
        /// </summary>
        /// <param name="errorCode">The error code describing the problem.</param>
        public static void Show(short errorCode, bool fatal = false)
        {
            if (fatal)
            {
                // Display fatal dialog here
            }
            else
            {
                switch (errorCode)
                {
                    /**
                     * Errors
                     */

                    case MISSING_INI_DICTIONARY_KEY:
                        MessageBox.Show("A reference was made to a missing INI variable. The default settings will be used instead.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    case MISSING_FONT_TEXTURE:
                        MessageBox.Show("No texture has been assigned to this font yet, so blitting correctly cannot be done. Assign a texture first then try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    case INVALID_OR_DUPLICATE_CHARACTER:
                        MessageBox.Show("The character inputted is either invalid, missing, or a duplicate of a character already present in this font.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    case INVALID_BLITTING_COORDINATES:
                        MessageBox.Show("There are invalid blitting coordinates, the blitting origin point should be the bottom left of a character, the blitting destination should be the top right.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    /**
                     * Warnings
                     */

                    case WARNING_BLITTING_VALIDITY_EXPIRED:
                        MessageBox.Show("The texture selected is incompatible with the blitting coordinates of this character, a character preview cannot be shown. It's suggested you either pick a texture that is compatible or adjust the blitting coordinates for it.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;

                    /**
                     * Unknown Error
                     */

                    default:
                    case UNKNOWN_ERROR:
                        MessageBox.Show("An unknown error occurred.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                }
            }
        }
    }
}
