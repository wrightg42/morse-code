// MainWindow.xaml.cs
// <copyright file="MainWindow.xaml.cs"> This code is protected under the MIT License. </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.English.Text = rgx.Replace(this.English.Text, string.Empty);
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
            this.Morse.Text = rgx.Replace(this.Morse.Text, string.Empty);
        }
    }
}
