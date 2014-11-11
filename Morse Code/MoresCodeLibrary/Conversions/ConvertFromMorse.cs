// ConvertFromMorse.cs
// <copyright file="ConvertFromMorse.cs"> This code is protected under the MIT License. </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeLibrary.Conversions
{
    /// <summary>
    /// A static class to convert from morse code to english.
    /// </summary>
    public static class ConvertFromMorse
    {
        /// <summary>
        /// Converts a message from morse to english.
        /// </summary>
        /// <param name="message"> The message. </param>
        /// <returns> The english of the message. </returns>
        public static string Convert(string message)
        {
            // Copy each character into the result string
            string res = string.Empty;
            foreach (string word in message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (string letter in word.Split(' '))
                {
                    res += FindLetter(letter);
                }

                res += ' ';
            }

            return res;
        }

        /// <summary>
        /// Finds the character value of a morse code character.
        /// </summary>
        /// <param name="morseVal"> The morse code of the character. </param>
        /// <returns> The english character. </returns>
        public static char FindLetter(string morseVal)
        {
            foreach (char c in MorseCharacters.MorseCharacterValues.Keys)
            {
                if (MorseCharacters.MorseCharacterValues[c] == morseVal)
                {
                    return c;
                }
            }

            // Make unknown characters questions marks
            return '?';
        }
    }
}
