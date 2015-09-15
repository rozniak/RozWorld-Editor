/**
 * RozWorld_Editor.Converts -- Generic Conversion Functions Class
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
using System.Linq;
using System.Text;

namespace RozWorld_Editor
{
    public static class Converts
    {
        /// <summary>
        /// Converts a length-2 byte array to a short.
        /// </summary>
        /// <param name="data">The length-2 byte array to convert.</param>
        /// <returns>The short value converted from the bytes, if the conversion failed, 0 will be returned always.</returns>
        public static short BytesToShort(byte[] data)
        {
            if (data.Length == 2) return (short)((data[1] << 8) + data[0]); // Bit shift and append remaining bytes
            return 0;
        }


        /// <summary>
        /// Converts a short to a length-2 byte array.
        /// </summary>
        /// <param name="value">The short value to convert.</param>
        /// <returns>The length-2 array converted from the short.</returns>
        public static byte[] ShortToBytes(short value)
        {
            return new byte[] { (byte)(value >> 8), (byte)(value & 255) }; // Bit shift and cast, then and mask and cast
        }
    }
}
