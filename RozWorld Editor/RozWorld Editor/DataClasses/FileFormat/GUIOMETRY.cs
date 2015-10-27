/**
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
using System;

namespace RozWorld_Editor.DataClasses.FileFormat
{
    public class GUIOMETRY
    {
        public const byte VERSION = 1;

        public FontInfo ChatFontInfo;
        public FontInfo SmallFontInfo;
        public FontInfo MediumFontInfo;
        public FontInfo HugeFontInfo;

        public Dictionary<string, FontInfo> Fonts;

        public Dictionary<string, ElementInfo> Elements;

        public bool CentredTextButton;
        public sbyte OffsetTopButton;
        public sbyte OffsetLeftButton;

        public bool CentredTextText;
        public sbyte OffsetTopText;
        public sbyte OffsetLeftText;


        public GUIOMETRY()
        {
            ChatFontInfo = new FontInfo();
            SmallFontInfo = new FontInfo();
            MediumFontInfo = new FontInfo();
            HugeFontInfo = new FontInfo();
            Elements = new Dictionary<string, ElementInfo>();

            BuildKeys();
        }


        public GUIOMETRY(FontInfo chatFont, FontInfo smallFont, FontInfo mediumFont, FontInfo hugeFont, Dictionary<string, ElementInfo> elements,
            bool centredTextButton, sbyte offsetTopButton, sbyte offsetLeftButton, bool centredTextText, sbyte offsetTopText, sbyte offsetLeftText)
        {
            ChatFontInfo = chatFont;
            SmallFontInfo = smallFont;
            MediumFontInfo = mediumFont;
            HugeFontInfo = hugeFont;
            Elements = elements;
            CentredTextButton = centredTextButton;
            OffsetTopButton = offsetTopButton;
            OffsetLeftButton = offsetLeftButton;
            CentredTextText = centredTextText;
            OffsetTopText = offsetTopText;
            OffsetLeftText = offsetLeftText;
        }


        /// <summary>
        /// Initialises or rebuilds all font and element keys in their respective Dictionary collections.
        /// </summary>
        private void BuildKeys()
        {
            // Button ElementInfos
            Elements.Add("ButtonBody", new ElementInfo());
            Elements.Add("ButtonTop", new ElementInfo());
            Elements.Add("ButtonSide", new ElementInfo());
            Elements.Add("ButtonEdgeSE", new ElementInfo());
            Elements.Add("ButtonEdgeSW", new ElementInfo());

            // TextBox ElementInfos
            Elements.Add("TextBody", new ElementInfo());
            Elements.Add("TextTop", new ElementInfo());
            Elements.Add("TextSide", new ElementInfo());
            Elements.Add("TextEdgeSE", new ElementInfo());
            Elements.Add("TextEdgeSW", new ElementInfo());

            // CheckBox ElementInfos
            Elements.Add("CheckBody", new ElementInfo());
            Elements.Add("CheckTop", new ElementInfo());
            Elements.Add("CheckSide", new ElementInfo());
            Elements.Add("CheckEdgeSE", new ElementInfo());
            Elements.Add("CheckEdgeSW", new ElementInfo());
            Elements.Add("CheckTick", new ElementInfo());
        }


        /// <summary>
        /// Gets the data belonging to an element by its name.
        /// </summary>
        /// <param name="name">The element's name prefix from the collection.</param>
        /// <returns></returns>
        public IList<byte> GetElementInfo(string name)
        {
            string[] elementsToSearch = new string[] { };
            var data = new List<byte>();

            if (name == "Button" || name == "Text")
            {
                elementsToSearch = new string[] { "Top", "Side", "EdgeSE", "EdgeSW" };
            }
            else // name == "Check"
            {
                elementsToSearch = new string[] { "Top", "Side", "EdgeSE", "EdgeSW", "Tick" };
            }

            foreach (string elementPrefix in elementsToSearch)
            {
                if (elementPrefix == "Side" || elementPrefix == "EdgeSE" || elementPrefix == "EdgeSW" || elementPrefix == "Tick")
                {
                    if(Elements.ContainsKey(name + elementPrefix))
                        data.Add((byte)Elements[name + elementPrefix].XOffset);
                }

                if (elementPrefix == "Top" || elementPrefix == "EdgeSE" || elementPrefix == "EdgeSW" || elementPrefix == "Tick")
                {
                    if (Elements.ContainsKey(name + elementPrefix))
                        data.Add((byte)Elements[name + elementPrefix].YOffset);
                }
            }

            if (name == "Button")
            {
                data.Add(Convert.ToByte(CentredTextButton));
                data.Add((byte)OffsetTopButton);
                data.Add((byte)OffsetLeftButton);
            }
            else if (name == "Text")
            {
                data.Add(Convert.ToByte(CentredTextText));
                data.Add((byte)OffsetTopText);
                data.Add((byte)OffsetLeftText);
            }

            return data.AsReadOnly();
        }
    }
}
