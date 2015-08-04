/**
 * RozWorld_Editor.EditorSettings -- RozWorld Editor User Settings
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

using RozWorld_Editor.IO;

namespace RozWorld_Editor
{
    public class EditorSettings
    {
        /**
         * Check if the settings have already been loaded or not.
         */
        private bool LoadedSettings = false;

        /**
         * Active toolbars
         */
        public bool ToolbarStandardActive;


        /// <summary>
        /// Loads the user settings from /prefs.ini, or makes a default one if the file was not found.
        /// </summary>
        /// <returns>Whether settings were successfully loaded or not.</returns>
        public bool LoadUserSettings()
        {
            if (!LoadedSettings)
            {
                if (!System.IO.File.Exists(Files.PreferencesFile))
                {
                    MakeDefaultUserSettings();
                }

                Dictionary<string, string> settingsDictionary = Files.ReadINIToDictionary(Files.PreferencesFile);

                try
                {
                    ToolbarStandardActive = Convert.ToBoolean(settingsDictionary["StandardToolbar"]);
                }
                catch
                {
                    Error.Show(Error.MISSING_INI_DICTIONARY_KEY);
                    MakeDefaultUserSettings();
                }
            }

            return false;
        }


        /// <summary>
        /// Makes a new default user settings file.
        /// </summary>
        private void MakeDefaultUserSettings()
        {
            string[] defaultINIFile = new string[] {
                "# RozWorld Editor user settings",
                "# -",
                "# [Toolbars]",
                "StandardToolbar: true"
            };

            // Move the current preferences file to the backup filename
            if (System.IO.File.Exists(Files.PreferencesFile))
            {
                // If there's already a backup, get rid of it
                if (System.IO.File.Exists(Files.BackupPreferencesFile))
                {
                    System.IO.File.Delete(Files.BackupPreferencesFile);
                }

                System.IO.File.Move(Files.PreferencesFile, Files.BackupPreferencesFile);
            }

            // Now save
            Files.PutTextFile(Files.PreferencesFile, defaultINIFile);
        }


        /// <summary>
        /// Saves the current user settings.
        /// </summary>
        public void SaveUserSettings()
        {
            string[] newINIFile = new string[] {
                "# RozWorld Editor user settings",
                "# -",
                "# [Toolbars]",
                "StandardToolbar: " + ToolbarStandardActive.ToString()
            };

            Files.PutTextFile(Files.PreferencesFile, newINIFile);
        }
    }
}
