/**
 * RozWorld_Editor.IO.Files -- RozWorld File/File System Management
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
using System.IO;

namespace RozWorld_Editor.IO
{
    public static class Files
    {
        public static readonly string PreferencesFile = Environment.CurrentDirectory + @"\prefs.ini";
        public static readonly string BackupPreferencesFile = PreferencesFile + ".old";


        /// <summary>
        /// Gets a text file with the specified filename from the disk.
        /// </summary>
        /// <param name="fileName">The filename of the file to get.</param>
        /// <returns>The file contents if it exists.</returns>
        public static string[] GetTextFile(string fileName)
        {
            List<string> fileContents = new List<string>();

            if (File.Exists(fileName))
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    do
                    {
                        fileContents.Add(r.ReadLine());
                    } while (r.Peek() > -1);
                }

                return fileContents.ToArray();
            }

            return null;
        }


        /// <summary>
        /// Gets a binary file with the specified filename from the disk.
        /// </summary>
        /// <param name="fileName">The filename of the file to get.</param>
        /// <returns>The file contents if it exists.</returns>
        public static byte[] GetBinaryFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllBytes(fileName);
            }

            return null;
        }


        /// <summary>
        /// Writes a text file with the specified filename to the disk.
        /// </summary>
        /// <param name="fileName">The filename of the file to write.</param>
        /// <param name="contents">The contents of the file to write.</param>
        /// <returns>Whether the file was successfully written or not.</returns>
        public static bool PutTextFile(string fileName, string[] contents)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(fileName))
                {
                    for (int i = 0; i <= contents.Length - 1; i++)
                    {
                        w.WriteLine(contents[i]);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Writes a binary file with the specified filename to the disk.
        /// </summary>
        /// <param name="fileName">The filename of the file to write.</param>
        /// <param name="contents">The contents of the file to write.</param>
        /// <returns>Whether the file was successfully written or not.</returns>
        public static bool PutBinaryFile(string fileName, byte[] contents)
        {
            try
            {
                using (FileStream w = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    w.Write(contents, 0, contents.Length);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Reads an INI file into a dictionary for easy reading
        /// </summary>
        /// <param name="filePath">The file path of the INI file to read.</param>
        /// <returns>A dictionary containing the variable names as keys, alongside their values.</returns>
        public static Dictionary<string, string> ReadINIToDictionary(string filePath)
        {
            string[] iniFile = GetTextFile(filePath);

            if (iniFile != null)
            {
                var finalDictionary = new Dictionary<string, string>();

                foreach (string line in iniFile)
                {
                    if (!line.StartsWith("#")) // Ignore comments
                    {
                        string[] resultingSplit = SplitFirstInstance(":", line);

                        if (resultingSplit[0] != "" && resultingSplit[1] != "") // Check that this line is a valid property
                        {
                            if (finalDictionary.ContainsKey(resultingSplit[0]))
                            {
                                finalDictionary[resultingSplit[0]] = resultingSplit[1];
                            }
                            else
                            {
                                finalDictionary.Add(resultingSplit[0], resultingSplit[1]);
                            }
                        }
                    }
                }

                return finalDictionary;
            }

            return null;
        }


        /// <summary>
        /// Attempts to split a string by a pattern on its first occurrence.
        /// </summary>
        /// <param name="pattern">The pattern to split the string by.</param>
        /// <param name="text">The string to split.</param>
        /// <returns>The split string at the first occurrence of the pattern, if pattern doesn't exit, returns two empty strings.</returns>
        public static string[] SplitFirstInstance(string pattern, string text)
        {
            string[] resultingSplit = new string[] { "", "" };

            if (text.Contains(pattern))
            {
                int splitIndex = text.IndexOf(pattern, 0, text.Length, StringComparison.CurrentCulture);

                resultingSplit[0] = text.Substring(0, splitIndex);
                resultingSplit[1] = text.Substring(splitIndex + pattern.Length, text.Length - (pattern.Length + splitIndex));
            }

            return resultingSplit;
        }
    }
}
