using System;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private static bool SeqSimple(int a)
        { 
            for (int i = 2; i <= (int)(a / 2); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_number.Text == string.Empty)
            {
                MessageBox.Show("Введите число");
            }
            else if (Convert.ToInt32(txt_number.Text) >= 50000)
            {
                MessageBox.Show("Введите число меньше 50000");
            }
            else
            {
                rich1.Clear();
                rich2.Clear();
                bool f = false;
                int count = 0;

                int b = int.Parse(txt_number.Text);
                int x = b;
                for (int i = 2; (i <= b) && (count < 3); i++)
                {
                    if (SeqSimple(i))
                    {
                        if (b % i == 0)
                        {
                            x = x / i;
                            count++;
                            rich2.Text = rich2.Text + i.ToString() + "*";
                        }
                        if ((b % i != 0) && (count == 2))
                        {
                            f = true;
                        }
                        rich1.Text = rich1.Text + i.ToString() + "\r";
                    }
                }

                if ((count == 3) && (f == false) && (x == 1))
                {
                    rich2.Text = "Да, " + rich2.Text.Remove(rich2.Text.Length - 1) + "=" + b.ToString() + "\r";
                }
                else rich2.Text = "Нет" + "\r";
            }
        } 

        private void clear_Click(object sender, EventArgs e)
        {
            txt_number.Clear();
            rich1.Clear();
            rich2.Clear();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
