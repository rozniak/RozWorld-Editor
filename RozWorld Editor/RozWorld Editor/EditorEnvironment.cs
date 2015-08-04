/**
 * RozWorld_Editor.EditorEnvironment -- RozWorld Editor Environment Core
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
using System.Windows.Forms;

using RozWorld_Editor.IO;

namespace RozWorld_Editor
{
    public static class EditorEnvironment
    {
        /**
         * The maximum operations kept track of and able to undo or redo.
         */
        public const int MAX_OPERATION_HISTORY = 10;


        /**
         * The currently open editor windows.
         */
        private static Dictionary<string, MainForm> Windows = new Dictionary<string, MainForm>();

        /**
         * Checks whether the first window has opened or not, this is for showing the home page
         * in the first window.
         */
        private static bool StartedEnvironment = false;

        /**
         * The current user settings for this environment.
         */
        public static EditorSettings UserSettings
        {
            get;
            private set;
        }

        /**
         * Keep tabs on what the last operations were that can be undone.
         */
        private static string[] OperationHistoryUndo = new string[MAX_OPERATION_HISTORY];
        private static string[] OperationHistoryRedo = new string[MAX_OPERATION_HISTORY];

        /**
         * Tells whether the command being done is an undo operation or not, if it isn't, it
         * should add itself to the operation history.
         */
        private static bool OperationIsUndo = false;


        /// <summary>
        /// Initialises the environment.
        /// </summary>
        public static void Initialise()
        {
            if (!StartedEnvironment)
            {
                // Load the editor settings
                UserSettings = new EditorSettings();
                UserSettings.LoadUserSettings();
            }
        }

        /// <summary>
        /// Registers a window into this environment.
        /// </summary>
        /// <param name="windowName">The name of the window to register.</param>
        /// <param name="window">The window instance to register.</param>
        /// <returns>Whether the window was successfully registered or not.</returns>
        public static bool RegisterWindow(string windowName, MainForm window)
        {
            if (!Windows.ContainsKey(windowName))
            {
                window.Name = windowName;
                Windows.Add(windowName, window);
                return true;
            }

            return false;
        }


        /// <summary>
        /// Creates a window in this environment.
        /// </summary>
        /// <param name="windowName">The name of the window to add.</param>
        /// <returns>Whether the window was successfully added or not.</returns>
        public static bool CreateWindow(string windowName)
        {
            if (!Windows.ContainsKey(windowName))
            {
                MainForm window = new MainForm(false);

                window.Name = windowName;
                Windows.Add(windowName, window);
                return true;
            }

            return false;
        }


        /// <summary>
        /// Sets the status of a toolbar on or off.
        /// </summary>
        /// <param name="toolbar">The name of the toolbar.</param>
        /// <param name="status">The new status of the toolbar.</param>
        public static void SetToolbarStatus(string toolbarName, bool status)
        {
            foreach (var item in Windows)
            {
                item.Value.SetToolbarStatus(toolbarName, status);
            }

            UserSettings.ToolbarStandardActive = status;
        }
    }
}
