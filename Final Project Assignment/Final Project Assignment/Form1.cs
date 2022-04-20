using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string User = textBoxUser.Text;
            string Password = textBoxPassword.Text;

            if (User == "Admin001" & Password == "LoginUser001")
            {
                form2.Show();
                this.Hide();
            }
            else if (User == "" & Password == "")
            {
                MessageBox.Show("คุณไม่ได้กรอกชื่อผู้ใช้ และ รหัสผ่าน", "เกิดข้อผิดพลาด");
            }
            else if (User == "")
            {
                MessageBox.Show("คุณไม่ได้กรอกชื่อผู้ใช้", "เกิดข้อผิดพลาด");
                textBoxPassword.Text = "";
            }
            else if (Password == "")
            {
                MessageBox.Show("คุณไม่ได้กรอกรหัสผ่าน", "เกิดข้อผิดพลาด");
                textBoxUser.Text = "";
            }
            else
            {
                MessageBox.Show("คุณกรอกชื่อผู้ใช้หรือรหัสผ่านผิด", "เกิดข้อผิดพลาด");
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
