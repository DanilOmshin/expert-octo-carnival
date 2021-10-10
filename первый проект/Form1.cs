using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbA.Validating += tbA_Validating;
            tbB.Validating += tbB_Validating;
            tbC.Validating += tbC_Validating;
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            tbA.Text = Properties.Settings.Default.A;
            tbB.Text = Properties.Settings.Default.B;
            tbC.Text = Properties.Settings.Default.C;
            rez.Text = Properties.Settings.Default.Rez;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                num num = new num();
                rez.Text = num.Get(Convert.ToDouble(tbA.Text), Convert.ToDouble(tbB.Text), Convert.ToDouble(tbC.Text));
            }
            else
            {
                var listOfErrors = this.errorProvider1.ContainerControl.Controls.Cast<Control>()
                                       .Select(c => this.errorProvider1.GetError(c))
                                       .Where(s => !string.IsNullOrEmpty(s))
                                       .ToList();
                MessageBox.Show("Пожалуйста, исправьте следующие ошибки:\n - " +
                    string.Join("\n - ", listOfErrors.ToArray()),
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbA_Validating(object sender, CancelEventArgs e)
        {
            // Вывод ошибки, если текстбокс пустой
            double check = 0;
            if (tbA.Text == "")
            {
                errorProvider1.SetError(tbA, "Вы не ввели данные");
                e.Cancel = true;
            }
            else if (!double.TryParse(tbA.Text, out check))
            {
                errorProvider1.SetError(tbA, "Некорретное число!");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.tbA, "");
            }
        }

        private void tbB_Validating(object sender, CancelEventArgs e)
        {
            // Вывод ошибки, если текстбокс пустой
            double check = 0;
            if (tbB.Text == "")
            {
                errorProvider1.SetError(tbB, "Вы не ввели данные");
                e.Cancel = true;
            }
            else if (!double.TryParse(tbB.Text, out check))
            {
                errorProvider1.SetError(tbB, "Некорретное число!");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.tbB, "");
            }
        }

        private void tbC_Validating(object sender, CancelEventArgs e)
        {
            // Вывод ошибки, если текстбокс пустой
            double check = 0;
            if (tbC.Text == "")
            {
                errorProvider1.SetError(tbC, "Вы не ввели данные");
                e.Cancel = true;
            }
            else if (!double.TryParse(tbC.Text, out check))
            {
                errorProvider1.SetError(tbC, "Некорретное число!");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.tbC, "");
            }
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";
            rez.Text = "";
            this.errorProvider1.SetError(this.tbA, "");
            this.errorProvider1.SetError(this.tbB, "");
            this.errorProvider1.SetError(this.tbC, "");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.A = tbA.Text;
            Properties.Settings.Default.B = tbB.Text;
            Properties.Settings.Default.C = tbC.Text;
            Properties.Settings.Default.Rez = rez.Text;
            Properties.Settings.Default.Save();

        }
    }
}
