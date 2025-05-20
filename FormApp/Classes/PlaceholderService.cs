using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public class PlaceholderService
    {
        public static void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Tag = placeholderText; // store the placeholder text in the tag property
            textBox.Text = placeholderText; // set the placeholder text inside the text box
            textBox.ForeColor = Color.Gray; // change the text color to gray

            // remove placeholder text when the textbox gains focus
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == (string)textBox.Tag) // check if the current text matches the placeholder
                {
                    textBox.Text = ""; // clear the textbox
                    textBox.ForeColor = Color.Black; // change text color to black for user input
                }
            };

            // restore placeholder text when the textbox loses focus
            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) // check if the text field is empty
                {
                    textBox.Text = (string)textBox.Tag; // restore placeholder text
                    textBox.ForeColor = Color.Gray; // change text color back to gray
                }
            };
        }
    }
}
