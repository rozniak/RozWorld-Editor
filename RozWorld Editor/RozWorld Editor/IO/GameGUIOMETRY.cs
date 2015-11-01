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

using RozWorld_Editor.DataClasses;
using RozWorld_Editor.DataClasses.FileFormat;
using System.Drawing;

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

            IList<byte> guiometryFile = Files.GetBinaryFile(filename);
            int currentIndex = 0; // Index of the byte in the array we're reading
            bool nextSection = false; // Set this to true to move onto the next section

            // Get the version before doing anything
            byte version = ByteParse.NextByte(guiometryFile, ref currentIndex);

            // Read file metadata (for the textures)
            while (!nextSection && currentIndex <= guiometryFile.Count - 1)
            {
                byte textureID = ByteParse.NextByte(guiometryFile, ref currentIndex);

                if (textureID == 0) // End of metadata
                {
                    nextSection = true;
                }
                else
                {
                    string textureName = GetTextureIDToName(textureID);
                    string textureSource = ByteParse.NextString(guiometryFile, ref currentIndex);
                }
            }


            if (version == 1)
            {
                #region Version 1


                // This should be the fonts to look for (eg. ChatFont, SmallFont etc.) in the order they are
                // supposed to be according to the format
                string[] fonts = new string[] { "ChatFont", "SmallFont", "MediumFont", "HugeFont" };

                // Keep track of the current character being read (out of the number in the font)
                short currentChar = 1; // Make sure to reset this to 1 after reading a font or you will be shot

                // However many characters are in the font being read
                short charsInFont;


                // This should be the elements to look for (eg. Button, Text etc.) in the order they are
                // supposed to be according to the format
                string[] elements = new string[] { "Button", "Text", "Check" };

                // This should be the 'parts' of the elements to look for (eg. Body, Top, Side etc.) in the
                // order they are supposed to be according to the format
                string[] elementParts;


                #region Font Data

                foreach (string font in fonts)
                {
                    charsInFont = ByteParse.NextShort(guiometryFile, ref currentIndex);

                    do
                    {
                        char character = ByteParse.NextChar(guiometryFile, ref currentIndex);

                        guiometry.Fonts[font].AddNewCharacter(character,
                            NextCharacter(guiometryFile, ref currentIndex));
                    } while (currentChar++ <= charsInFont);

                    guiometry.Fonts[font].SpacingWidth = ByteParse.NextByte(guiometryFile, ref currentIndex);
                    guiometry.Fonts[font].LineHeight = ByteParse.NextByte(guiometryFile, ref currentIndex);

                    currentChar = 1;
                }

                #endregion


                #region Element Data

                foreach (string element in elements)
                {
                    // Set up the parts to look for...
                    if (element == "Button" || element == "Text")
                        elementParts = new string[] { "Top", "Side", "EdgeSE", "EdgeSW" };
                    else // element == "CheckBox"
                        elementParts = new string[] { "Top", "Side", "EdgeSE", "EdgeSW", "Tick" };

                    foreach (string part in elementParts)
                    {
                        if (part == "Side" || part == "EdgeSE" || part == "EdgeSW" || part == "Tick")
                            guiometry.Elements[element + part].XOffset = ByteParse.NextSByte(guiometryFile, ref currentIndex);

                        if (part == "Top" || part == "EdgeSE" || part == "EdgeSW" || part == "Tick")
                            guiometry.Elements[element + part].YOffset = ByteParse.NextSByte(guiometryFile, ref currentIndex);
                    }

                    // Read the element details too
                    if (element == "Button")
                    {
                        guiometry.ButtonCentredText = ByteParse.NextBool(guiometryFile, ref currentIndex);
                        guiometry.ButtonOffsetTop = ByteParse.NextSByte(guiometryFile, ref currentIndex);
                        guiometry.ButtonOffsetLeft = ByteParse.NextSByte(guiometryFile, ref currentIndex);
                    }
                    else if (element == "Text")
                    {
                        guiometry.TextCentredText = ByteParse.NextBool(guiometryFile, ref currentIndex);
                        guiometry.TextOffsetTop = ByteParse.NextSByte(guiometryFile, ref currentIndex);
                        guiometry.TextOffsetLeft = ByteParse.NextSByte(guiometryFile, ref currentIndex);
                    }
                }

                #endregion


                #endregion
            }

            return null;
        }


        /// <summary>
        /// (For internal use) Attempts to read the next character from a GUIOMETRY file into a CharacterInfo object.
        /// </summary>
        /// <param name="data">The GUIOMETRY data to read from.</param>
        /// <param name="currentIndex">The current index pointer.</param>
        /// <returns>A new CharacterInfo object containing as much of the character info that could be read.</returns>
        private static CharacterInfo NextCharacter(IList<byte> data, ref int currentIndex)
        {
            CharacterInfo charInfo = new CharacterInfo(); // Build the character up

            short blitOriginX = ByteParse.NextShort(data, ref currentIndex);
            short blitOriginY = ByteParse.NextShort(data, ref currentIndex);
            charInfo.BlitOrigin = new Point(blitOriginX, blitOriginY);

            short blitDestinationX = ByteParse.NextShort(data, ref currentIndex);
            short blitDestinationY = ByteParse.NextShort(data, ref currentIndex);
            charInfo.BlitDestination = new Point(blitDestinationX, blitDestinationY);

            charInfo.Before = ByteParse.NextSByte(data, ref currentIndex);
            charInfo.After = ByteParse.NextSByte(data, ref currentIndex);
            charInfo.YOffset = ByteParse.NextSByte(data, ref currentIndex);

            return charInfo;
        }


        /// <summary>
        /// Saves a GUIOMETRY.BIN data class to the disk.
        /// </summary>
        /// <param name="data">The GUIOMETRY data class.</param>
        /// <param name="filename">The filename to save as.</param>
        /// <returns>Whether the save was successful or not.</returns>
        public static bool Save(GUIOMETRY data, string filename)
        {
            // Collect data class metadata
            var textureMetadata = new Dictionary<byte, string>();

            // For each of these, only add the metadata if the source of the texture is not blank or null

            // Add font metadata
            foreach (var font in data.Fonts)
            {
                if (!string.IsNullOrEmpty(font.Value.Texture.Source))
                    textureMetadata.Add(GetTextureNameToID(font.Key), font.Value.Texture.Source);
            }

            // Add element metadata
            foreach (var element in data.Elements)
            {
                // In here element.Key is the internal name of the element, and element.Value is the ElementInfo object
                if (!string.IsNullOrEmpty(element.Value.Texture.Source))
                    textureMetadata.Add(GetTextureNameToID(element.Key), element.Value.Texture.Source);
            }


            // Construct the save data file
            var saveData = new List<byte>();

            saveData.Add(GUIOMETRY.VERSION); // Add format version byte

            // Add metadata
            foreach (var metadata in textureMetadata)
            {
                saveData.Add(metadata.Key); // Texture ID
                saveData.AddRange(UnicodeEncoding.Unicode.GetBytes(metadata.Value + "\0")); // Texture path with NULL char
            }

            saveData.Add(0); // End metadata byte

            // Add font data
            saveData.AddRange(data.Fonts["ChatFont"].GetBytes());
            saveData.AddRange(data.Fonts["SmallFont"].GetBytes());
            saveData.AddRange(data.Fonts["MediumFont"].GetBytes());
            saveData.AddRange(data.Fonts["HugeFont"].GetBytes());

            // Add element data and save
            saveData.AddRange(data.GetElementInfo("Button"));
            saveData.AddRange(data.GetElementInfo("Text"));
            saveData.AddRange(data.GetElementInfo("Check"));

            return Files.PutBinaryFile(filename, saveData.ToArray());
        }


        /// <summary>
        /// Gets the internal name of a texture from the specified ID.
        /// </summary>
        /// <param name="id">The ID of the texture.</param>
        /// <returns>The internal name of the texture specified if it matches, null otherwise.</returns>
        public static string GetTextureIDToName(byte id)
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


        /// <summary>
        /// Gets the ID of a texture from the specified internal name.
        /// </summary>
        /// <param name="name">The internal name of the texture.</param>
        /// <returns>The ID of the texture specified if it matches, 0 otherwise.</returns>
        public static byte GetTextureNameToID(string name)
        {
            switch (name)
            {
                case "ChatFont": return 1;
                case "SmallFont": return 2;
                case "MediumFont": return 3;
                case "HugeFont": return 4;

                case "ButtonBody": return 5;
                case "ButtonTop": return 6;
                case "ButtonSide": return 7;
                case "ButtonEdgeSW": return 8;
                case "ButtonEdgeSE": return 9;

                case "TextBody": return 10;
                case "TextTop": return 11;
                case "TextSide": return 12;
                case "TextEdgeSW": return 13;
                case "TextEdgeSE": return 14;

                case "CheckBody": return 15;
                case "CheckTop": return 16;
                case "CheckSide": return 17;
                case "CheckEdgeSW": return 18;
                case "CheckEdgeSE": return 19;
                case "CheckTick": return 20;

                case "End":
                default:
                    return 0;
            }
        }
    }
}
