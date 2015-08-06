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


        public Texture(string source, Image texture)
        {
            this.Source = source;
            this.Data = texture;
        }
    }
}
