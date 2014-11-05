// Validation.cs
// <copyright file="Validation.cs"> This code is protected under the MIT License. </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeLibrary.Conversions
{
    /// <summary>
    /// A static class with validation for validating messages (in morse and english form) so they can be played or translated.
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Checks if a message is valid and won't throw errors when being played.
        /// </summary>
        /// <param name="message"> The message to check. </param>
        /// <param name="isMorseForm"> Whether the message is in morse form. </param>
        /// <returns> Whether the message is valid. </returns>
        public static bool ValidMessage(string message, bool isMorseForm = false)
        {
            if (isMorseForm)
            {
                return ValidMorse(message);
            }
            else
            {
                return ValidEnglish(message);
            }
        }

        /// <summary>
        /// Validates english to see if it can be converted to morse code.
        /// </summary>
        /// <param name="message"> The message. </param>
        /// <returns> Whether the message is valid. </returns>
        public static bool ValidEnglish(string message)
        {
            // Make the message upper case
            message = message.ToUpper();

            // Check each character is valid
            foreach (string word in message.Split(' '))
            {
                foreach (char c in word)
                {
                    if (!MorseCharacters.MorseCharacterValues.ContainsKey(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Validates a morse message.
        /// </summary>
        /// <param name="message"> The message. </param>
        /// <returns> Whether the message is valid. </returns>
        public static bool ValidMorse(string message)
        {
            // Make the message upper case
            message = message.ToUpper();

            // Check each letter is valid
            foreach (string word in message.Split(new char[] { '\\', '|', '/' }, StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (string letter in word.Split(' '))
                {
                    if (!MorseCharacters.MorseCharacterValues.ContainsValue(letter))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
