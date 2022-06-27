/* This program is designed to take a recipe, scramble it, and create a new recipe!
 * Written by Tristan Rogers 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrambler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the form
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txtResult.Clear();
        }

        private void btnScramble_Click(object sender, EventArgs e)
        {
            // Scrambles the words and display new recipe
            txtResult.Text = textBox4.Text + " " + textBox3.Text + " " + textBox2.Text + " " + textBox1.Text;
        }
    }
}
