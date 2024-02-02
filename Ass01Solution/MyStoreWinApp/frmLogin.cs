using System.Configuration;
using BusinessObject;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Configuration;
using Ass01Solution.Repository;
using System.Reflection;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepo = new MemberRepository();
        Member memberInfo = new Member();

        string adminEmail;
        string adminPass;
      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
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
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.Show();
            }
            else if (memberRepo.GetMemberByEmail(email) != null)
            {
                memberInfo = memberRepo.GetMemberByEmail(email);
                MessageBox.Show("Login by member account successfully !!");
                frmMemberDetail frmMemberDetails = new frmMemberDetail
                {
                    Text = "Update member",
                    UpdateOrInsert = true,
                    MemberRepository = memberRepo,
                    memberInfo = memberInfo,

                };
                frmMemberDetails.Show();

            }
            else
            {
                MessageBox.Show("Login failed !!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@fstore.com";
            txtPassword.Text = "admin@@";
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            adminEmail = config["adminEmail"];
            adminPass = config["adminPassword"];
            
        }
    }
}
