using System;
using System.Windows.Controls;

namespace TypeKid
{
    static class TextBoxExtensions
    {
        /// <summary>
        /// Appends a string to the contents of a text control. The original method has a problem
        /// where sometimes the caret position is not updated. This one does not.
        /// </summary>
        /// <param name="textBox">The textBox?</param>
        /// <param name="textData">A string that specifies the text to append to the current contents of the text control.</param>
        public static void AppendTextEx(this TextBox textBox, string textData)
        {
            Int32 lastLocation = textBox.SelectionStart;
            textBox.Text = textBox.Text.Insert(lastLocation, textData);
            textBox.SelectionStart = lastLocation + 1;
        }
    }
}
