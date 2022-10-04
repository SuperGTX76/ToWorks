using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter2
{
    public partial class Converters : Form
    {

        private const int MAX_STRING_LENGHT = 10;

        private string _valueToConvert = string.Empty;
        private readonly char _comma = ',';

        public Converters()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Button

        private void button1_Click(object sender, EventArgs e)
        {
            AsssignNum(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsssignNum(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsssignNum(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AsssignNum(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AsssignNum(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AsssignNum(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AsssignNum(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AsssignNum(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AsssignNum(button9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(_valueToConvert.Length < 1)
                return;

            AsssignNum(button0);
        }
        
        private void negativeButton_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;

            var value = Convert.ToDouble(_valueToConvert) * -1;
            _valueToConvert = value.ToString();

            UpdateDegreesLabel();
            UpdateRadianLabel();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;

            AssignZeroValue();
        }
        
        private void buttonBS_Click(object sender, EventArgs e)
        {

            if (_valueToConvert.Length <= 1)
            {
                AssignZeroValue();
                return;
            }


            _valueToConvert = _valueToConvert.Remove(_valueToConvert.Length - 1, 1);

            UpdateDegreesLabel();
            UpdateRadianLabel();
        }

        #endregion



        private void AsssignNum(Button button)
        {
            if(_valueToConvert.Length >= MAX_STRING_LENGHT)
                return;

            _valueToConvert += button.Text;

            UpdateDegreesLabel();
            UpdateRadianLabel();
        }

        private void UpdateDegreesLabel()
        {
            DegreeseLabel.Text = _valueToConvert;
        }

        private void UpdateRadianLabel()
        {
            var valueToConvert = Convert.ToDouble(_valueToConvert);
            var radians = valueToConvert * 0.3d;
            var radianText = Convert.ToString(radians).Substring(0, MAX_STRING_LENGHT);

            if (radianText[radianText.Length - 1] == _comma)
                radianText = radianText.Remove(radianText.Length - 1, 1);
            RadianLabel.Text = radianText;
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Contains(_comma))
                return;

            if(_valueToConvert.Length < 1)
                return;

            AsssignNum(Comma);
        }

        

        private void AssignZeroValue()
        {
            _valueToConvert = String.Empty;
            DegreeseLabel.Text = "0";
            RadianLabel.Text="0";

        }

        
    }
}
