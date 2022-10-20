using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String opPerformed = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textbox_result.Text == "0") || (isOpPerformed) )
                textbox_result.Clear();

            isOpPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (textbox_result.Text.Contains("."))
                    textbox_result.Text = textbox_result.Text + button.Text;
            }else
            textbox_result.Text = textbox_result.Text + button.Text;
        
        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button17.PerformClick();
                opPerformed = button.Text;
                labelCurOp.Text = result + " " + opPerformed;
                isOpPerformed = true;
            }
            else
            {
                opPerformed = button.Text;
                result = Double.Parse(textbox_result.Text);
                labelCurOp.Text = result + " " + opPerformed;
                isOpPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(opPerformed)
            {
                case "+":
                    textbox_result.Text = (result + Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "-":
                    textbox_result.Text = (result + Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "*":
                    textbox_result.Text = (result + Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "/":
                    textbox_result.Text = (result + Double.Parse(textbox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textbox_result.Text);
            labelCurOp.Text = "";
        }
    }
}
