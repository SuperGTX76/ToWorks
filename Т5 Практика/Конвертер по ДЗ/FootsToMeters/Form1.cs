using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootsToMeters
{
    public partial class Form1 : Form
    {
        private const int MAX_STRING_LENGHT = 10;

        private string _valueToConvert = String.Empty;
        private readonly char _comma = ',';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void negativeButton_Click(object sender, EventArgs e)
        {

        }

        private void Comma_Click(object sender, EventArgs e)
        {

        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void AssignNum(Button button)
        {
            if (_valueToConvert.Length >= MAX_STRING_LENGHT)
                return;
            _valueToConvert += button.Text;

            UpgradeFootsLabel();
            UpgradeMetersLabel();

        }

        private void UpgradeFootsLabel()
        {
            FootsLabel.Text = _valueToConvert;
        }

        private void UpgradeMetersLabel()
        {
            var valueToConvert = Convert.ToDouble(_valueToConvert);
            var meters = valueToConvert * 0.30d;



        }
    }
}
