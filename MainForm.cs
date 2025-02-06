using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_work
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            tbInput.Text += " + ";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbInput.Text += "9";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tbInput.Text += " - ";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbInput.Text += "6";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            tbInput.Text += " * ";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbInput.Text += "3";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            tbInput.Text += " / ";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            tbInput.Text += ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbInput.Text += "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
        }
                
        private void btnSin_Click(object sender, EventArgs e)
        {
            tbInput.Text = "sin ";
        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            tbInput.Text = "asin ";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            tbInput.Text = "log ";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            tbInput.Text = "sqrt ";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            tbInput.Text = " ";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            tbInput.Text = "cos ";
        }

        private void btnAcos_Click(object sender, EventArgs e)
        {
            tbInput.Text = "acos ";
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            tbInput.Text = "log10 ";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            tbInput.Text = "pow ";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbInput.Text = " ";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            tbInput.Text = "tan ";
        }

        private void btnAtan_Click(object sender, EventArgs e)
        {
            tbInput.Text = "atan";
        }

        private void btnAtan2_Click(object sender, EventArgs e)
        {
            tbInput.Text = "atan2 ";
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            tbInput.Text = "Abs ";
        }

        private void btnRes_Click(object sender, EventArgs e)
        {

        }

        // парсер
        //для +-*/ промежуточ рез

    }
}
