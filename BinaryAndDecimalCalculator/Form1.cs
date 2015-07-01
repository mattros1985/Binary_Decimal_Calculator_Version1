using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryAndDecimalCalculator
{
    public partial class Form1 : Form
    {
        BinaryToDecimal binToDecObject = new BinaryToDecimal();
        DecimalToBinary decToBinObject = new DecimalToBinary();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Called by onButton event to enable components
        /// </summary>
        public void enable()
        {
            input1TxtBox.Enabled = true;
            input2TxtBox.Enabled = true;
            result2TxtBox.Enabled = true;
            result1TxtBox.Enabled = true;
            binToDecLabel.Show();
            DecToBinLabel.Show();
            enterButton.Show();
            enterButton2.Show();
            clearButton1.Show();
            clearButton2.Show();
        }
        /// <summary>
        /// Called by offButton to disable components
        /// </summary>
        public void disable()
        {
            input1TxtBox.Enabled = false;
            input2TxtBox.Enabled = false;
            result2TxtBox.Enabled = false;
            result1TxtBox.Enabled = false;
            binToDecLabel.Hide();
            DecToBinLabel.Hide();
            enterButton.Hide();
            enterButton2.Hide();
            clearButton1.Hide();
            clearButton2.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// stores input from input1TxtBox in proper object. Then
        /// takes result and stores it in result1TxtBox and initializes
        /// object variable to empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            decToBinObject.InputForDecimal(input1TxtBox.Text);
            result1TxtBox.Text = decToBinObject.Result.ToString();
            binToDecObject.BinaryString = "";
        }
        private void resultTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void inputTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DecToBin_Click(object sender, EventArgs e)
        {
        
        }
        private void binToDec_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// turns on display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onButton_Click(object sender, EventArgs e)
        {
            enable();
        }
        /// <summary>
        /// turns off display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void offButton_Click(object sender, EventArgs e)
        {
            disable();
        }
        /// <summary>
        /// Displays the rules for the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Enter your input and press enter\n 2. Enter only natural or valid binary numbers " );
        }
        /// <summary>
        /// clears decimal to binary text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton1_Click(object sender, EventArgs e)
        {
            decToBinObject.DecimalString.Clear();
            result1TxtBox.Text = "";
            input1TxtBox.Text = "";
        }
        /// <summary>
        /// stores input from input2TxtBox in proper object. Then
        /// takes result and stores it in result1TxtBox and initializes
        /// object variable to empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton2_Click(object sender, EventArgs e)
        {
            binToDecObject.BinaryString = input2TxtBox.Text;
            if(binToDecObject.StartsWithBinary())
                result2TxtBox.Text = binToDecObject.ResultofProgram.ToString();
            binToDecObject.BinaryString = "";
        }
        private void input2TxtBox_TextChanged(object sender, EventArgs e)
        {
  
        }
        private void result2TxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// clears binary to decimal textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton2_Click(object sender, EventArgs e)
        {
            binToDecObject.BinaryString = "";
            result2TxtBox.Text = "";
            input2TxtBox.Text = "";
        }
    }
}
