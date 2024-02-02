using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass01Solution.Repository;
using System.Reflection;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        //-----------
        public IMemberRepository MemberRepository { get; set; }
        public bool UpdateOrInsert { get; set; } //true= update , false = insert
        public Member memberInfo { get; set; }
        //--------------
        
        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            
            txtIDdetail.Enabled = !UpdateOrInsert;

            if (UpdateOrInsert == true)
            {
                txtIDdetail.Text = memberInfo.MemberID.ToString();
                txtNamedetail.Text = memberInfo.MemberName;
                txtPassworddetail.Text = memberInfo.Password;
                txtEmaildetail.Text = memberInfo.Email;
                txtCitydetail.Text = memberInfo.City.Trim();
                txtCountrydetail.Text = memberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberID = int.Parse(txtIDdetail.Text),
                    MemberName = txtNamedetail.Text,
                    Password = txtPassworddetail.Text,
                    Email = txtEmaildetail.Text,
                    City = txtCitydetail.Text,
                    Country = txtCountrydetail.Text
                };
                if (UpdateOrInsert == true)
                {
                    MemberRepository.UpdateMember(member);
                }
                else
                {
                    MemberRepository.InsertMember(member);
                }
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, UpdateOrInsert == false ? "Add a new Member" : "Update a member");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e) => Close();
    }
}
