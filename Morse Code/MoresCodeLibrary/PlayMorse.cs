﻿// PlayMorse.cs
// <copyright file="PlayMorse.cs"> This code is protected under the MIT License. </copyright>
using System;
using System.Collections.Generic;
using System.Threading;
using MorseCodeLibrary.Conversions;
using MorseCodeLibrary.Exceptions;

namespace MorseCodeLibrary
{
    /// <summary>
    /// The static class containing methods to play morse code.
    /// </summary>
    public static class PlayMorse
    {
        /// <summary>
        /// The frequency the morse code is played at.
        /// </summary>
        private const int Frequency = 775;

        /// <summary>
        /// Gets or sets how many milliseconds a dot is worth.
        /// </summary>
        public static int DotLength { get; set; }

        /// <summary>
        /// Plays a message.
        /// </summary>
        /// <param name="message"> The message. </param>
        /// <param name="isChars"> Whether the message is letters or in morse form. </param>
        /// <param name="dotLength"> The length of one dot in milliseconds. </param>
        public static void PlayMessage(string message, bool isChars = true, int dotLength = 90)
        {
            // Set the dotlength
            DotLength = dotLength;

            // Make all letters upper case so that the letters are recognisable keys
            message = message.ToUpper();

            if (isChars)
            {
                // Play each word in the message
                foreach (string word in message.Split(' '))
                {
                    PlayWord(word, isChars);
                }
            }
            else
            {
                // Play each set of dots and dashes forming a word
                foreach (string word in message.Split(new char[] { '\\', '|', '/' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    PlayWord(word, isChars);
                }
            }
        }

        /// <summary>
        /// Plays a word.
        /// </summary>
        /// <param name="word"> The word. </param>
        /// <param name="isChars"> Whether the word is letters or in morse form. </param>
        public static void PlayWord(string word, bool isChars = true)
        {
            if (isChars)
            {
                // If the word is in character form play each letter
                foreach (char c in word)
                {
                    PlayCharacter(c);
                }
            }
            else
            {
                // If the word is in morse form play each section splitted by spaces
                foreach (string charSet in word.Split(' '))
                {
                    PlayCharacter(charSet);
                }
            }

            WordGap();
        }

        /// <summary>
        /// Plays a character. 
        /// </summary>
        /// <param name="c"> The character to play. </param>
        public static void PlayCharacter(char c)
        {
            // Make sure the character is a registered morse character
            if (MorseCharacters.MorseCharacterValues.ContainsKey(c))
            {
                // Get the dash values for each part of the morse character and play them
                bool[] dashes = MorseCharacters.MorseCharacterValues[c];
                foreach (bool dash in dashes)
                {
                    PlaySound(dash);
                }

                LetterGap();
            }
            else
            {
                // Throw an invalid character excpetion if the character was not recognised
                throw new InvalidCharacterExcpetion(c.ToString(), false);                     
            }
        }

        /// <summary>
        /// Plays a character.
        /// </summary>
        /// <param name="c"> The character to play in morse form. </param>
        public static void PlayCharacter(string c)
        {
            // Validate the morse code
            if (Validation.ValidMorseFormLetter(c))
            {
                // Play each morse value from the string of dots and dashes
                foreach (char dashVal in c)
                {
                    if (dashVal == '.')
                    {
                        PlaySound(false);
                    }
                    else if (dashVal == '-')
                    {
                        PlaySound(true);
                    }
                }

                LetterGap();
            }
            else
            {
                // Throw an invalid character excpetion if the character was not recognised
                throw new InvalidCharacterExcpetion(c, true);
            }
        }

        /// <summary>
        /// Plays a sound for the appropriate length for morse code.
        /// </summary>
        /// <param name="dash"> Whether the sound being played is a dot or dash. </param>
        public static void PlaySound(bool dash)
        {
            if (dash)
            {
                Console.Beep(Frequency, DotLength * 3);
            }
            else
            {
                Console.Beep(Frequency, DotLength);
            }

            Gap();
        }

        /// <summary>
        /// Stops the thread for the gap between sounds.
        /// </summary>
        public static void Gap()
        {
            Thread.Sleep(DotLength);
        }
        
        /// <summary>
        /// Stops the thread for the gap between letters.
        /// </summary>
        public static void LetterGap()
        {
            Thread.Sleep(DotLength * 3);
        }

        /// <summary>
        /// Stops the thread for the gap between words.
        /// </summary>
        public static void WordGap()
        {
            Thread.Sleep(DotLength * 7);
        }
    }
}