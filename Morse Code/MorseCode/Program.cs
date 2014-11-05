// Program.cs
// <copyright file="Program.cs"> This code is protected under the MIT License. </copyright>
using System;
using MorseCodeLibrary;
using MorseCodeLibrary.Conversions;

namespace MorseCode
{
    /// <summary>
    /// The main program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args"> Arguments to be compiled with. </param>
        public static void Main(string[] args)
        {
            string morseMessage = ConvertToMorse.Convert("sos. Testing 123!");
            if (Validation.ValidMessage(morseMessage, true))
            {
                Console.WriteLine(morseMessage);
                Console.WriteLine(ConvertFromMorse.Convert(morseMessage));
                PlayMorse.PlayMessage(morseMessage);
            }
        }
    }
}
