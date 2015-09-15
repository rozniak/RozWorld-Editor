/**
 * RozWorld_Editor.DataClasses.ElementInfo -- Element Information
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_Editor.DataClasses
{
    public class ElementInfo
    {
        public Texture Texture = new Texture();
        public sbyte XOffset = 0;
        public sbyte YOffset = 0;


        /// <summary>
        /// Creates a new copy of this ElementInfo.
        /// </summary>
        /// <returns>A new ElementInfo that is a copy of this instance.</returns>
        public ElementInfo Clone()
        {
            var cloneElementInfo = new ElementInfo();

            cloneElementInfo.Texture = Texture.Clone();
            cloneElementInfo.XOffset = XOffset;
            cloneElementInfo.YOffset = YOffset;

            return cloneElementInfo;
        }
    }
}
