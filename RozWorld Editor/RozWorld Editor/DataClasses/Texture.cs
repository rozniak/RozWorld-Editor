/**
 * RozWorld_Editor.DataClasses.Texture -- Texture Reference
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Drawing;

namespace RozWorld_Editor.DataClasses
{
    public class Texture
    {
        public string Source;
        public Image Data;


        public Texture()
        {
            Source = null;
            Data = null;
        }


        public Texture(string source, Image texture)
        {
            Source = source;
            Data = texture;
        }


        /// <summary>
        /// Creates a new copy of this Texture.
        /// </summary>
        /// <returns>A new Texture that is a copy of this instance.</returns>
        public Texture Clone()
        {
            return new Texture(this.Source, (Image)this.Data.Clone());
        }


        /// <summary>
        /// Returns the bounding rectangle of this texture.
        /// </summary>
        /// <returns>A Rectangle that represents the bounds of this texture.</returns>
        public Rectangle GetTextureRect()
        {
            return new Rectangle(0, 0, Data.Width, Data.Height);
        }
    }
}
