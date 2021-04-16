using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string user = User_txtBox.Text;
            string pass = Password_txtBox.Text;
            if ((user != "" || user != null) && pass != "" || pass != null)
            {
                if (user == "admin" && pass == "1234")
                {
                    Operations op = new Operations();
                    this.Hide();
                    op.Show();
                }
                else
                    MessageBox.Show("You Should Write a correct User And Password");
            }
            else
                MessageBox.Show("You Should Write User And Password");
        }
    }
}
