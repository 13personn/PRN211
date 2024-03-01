using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository memberrepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject memberInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberId = int.Parse(txtMemberid.Text),
                    Email = txtMemberEmail.Text,
                    CompanyName = txtMemberCompanyName.Text,
                    City = txtMemberCity.Text,
                    Country = txtMemberCountry.Text,
                    Password = txtMemberPassword.Text
                };
                if (InsertOrUpdate == false)
                {
                    memberrepository.InsertMember(member);


                }
                else
                {
                    memberrepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberid.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberid.Text = memberInfo.MemberId.ToString();
                txtMemberCompanyName.Text = memberInfo.CompanyName.ToString();
                txtMemberEmail.Text = memberInfo.Email.ToString();
                txtMemberCity.Text = memberInfo.City.ToString();
                txtMemberCountry.Text = memberInfo.Country.ToString();
                txtMemberPassword.Text = memberInfo.Password.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
