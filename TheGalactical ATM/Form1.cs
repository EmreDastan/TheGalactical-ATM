using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGalactical_ATM
{
    /* Creator credits :
    Yunus Emre Daştan
    */

    public partial class Form1 : Form
    {
        // Variables
        private string enterednumber = "";
        private double money = 0.0;
        private string moneyinfo = "";

        
        private void MoneyToString()
        {
            // Converts money variable to string to display
            moneyinfo = Convert.ToString(money);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            // Increases the amount of money
            Display.Text = "";
            money += Convert.ToDouble(enterednumber);
            enterednumber = "";
        }

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            // Decreases the amount of money
            Display.Text = "";
            money -= Convert.ToDouble(enterednumber);
            if (money < 0) money = 0;
            enterednumber = "";
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            // Shows information about current money
            Display.Text = "";
            MoneyToString();
            Display.Text = moneyinfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "1";
            Display.Text = enterednumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "2";
            Display.Text = enterednumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "3";
            Display.Text = enterednumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "4";
            Display.Text = enterednumber;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "5";
            Display.Text = enterednumber;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "6";
            Display.Text = enterednumber;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "7";
            Display.Text = enterednumber;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "8";
            Display.Text = enterednumber;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "9";
            Display.Text = enterednumber;
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += ".";
            Display.Text = enterednumber;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            // Resets the display screen. Money stays same.
            Display.Text = "";
            enterednumber = "";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enterednumber += "0";
            Display.Text = enterednumber;
        }
    }
}
