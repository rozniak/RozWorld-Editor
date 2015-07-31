using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RozWorld_Editor
{
    public static class EditorEnvironment
    {
        public const int MAX_COMMAND_HISTORY = 10;

        private static Dictionary<string, Form> Windows = new Dictionary<string, Form>();
        private static bool StartedEnvironment = false;


        /// <summary>
        /// Sends a command into the environment to be performed.
        /// </summary>
        /// <param name="command">The entire command to be interpreted.</param>
        /// <param name="sender">The instance of the command sender.</param>
        /// <param name="context">The requested context of the command.</param>
        /// <returns>Whether the command was successful or not.</returns>
        public static bool SendCommand(string command, object sender, CommandContext context = CommandContext.Default)
        {
            try
            {
                string commandName = command.Split()[0];
                string[] args = command.Length > commandName.Length ?
                    command.Substring(commandName.Length - 1).Split() :
                    null;

                switch (commandName)
                {
                    /**
                     * Create window command.
                     */
                    case "createwindow":
                        if (args.Length != 1 || Windows.ContainsKey(args[0]))
                        {
                            return false;
                        }

                        MainForm newWindow = new MainForm();
                        newWindow.Name = args[0];

                        Windows.Add(args[0], newWindow);

                        return true;

                }

                return false;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Registers a window into this environment.
        /// </summary>
        /// <param name="windowName">The name of the window to register.</param>
        /// <param name="window">The window instance to register.</param>
        /// <returns>Whether the window was successfully registered or not.</returns>
        public static bool RegisterWindow(string windowName, Form window)
        {
            if (!Windows.ContainsKey(windowName))
            {
                window.Name = windowName;
                Windows.Add(windowName, window);
                return true;
            }

            return false;
        }
    }
}
