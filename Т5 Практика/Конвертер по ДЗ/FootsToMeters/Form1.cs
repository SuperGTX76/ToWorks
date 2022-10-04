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
            AssignNum(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignNum(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssignNum(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignNum(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignNum(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AssignNum(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AssignNum(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AssignNum(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AssignNum(button9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1)
                return;

            AssignNum(button0);
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;

            var value = Convert.ToDouble(_valueToConvert) * -1;
            _valueToConvert = value.ToString();

            UpgradeFootsLabel();
            UpgradeMetersLabel();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;

            AssignZeroValue();
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1)
                return;

            if (_valueToConvert.Contains(_comma))
                return;

            AssignNum(Comma);

        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1)
            {
                AssignZeroValue();
                return;
            }

                _valueToConvert = _valueToConvert.Remove(_valueToConvert.Length - 1, 1);

                UpgradeFootsLabel();
                UpgradeMetersLabel();
            
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
            string meterText2 = Convert.ToString(meters); //.Substring(0, MAX_STRING_LENGHT);
            if (meterText2[meterText2.Length - 1] == _comma)
            meterText2 = meterText2.Remove(meterText2.Length - 1, 1);
            MetersLabel.Text = meterText2;
        }

        private void AssignZeroValue()
        {
            _valueToConvert = String.Empty;
            FootsLabel.Text = "0";
            MetersLabel.Text = "0";
        }

        

    }
}
