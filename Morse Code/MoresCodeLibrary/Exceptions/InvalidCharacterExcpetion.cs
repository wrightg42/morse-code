// InvalidCharacterExcpetion.cs
// <copyright file="InvalidCharacterExcpetion.cs"> This code is protected under the MIT License. </copyright>
using System;

namespace MorseCodeLibrary.Exceptions
{
    /// <summary>
    /// An exception for invalid/unrecognized characters being used.
    /// </summary>
    public class InvalidCharacterExcpetion : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCharacterExcpetion" /> class.
        /// </summary>
        /// <param name="character"> The character (in morse or english form). </param>
        /// <param name="isInMorse"> Whether the character is in morse form. </param>
        public InvalidCharacterExcpetion(string character, bool isInMorse)
        {
            this.Character = character;
        }

        /// <summary>
        /// Gets or sets the character that was not invalid/recognized.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the character is in morse form.
        /// </summary>
        public bool IsInMorse { get; set; }
    }
}
