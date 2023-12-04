using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibCalculator;

namespace WinUI
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowResult(double result)
        {
            txtResult.Text = result.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
            txtTotal.ReadOnly = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double result = calculator.Add(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double result = calculator.Subtract(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double result = calculator.Multiply(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            double result = calculator.Divide(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }
    }
}
