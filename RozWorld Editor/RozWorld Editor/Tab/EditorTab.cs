/**
 * RozWorld_Editor.Tab.EditorTab -- RozWorld Generic Tab
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Windows.Forms;

namespace RozWorld_Editor.Tab
{
    public abstract class EditorTab : TabPage
    {
        /// <summary>
        /// Base method for closing this tab.
        /// </summary>
        public virtual void Close()
        {
            ((TabControl)this.Parent).TabPages.RemoveByKey(this.Name);
            this.Dispose();
        }

        /**
         * The name/path of the file that this tab is working on.
         */
        public string AssociatedFilename
        {
            get;
            private set;
        }

        /**
         * The save status of the changes in this tab.
         */
        public bool IsUnsaved
        {
            get;
            private set;
        }
    }
}
