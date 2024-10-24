using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if ((txt_user.Text == "") || (txt_password.Text == ""))
            {
                MessageBox.Show("Vui long nhap thong tin dang nhap!", "Thong bao");
            }
            else
            {
                if ((txt_user.Text == "admin") || (txt_password.Text == "1234"))
                {
                    MessageBox.Show("Dang nhap thanh cong!", "Thong bao");
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai!", "Thong bao");
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
