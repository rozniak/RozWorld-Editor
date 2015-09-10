﻿/**
 * RozWorld_Editor.DataClasses.GUIOMETRY -- GUIOMETRY Data Class
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace RozWorld_Editor.DataClasses.FileFormat
{
    public class GUIOMETRY
    {
        public FontInfo ChatFontInfo;
        public FontInfo SmallFontInfo;
        public FontInfo MediumFontInfo;
        public FontInfo HugeFontInfo;

        public Dictionary<string, ElementInfo> Elements;


        public GUIOMETRY()
        {
            ChatFontInfo = new FontInfo();
            SmallFontInfo = new FontInfo();
            MediumFontInfo = new FontInfo();
            HugeFontInfo = new FontInfo();
            Elements = new Dictionary<string, ElementInfo>();
        }


        public GUIOMETRY(FontInfo chatFont, FontInfo smallFont, FontInfo mediumFont, FontInfo hugeFont, Dictionary<string, ElementInfo> elements)
        {
            ChatFontInfo = chatFont;
            SmallFontInfo = smallFont;
            MediumFontInfo = mediumFont;
            HugeFontInfo = hugeFont;
            Elements = elements;
        }
    }
}