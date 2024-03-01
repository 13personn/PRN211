using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        public MemberObject MemberObjecttest { get; set; }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
       
        private void frmMembers_MdiChildActivate(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            loadMemberList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail memberDetail = new frmMemberDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                memberrepository = memberRepository
            };
            if (memberDetail.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();
                source.Position = source.Count - 1;
            }

        }

        public void loadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberCity.DataBindings.Clear();
                txtMemberCompanyName.DataBindings.Clear();
                txtMemberCountry.DataBindings.Clear();
                txtMemberEmail.DataBindings.Clear();
                txtMemberPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtMemberCity.DataBindings.Add("Text", source, "City");
                txtMemberCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtMemberEmail.DataBindings.Add("Text", source, "Email");
                txtMemberPassword.DataBindings.Add("Text", source, "Password");
                txtMemberCountry.DataBindings.Add("Text", source, "Country");


                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtMemberEmail.Text,
                    CompanyName = txtMemberCompanyName.Text,
                    City = txtMemberCity.Text,
                    Country = txtMemberCountry.Text,
                    Password = txtMemberPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmmemberdetail = new frmMemberDetail
            {
                Text = "Update car",
                InsertOrUpdate = true,
                memberInfo = GetMemberObject(),
                memberrepository = memberRepository


            };
            if (frmmemberdetail.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                loadMemberList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmmemberdetail = new frmMemberDetail
            {
                Text = "Update car",
                InsertOrUpdate = true,
                memberInfo = GetMemberObject(),
                memberrepository = memberRepository


            };
            if (frmmemberdetail.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            MemberObject member = memberRepository.GetMemberByID(MemberObjecttest.MemberId);
            try
            {
                source = new BindingSource();
                source.DataSource = member;

                txtMemberID.DataBindings.Clear();
                txtMemberCity.DataBindings.Clear();
                txtMemberCompanyName.DataBindings.Clear();
                txtMemberCountry.DataBindings.Clear();
                txtMemberEmail.DataBindings.Clear();
                txtMemberPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtMemberCity.DataBindings.Add("Text", source, "City");
                txtMemberCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtMemberEmail.DataBindings.Add("Text", source, "Email");
                txtMemberPassword.DataBindings.Add("Text", source, "Password");
                txtMemberCountry.DataBindings.Add("Text", source, "Country");


                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (member == null)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            if (MemberObjecttest != null)
            {
                btnLoad.Enabled = false;
                btnLoad.Visible = false;
            }
            else
            {
                btnLoadProfile.Visible = false;
            }
        }

        private void dgvMemberList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
    }



}

