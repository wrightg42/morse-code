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
        public static Dictionary<char, string> MorseCharacterValues
        {
            get
            {
                return new Dictionary<char, string>() 
                {
                    { 'A', ".-" },
                    { 'B', "-..." },
                    { 'C', "-.-." },
                    { 'D', "-.." },
                    { 'E', "." },
                    { 'F', "..-." },
                    { 'G', "--." },
                    { 'H', "...." },
                    { 'I', ".." },
                    { 'J', ".---" },
                    { 'K', "-.-" },
                    { 'L', ".-.." },
                    { 'M', "--" },
                    { 'N', "-." },
                    { 'O', "---" },
                    { 'P', ".--." },
                    { 'Q', "--.-" },
                    { 'R', ".-." },
                    { 'S', "..." },
                    { 'T', "-" },
                    { 'U', "..-" },
                    { 'V', "...-" },
                    { 'W', ".--" },
                    { 'X', "-..-" },
                    { 'Y', "-.--" },
                    { 'Z', "--.." },
                    { '0', "-----" },
                    { '1', ".----" },
                    { '2', "..---" },
                    { '3', "...--" },
                    { '4', "....-" },
                    { '5', "....." },
                    { '6', "-...." },
                    { '7', "--..." },
                    { '8', "---.." },
                    { '9', "----." },
                    { '.', ".-.-.-" },
                    { ',', "--..--" },
                    { '?', "..--.." },
                    { '!', "-.-.--" },
                    { '\'', ".----." },
                    { '"', ".-..-." },
                    { '(', "-.--." },
                    { ')', "-.--.-" },
                    { '&', ".-..." },
                    { ':', "---..." },
                    { ';', "-.-.-." },
                    { '=', "-...-" },
                    { '+', ".-.-." },
                    { '-', "-....-" },
                    { '/', "-..-." },
                    { '_', "..--.-" },
                    { '$', "...-..-" },
                    { '@', ".--.-." },
                    { '%', ".-.-.- -..-. .-.-.-"}
                };
            }
        }
    }
}
