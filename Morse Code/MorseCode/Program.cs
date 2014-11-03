// Program.cs
// <copyright file="Program.cs"> This code is protected under the MIT License. </copyright>
using System;
using MoresCodeLibrary;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if (PlayMorse.ValidMessage("sos. Testing 123!"))
            {
                PlayMorse.PlayMessage("sos. Testing 123!");
            }
        }
    }
}
