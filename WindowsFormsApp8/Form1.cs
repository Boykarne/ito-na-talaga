using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int PW;
        bool Hiddedn;
        public Form1()
        {
            InitializeComponent();
            PW = 800;
            Hiddedn = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnhide_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void txtPassword2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Hiddedn)
            {
                Signinpanel.Width = Signinpanel.Width - 196;
                if (Signinpanel.Width >= 302)
                {
                    timer1.Stop();
                    Hiddedn = false;
                    this.Refresh();
                }
            }
            else
            {
                Signinpanel.Width = Signinpanel.Width + 196;
                if (Signinpanel.Width <= PW)
                {
                    timer1.Stop();
                    Hiddedn = true;
                    this.Refresh();
                }

            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}


