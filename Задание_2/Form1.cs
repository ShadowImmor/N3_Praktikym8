using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Chek_Click(object sender, EventArgs e)
        {
            Is.Clear();
            string str = Text.Text, word = Word.Text;
            if (word == "")
                return;
            Regex reg = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
            if (reg.IsMatch(str))
                Is.Text = "да";
            else
                Is.Text = "нет";
        }
        private void Word_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"(\W)"))
            {
                e.Handled = true;
            }
        }
    }
}
