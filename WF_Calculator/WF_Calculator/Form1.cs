using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Calculator
{
    public partial class Calculator : Form
    {
        private string _firstnumber = "";
        private string _oper = "";
        public Calculator()
        {
            InitializeComponent();
            toolTip1.SetToolTip(textBox1, "if you see Error push CE");
        }

        private bool firstOper = true;
        private void NumberBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0") 
            { 
                textBox1.Text = "";
            }
            if (firstOper) 
            {
                textBox1.Text = "";
                firstOper = false;
            }
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            _firstnumber = textBox1.Text;
            firstOper = true;
            //textBox1.Text = "0";
            _oper = "+";
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            _firstnumber = textBox1.Text;
            firstOper = true;
            //textBox1.Text = "0";
            _oper = "-";
        }
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            _firstnumber = textBox1.Text;
            firstOper = true;
            //textBox1.Text = "0";
            _oper = "*";
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            _firstnumber = textBox1.Text;
            firstOper = true;
            //textBox1.Text = "0";
            _oper = "/";
        }
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (firstOper) 
            {
                textBox1.Text = "0,";
                firstOper = false;
            }
            if (!textBox1.Text.Contains(',')) 
            {
                textBox1.Text += ",";
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (textBox1.Text =="") 
            { 
                textBox1.Text = "0";
            }
        }
        private void BtnDeleteAll_Click(object sender, EventArgs e) 
        {
            textBox1.Clear();
            textBox1.Text = "0";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button18.Enabled = true;
        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            firstOper = true;
            switch (_oper)
            {
                case "+":
                    textBox1.Text = (Convert.ToDouble(_firstnumber) + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Convert.ToDouble(_firstnumber) - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (Convert.ToDouble(_firstnumber) * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Convert.ToDouble(textBox1.Text) != 0)
                    {
                        textBox1.Text = (Convert.ToDouble(_firstnumber) / Convert.ToDouble(textBox1.Text)).ToString();
                    }
                    else 
                    {
                        textBox1.Text = "Error";
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button8.Enabled = false;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        button11.Enabled = false;
                        button12.Enabled = false;
                        button13.Enabled = false;
                        button14.Enabled = false;
                        button15.Enabled = false;
                        button16.Enabled = false;
                        button18.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
