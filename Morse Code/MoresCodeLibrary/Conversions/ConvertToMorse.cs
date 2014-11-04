// ConvertToMorse.cs
// <copyright file="ConvertToMorse.cs"> This code is protected under the MIT License. </copyright>

namespace MorseCodeLibrary.Conversions
{
    /// <summary>
    /// A static class to convert a string into morse code.
    /// </summary>
    public static class ConvertToMorse
    {
        /// <summary>
        /// Converts plain text to morse code.
        /// </summary>
        /// <param name="message"> The plain text. </param>
        /// <returns> The morse code. Null if it could not convert it. </returns>
        public static string Convert(string message)
        {
            // Make the message upper case so it has recognisable characters
            message = message.ToUpper();

            // Return null if the message is not valid
            if (!PlayMorse.ValidMessage(message))
            {
                return null;
            }
            else
            {
                // Otherwise convert it
                string res = string.Empty;

                // Split by word
                foreach (string word in message.Split(' '))
                {
                    // Say a space does not need to be added
                    bool addSpace = false;

                    // Split by characters in the word
                    foreach (char c in word)
                    {
                        // Add the character gap signifier if it needs to be added
                        if (!addSpace)
                        {
                            addSpace = !addSpace;
                        }
                        else
                        {
                            res += ' ';
                        }

                        // Add each dot or dash that makes up a character
                        foreach (bool b in MorseCharacters.MorseCharacterValues[c])
                        {
                            if (b)
                            {
                                res += '-';
                            }
                            else
                            {
                                res += '.';
                            }
                        }
                    }

                    // Add the word gap signifier
                    res += '|';
                }

                return res;
            }
        }
    }
}
