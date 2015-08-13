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
using System;

namespace RozWorld_Editor.DataClasses
{
    public class CharacterInfo
    {
        public Point BlitOrigin = new Point(0, 0);
        public Point BlitDestination = new Point(0, 0);
        public sbyte Before = 0;
        public sbyte After = 0;
        public sbyte YOffset = 0;


        /// <summary>
        /// Assigns the blitting fields for this character info.
        /// </summary>
        /// <param name="blitOrigin">The blitting origin point.</param>
        /// <param name="blitDestination">The blitting destination point.</param>
        public void AssignBlitting(Point blitOrigin, Point blitDestination)
        {
            BlitOrigin = blitOrigin;
            BlitDestination = blitDestination;
        }


        /// <summary>
        /// Assigns the detail fields for this character info.
        /// </summary>
        /// <param name="before">The point this character begins.</param>
        /// <param name="after">The point this character ends.</param>
        /// <param name="yOffset">The offset of the line this character sits on.</param>
        public void AssignDetails(sbyte before, sbyte after, sbyte yOffset)
        {
            Before = before;
            After = after;
            YOffset = yOffset;
        }


        /// <summary>
        /// Creates a new copy of this character info.
        /// </summary>
        /// <returns>A new character info that is a copy of this instance.</returns>
        public CharacterInfo Clone()
        {
            var cloneCharInfo = new CharacterInfo();

            cloneCharInfo.BlitOrigin = this.BlitOrigin;
            cloneCharInfo.BlitDestination = this.BlitDestination;
            cloneCharInfo.Before = this.Before;
            cloneCharInfo.After = this.After;
            cloneCharInfo.YOffset = this.YOffset;

            return cloneCharInfo;
        }


        /// <summary>
        /// Returns the bounding rectangle of the blitting coordinates in this character's info.
        /// </summary>
        /// <returns>A Rectangle that represents the bounds of the blitting coordinates in this character's info.</returns>
        public Rectangle GetBlitRectangle()
        {
            return new Rectangle(BlitOrigin.X,
                BlitDestination.Y,
                Math.Abs(BlitDestination.X - BlitOrigin.X),
                Math.Abs(BlitOrigin.Y - BlitDestination.Y));
        }
    }
}
