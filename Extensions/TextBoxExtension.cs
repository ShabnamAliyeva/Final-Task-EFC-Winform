using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Extensions
{
    static class TextBoxExtension
    {
        public static bool IsEmpty(this TextBox textBox)
            => string.IsNullOrEmpty(textBox.Text);

        public static bool IsGreaterThan(this TextBox textBox, int number)
            => Convert.ToInt32(textBox.Text) == number;

        public static double ToInt(this TextBox textBox)
            => Convert.ToDouble(textBox.Text);

    }
}
