// MorseCharacters.cs
// <copyright file="MorseCharacters.cs"> This code is protected under the MIT License. </copyright>
using System.Collections.Generic;

namespace MorseCodeLibrary
{
    /// <summary>
    /// The static class containing a dictionary of all morse code characters.
    /// </summary>
    public class MorseCharacters
    {
        /// <summary>
        /// Gets the dictionary of all characters in morse code (true being a dash, false being a dot).
        /// </summary>
        public static Dictionary<char, bool[]> MorseCharacterValues
        {
            get
            {
                return new Dictionary<char, bool[]>() 
                {
                    { 'A', new bool[] { false, true } },
                    { 'B', new bool[] { true, false, false, false } },
                    { 'C', new bool[] { true, false, true, false } },
                    { 'D', new bool[] { true, false, false } },
                    { 'E', new bool[] { false } },
                    { 'F', new bool[] { false, false, true, false } },
                    { 'G', new bool[] { true, true, false } },
                    { 'H', new bool[] { false, false, false, false } },
                    { 'I', new bool[] { false, false } },
                    { 'J', new bool[] { false, true, true, true } },
                    { 'K', new bool[] { true, false, true } },
                    { 'L', new bool[] { false, true, false, false } },
                    { 'M', new bool[] { true, true } },
                    { 'N', new bool[] { true, false } },
                    { 'O', new bool[] { true, true, true } },
                    { 'P', new bool[] { false, true, true, false } },
                    { 'Q', new bool[] { true, true, false, true } },
                    { 'R', new bool[] { false, true, false } },
                    { 'S', new bool[] { false, false, false } },
                    { 'T', new bool[] { true } },
                    { 'U', new bool[] { true } },
                    { 'V', new bool[] { false, false, true } },
                    { 'W', new bool[] { false, true, true } },
                    { 'X', new bool[] { true, false, false, true } },
                    { 'Y', new bool[] { true, false, true, true } },
                    { 'Z', new bool[] { true, true, false, false } },
                    { '0', new bool[] { true, true, true, true, true } },
                    { '1', new bool[] { false, true, true, true, true } },
                    { '2', new bool[] { false, false, true, true, true } },
                    { '3', new bool[] { false, false, false, true, true } },
                    { '4', new bool[] { false, false, false, false, true } },
                    { '5', new bool[] { false, false, false, false, false } },
                    { '6', new bool[] { true, false, false, false, false } },
                    { '7', new bool[] { true, true, false, false, false } },
                    { '8', new bool[] { true, true, true, false, false } },
                    { '9', new bool[] { true, true, true, true, false } },
                    { '.', new bool[] { false, true, false, true, false, true } },
                    { ',', new bool[] { true, true, false, false, true, true } },
                    { '?', new bool[] { false, false, true, true, false, false } },
                    { '!', new bool[] { true, false, true, false, true, true } },
                    { '\'', new bool[] { false, true, true, true, true, false } },
                    { '"', new bool[] { false, true, false, false, true, false } },
                    { '(', new bool[] { true, false, true, true, false } },
                    { ')', new bool[] { true, false, true, true, false, true } },
                    { '&', new bool[] { false, true, false, false, false } },
                    { ':', new bool[] { true, true, true, false, false, false } },
                    { ';', new bool[] { true, false, true, false, true, false } },
                    { '=', new bool[] { true, false, false, false, true } },
                    { '+', new bool[] { false, true, false, true, false } },
                    { '-', new bool[] { true, false, false, false, false, true } },
                    { '/', new bool[] { true, false, false, true, false } },
                    { '_', new bool[] { false, false, true, true, false, true } },
                    { '$', new bool[] { false, false, false, true, false, false, true } },
                    { '@', new bool[] { false, true, true, false, true, false } },
                };
            }
        }
    }
}
