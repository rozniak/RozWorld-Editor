/**
 * RozWorld_Editor.DataClasses.FontInfo -- Font Information
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;
using System.Text;

namespace RozWorld_Editor.DataClasses
{
    public class FontInfo
    {
        public Texture Texture = new Texture();
        private Dictionary<char, CharacterInfo> Characters = new Dictionary<char, CharacterInfo>();
        public byte SpacingWidth = 0;
        public byte LineHeight = 0;


        /// <summary>
        /// Adds a new character into this font's character list.
        /// </summary>
        /// <param name="newChar">The character to add.</param>
        /// <returns>Whether the character was added, otherwise it is already present.</returns>
        public bool AddNewCharacter(char newChar)
        {
            if (!Characters.ContainsKey(newChar))
            {
                Characters.Add(newChar, new CharacterInfo());
                return true;
            }

            return false;
        }


        /// <summary>
        /// Gets all data of this font info into bytes in the GUIOMETRY.BIN format.
        /// </summary>
        /// <returns></returns>
        public IList<byte> GetBytes()
        {
            var asBytes = new List<byte>(); // Construct the byte array object

            // Add the amount of characters present in this font
            asBytes.AddRange(Converts.ShortToBytes((short)Characters.Count));

            // Add character data
            foreach(var character in Characters)
            {
                asBytes.AddRange(UnicodeEncoding.Unicode.GetBytes(new char[] { character.Key })); // Add character code

                // Add character data
                asBytes.AddRange(Converts.ShortToBytes((short)character.Value.BlitOrigin.X)); // Blit origin x
                asBytes.AddRange(Converts.ShortToBytes((short)character.Value.BlitOrigin.Y)); // Blit origin y
                asBytes.AddRange(Converts.ShortToBytes((short)character.Value.BlitDestination.X)); // Blit destination x
                asBytes.AddRange(Converts.ShortToBytes((short)character.Value.BlitDestination.Y)); // Blit destination y
                asBytes.Add((byte)character.Value.Before); // Before line
                asBytes.Add((byte)character.Value.After); // After line
                asBytes.Add((byte)character.Value.YOffset); // Y-offset
            }

            // Add general font data
            asBytes.Add(SpacingWidth);
            asBytes.Add(LineHeight);

            return asBytes.AsReadOnly();
        }


        /// <summary>
        /// Gets the character information of the specified character key.
        /// </summary>
        /// <param name="key">The character to get the info of.</param>
        /// <returns>The character's info if it is present, null otherwise.</returns>
        public CharacterInfo GetCharacter(char key)
        {
            if (Characters.ContainsKey(key)) return Characters[key];
            return null;
        }


        /// <summary>
        /// Gets a read-only list of all the characters present in this font's information.
        /// </summary>
        /// <returns>A read-only list containing all the characters inside this font's information.</returns>
        public IList<char> GetListCharacters()
        {
            var characters = new List<char>();

            foreach(char character in Characters.Keys)
            {
                characters.Add(character);
            }

            return characters.AsReadOnly();
        }


        /// <summary>
        /// Removes a character from this font's character list.
        /// </summary>
        /// <param name="newChar">The character to remove.</param>
        /// <returns>Whether the character was remove, otherwise it didn't exist in the first place.</returns>
        public bool RemoveCharacter(char removeChar)
        {
            if (Characters.ContainsKey(removeChar))
            {
                Characters.Remove(removeChar);
                return true;
            }

            return false;
        }
    }
}
