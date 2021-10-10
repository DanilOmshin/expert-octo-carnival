using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nN.Value > 0)
            {
                num_rat num_Rat = new num_rat();
                label4.Text=num_Rat.read_string(rRate.Text,Convert.ToInt32(nN.Value));
            }
            else
                MessageBox.Show("Введите количество оценок!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nN.Value = 1;
            rRate.Text = "";
            label4.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.NuD = nN.Value;
            Properties.Settings.Default.RT = rRate.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nN.Value = Properties.Settings.Default.NuD;
            rRate.Text = Properties.Settings.Default.RT;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void rRate_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void rRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ' ')
            {
                e.Handled = true;
            }
        }

        private void nN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
