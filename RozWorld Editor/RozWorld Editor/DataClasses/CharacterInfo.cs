/**
 * RozWorld_Editor.DataClasses.CharacterInfo -- Character Information
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
    public class CharacterInfo
    {
        public Point BlitOrigin = new Point(0, 0);
        public Point BlitDestination = new Point(0, 0);
        public byte Before = 0;
        public byte After = 0;
        public byte YOffset = 0;
    }
}
