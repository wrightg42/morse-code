// MainWindow.xaml.cs
// <copyright file="MainWindow.xaml.cs"> This code is protected under the MIT License. </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MorseCodeLibrary.Conversions;

namespace MorseCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Makes sure that the english text box contains only recognized characters.
        /// </summary>
        /// <param name="sender"> What raised the event. </param>
        /// <param name="e"> The event arguments. </param>
        private void English_TextChanged(object sender, TextChangedEventArgs e)
        {
            // The regex pattern
            Regex rgx = new Regex("[^a-zA-Z0-9 .,?!'\"()&:;=+-/_$@%]");

            // Remove all character from the textbox that arn't in the regex
            int selectIndex = this.English.SelectionStart;
            string origText = this.English.Text;
            this.English.Text = rgx.Replace(this.English.Text, string.Empty);

            // Play a sound and set the selection index if there was an invalid character
            if (origText != this.English.Text)
            {
                this.English.SelectionStart = selectIndex - 1;
                SystemSounds.Beep.Play();                
            }
        }

        /// <summary>
        /// Makes sure that the morse code text box contains only characters for morse code strings.
        /// </summary>
        /// <param name="sender"> What raised the event. </param>
        /// <param name="e"> The event arguments. </param>
        private void Morse_TextChanged(object sender, TextChangedEventArgs e)
        {
            // The regex pattern
            Regex rgx = new Regex("[^-. |]");
            
            // Remove all character from the textbox that arn't in the regex
            int selectIndex = this.Morse.SelectionStart;
            string origText = this.Morse.Text;
            this.Morse.Text = rgx.Replace(this.Morse.Text, string.Empty);

            // Play a sound and set the selection index if there was an invalid character
            if (origText != this.Morse.Text)
            {
                this.Morse.SelectionStart = selectIndex - 1;
                SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// Translates the English message to a morse message.
        /// </summary>
        /// <param name="sender"> What raised the event. </param>
        /// <param name="e"> The event arguments. </param>
        private void TransToMorse_Click(object sender, RoutedEventArgs e)
        {
            // Only translate if the english textbox has content
            if (this.English.Text != string.Empty)
            {
                this.Morse.Text = ConvertToMorse.Convert(this.English.Text);
            }
        }

        /// <summary>
        /// Translates the morse message to a english message.
        /// </summary>
        /// <param name="sender"> What raised the event. </param>
        /// <param name="e"> The event arguments. </param>
        private void TransToEng_Click(object sender, RoutedEventArgs e)
        {
            // Only translate if the morse textbox has content
            if (this.Morse.Text != string.Empty)
            {
                this.English.Text = ConvertFromMorse.Convert(this.Morse.Text);
            }
        }
        
        /// <summary>
        /// Plays the inputted message.
        /// </summary>
        /// <param name="sender"> What raised the event. </param>
        /// <param name="e"> The event arguments. </param>
        private void Play_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
