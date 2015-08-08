﻿/**
 * RozWorld_Editor.Tab.EditorTab -- RozWorld Editor Generic Tab
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
            protected set;
        }

        /**
         * The parent window of this tab
         */
        protected MainForm ParentForm;

        /**
         * The parent TabControl of this tab.
         */
        protected TabControl ParentTabUI;

        /**
         * Undo and redo history for this tab.
         */
        protected string[] UndoHistory = new string[EditorEnvironment.MAX_OPERATION_HISTORY];
        protected string[] RedoHistory = new string[EditorEnvironment.MAX_OPERATION_HISTORY];


        /// <summary>
        /// Gets whether this tab has undo history.
        /// </summary>
        /// <returns>Whether this tab has undo history or not.</returns>
        public bool CanUndo()
        {
            return UndoHistory[0] != null;
        }


        /// <summary>
        /// Gets whether this tab has redo history.
        /// </summary>
        /// <returns>Whether this tab has redo history or not.</returns>
        public bool CanRedo()
        {
            return RedoHistory[0] != null;
        }


        /**
         * Undo and redo functions to be implemented by the tabs that use them.
         */
        public virtual void Undo() { }
        public virtual void Redo() { }


        /// <summary>
        /// Base method for closing this tab.
        /// </summary>
        /// <returns>Whether the tab successfully closed or not.</returns>
        public virtual bool Close()
        {
            try
            {
                this.ParentTabUI.SelectedIndex--;
            }
            catch { }
            
            this.ParentTabUI.TabPages.RemoveByKey(this.Name);
            this.Dispose();

            return true;
        }
    }
}
