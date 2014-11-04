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
            // Make the message upper case
            message = message.ToUpper();

            if (isMorseForm)
            {
                // If the message is in morse form check each letter is valid
                foreach (string word in message.Split(new char[] { '\\', '|', '/' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    foreach (string letter in word.Split(' '))
                    {
                        if (!ValidMorseFormLetter(letter))
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                // Otherwise check each character is is valid
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
            }

            return true;
        }

        /// <summary>
        /// Check a string of morse letters is valid.
        /// </summary>
        /// <param name="charSet"> The string of dots and dashes to be validated. </param>
        /// <returns> Whether the string of morse characters is valid. </returns>
        public static bool ValidMorseFormLetter(string charSet)
        {
            // Get a list of boolean values to check its a letter
            List<bool> boolVals = new List<bool>();

            // Check each dot and dash
            foreach (char c in charSet)
            {
                if (c == '.')
                {
                    boolVals.Add(false);
                }
                else if (c == '-')
                {
                    boolVals.Add(true);
                }
                else
                {
                    return false;
                }
            }
            
            // Check the boolean values create a proper letter
            if (ValidDotsAndDashes(boolVals.ToArray()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks whether a set of boolean values representing morse code is a valid character.
        /// </summary>
        /// <param name="boolVals"> The boolean values representing the morse code. </param>
        /// <returns> Whether it is a valid morse code. </returns>
        public static bool ValidDotsAndDashes(bool[] boolVals)
        {
            // Check every possible value
            foreach (bool[] b in MorseCharacters.MorseCharacterValues.Values)
            {
                // Only check the bool values if it is the same length
                if (b.Length == boolVals.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        // Break the loop if the values are different
                        if (b[i] != boolVals[i])
                        {
                            break;
                        }
                        else if (i == b.Length - 1)
                        {
                            // Return true if all values are the same
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
