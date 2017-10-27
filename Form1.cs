using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A square of squares
//You like building blocks. You especially like building blocks that are squares.
//And what you even like more, is to arrange them into a square of square building blocks!
//However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary rectangle!
//Those blasted things! If you just had a way to know, whether you're currently working in vain… Wait! That's it! You just have to check if your number of building blocks is a perfect square.

//Task
//Given an integral number, determine if it's a square number:
//In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.
//The tests will always use some integral number, so don't worry about that in dynamic typed languages.

//Examples

//Kata.isSquare(-1) // => false
//Kata.isSquare( 3) // => false
//Kata.isSquare( 4) // => true
//Kata.isSquare(25) // => true
//Kata.isSquare(26) // => false

//best solution:
//using System;

//public class Kata
//{
//    public static bool IsSquare(int n)
//    {
//        return Math.Sqrt(n) % 1 == 0;
//    }
//}


namespace Codewars_You_re_a_square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isSquare(string number)
        {
            bool result;
            try
            {
                double num_double = Convert.ToDouble(number);
                result = Math.Sqrt(num_double) % 1 == 0;
            }
            catch (FormatException)
            { result = false; }
            catch (IndexOutOfRangeException)
            { result = false; }

            return result;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            textBox_output.Text = isSquare(textBox_input.Text).ToString();
        }
    }
}
