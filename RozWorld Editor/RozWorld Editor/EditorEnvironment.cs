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
        public static EditorSettings UserSettings;

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
        /// Loads the user settings from /prefs.ini, or makes a default one if the file was not found.
        /// </summary>
        /// <returns>Whether settings were successfully loaded or not.</returns>
        public static bool LoadUserSettings()
        {
            if (UserSettings == null)
            {
                if (!System.IO.File.Exists(Files.PreferencesFile))
                {
                    MakeDefaultUserSettings();
                }

                Dictionary<string, string> iniFile = Files.ReadINIToDictionary(Files.PreferencesFile);

                // Loading here
            }

            return false;
        }


        /// <summary>
        /// Makes a new default user settings file.
        /// </summary>
        private static void MakeDefaultUserSettings()
        {
            string[] defaultINIFile = new string[] {
                "# RozWorld Editor user settings",
                "# -",
                "# [Toolbars]",
                "StandardToolbar: true"
            };

            Files.PutTextFile(Files.PreferencesFile, defaultINIFile);
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
    }
}
