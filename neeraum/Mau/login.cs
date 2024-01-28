using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mau
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pass = "admin";
            string user = "admin";

            if (textBox1.Text == user && textBox2.Text == pass)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                
            }
            else if (textBox1.Text != user && textBox2.Text == pass)
            {
                MessageBox.Show("Wrong User!");
            }
            else if (textBox1.Text == user && textBox2.Text != pass)
            {
                MessageBox.Show("Wrong Password!");
            }
            else {
                MessageBox.Show("Both Username and Password are incorrect");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
