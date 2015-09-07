/**
 * RozWorld_Editor.IO.GameGUIOMETRY -- GUIOMETRY File Management Functions
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
using System.IO;
using System.Text;

using RozWorld_Editor.DataClasses.FileFormat;

namespace RozWorld_Editor.IO
{
    public static class GameGUIOMETRY
    {
        /// <summary>
        /// Reads a GUIOMETRY.BIN file into its data class.
        /// </summary>
        /// <param name="filename">The filename of the GUIOMETRY.BIN to read.</param>
        /// <returns>A GUIOMETRY data class with the contents of the file if it exists, null otherwise.</returns>
        public static GUIOMETRY Read(string filename)
        {
            // This function is still a WIP, implementing reading of GUIOMETRY.BIN files
            // The spec for this can be found inside of formats.md in the project root!

            if (!File.Exists(filename))
            {
                return null;
            }

            var guiometry = new GUIOMETRY(); // The result we're working on

            byte[] fileAsBytes = Files.GetBinaryFile(filename);
            int currentByte = 0; // Index of the byte in the array we're reading
            bool nextSection = false; // Set this to true to move onto the next section

            // Read metadata
            do
            {
                string textureID = GetTextureIDToName(fileAsBytes[currentByte++]); // Get the texture ID we're handling

                if (textureID == "End") // If the texture ID is 0, then that's the end of metadata, escape this loop
                {
                    nextSection = true;
                }
                else if (textureID != null) // If the texture has been given a name, continue, otherwise, bin it (probably will cause errors though)
                {
                    bool endOfString = false; // Set this to true when we encounter a null character
                    var filepathBytes = new List<byte>();

                    // Read the filepath string
                    do
                    {
                        // Check if the next two bytes are NULL
                        if (fileAsBytes[currentByte] == 0 && fileAsBytes[currentByte + 1] == 0)
                        {
                            endOfString = true;
                        }

                        // Add the next two bytes
                        filepathBytes.Add(fileAsBytes[currentByte++]);
                        filepathBytes.Add(fileAsBytes[currentByte++]);
                    } while (!endOfString);

                    // Convert bytes to the string
                    string resultingFilePath = UnicodeEncoding.Unicode.GetChars(filepathBytes.ToArray()).ToString();

                    if (File.Exists(resultingFilePath))
                    {
                        // This section should refer to dictionaries... CLEAN UP REQUIRED!
                        switch (textureID)
                        {
                            case "ChatFont":
                                break;

                            case "SmallFont":
                                break;
                                
                            case "MediumFont":
                                break;

                            case "HugeFont":
                                break;
                        }
                    }
                }
            } while (!nextSection);

            return null;
        }


        /// <summary>
        /// Gets the internal name of a texture from the specified ID.
        /// </summary>
        /// <param name="id">The ID of the texture.</param>
        /// <returns>The internal name of the texture specified if it matches, null otherwise.</returns>
        public static string GetTextureIDToName(int id)
        {
            switch (id)
            {
                case 0: return "End"; // End of metadata byte

                /**
                 * Fonts
                 */
                case 1: return "ChatFont";
                case 2: return "SmallFont";
                case 3: return "MediumFont";
                case 4: return "HugeFont";

                /**
                 * Elements
                 */
                case 5: return "ButtonBody";
                case 6: return "ButtonTop";
                case 7: return "ButtonSide";
                case 8: return "ButtonEdgeSW";
                case 9: return "ButtonEdgeSE";

                case 10: return "TextBody";
                case 11: return "TextTop";
                case 12: return "TextSide";
                case 13: return "TextEdgeSW";
                case 14: return "TextEdgeSE";

                case 15: return "CheckBody";
                case 16: return "CheckTop";
                case 17: return "CheckSide";
                case 18: return "CheckEdgeSW";
                case 19: return "CheckEdgeSE";
                case 20: return "CheckTick";
                    
                default:
                    return null;
            }
        }
    }
}
