using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepo = new MemberRepository();
        MemberObject memberInfo = new MemberObject();

        string adminEmail;
        string adminPass;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var email = txtEmail.Text;
            memberInfo = memberRepo.GetMemberByEmail(email);
            var pass = txtPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter Email and Password!!");
                return;
            }
            if (email.Equals(adminEmail) && pass.Equals(adminPass))
            {
                MessageBox.Show("Login by admin account successfully !!");
                Hide();

                frmMain frmMain = new frmMain { memberobject=memberInfo}  ;
               
                frmMain.Show();


            }
            
            else if (memberInfo!=null&&pass==memberInfo.Password)
            {
               
                MessageBox.Show("Login by member account successfully !!");
                frmMain frmMain = new frmMain
                {

                    Text = "Update member",

                    memberobject= memberInfo
                   

                };
                frmMain.Show();

            }
            else
            {
                MessageBox.Show("Login failed !!!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@fstore.com";
            txtPassword.Text = "admin@@";
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("login.json", true, true)
                .Build();
            adminEmail = config["adminEmail"];
            adminPass = config["adminPassword"];
        }
    }
}
