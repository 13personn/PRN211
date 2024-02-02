using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using Ass01Solution.Repository;
namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            Clear();
            List<Member> allMember = memberRepository.GetMembers().ToList();
            LoadMember(allMember);
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail updateMember = new frmMemberDetail
            {
                Text = "Update",
                UpdateOrInsert = true,
                MemberRepository = memberRepository,
                memberInfo = GetMemberObject()
            };
            updateMember.ShowDialog();
            if (updateMember.DialogResult == DialogResult.OK)
            {
                List<Member> allMember = memberRepository.GetMembers().ToList();
                LoadMember(allMember);
                source.Position = source.Count - 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbxCity.Text = string.Empty;
            cbxCountry.Text = string.Empty;


        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    City = cbxCity.Text,
                    Country = cbxCountry.Text
                };
                return member;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "get member ");
            }
        }

        public void LoadMember(List<Member> members)
        {


            try
            {

                source = new BindingSource();
                source.DataSource = members;



                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cbxCity.DataBindings.Clear();
                cbxCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, txtID.Text);
                txtName.DataBindings.Add("Text", source, txtName.Text);
                txtEmail.DataBindings.Add("Text", source, txtEmail.Text);
                txtPassword.DataBindings.Add("Text", source, txtPassword.Text);
                cbxCity.DataBindings.Add("SelectedValue", source, cbxCity.Text);
                cbxCountry.DataBindings.Add("SelectedValue", source, cbxCountry.Text);

                dgvMemberList.DataBindings.Clear();
                dgvMemberList.DataSource = members;

                if (members == null)
                {
                    Clear();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "load member");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<Member> allMember = memberRepository.GetMembers().ToList();
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMember(allMember);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail addMember = new frmMemberDetail();
            addMember.UpdateOrInsert = false;
            addMember.Text = "Add Member";
            addMember.MemberRepository = memberRepository;
            addMember.ShowDialog();
            if (addMember.DialogResult == DialogResult.OK)
            {
                List<Member> allMember = memberRepository.GetMembers().ToList();
                LoadMember(allMember);
                source.Position = source.Count - 1;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail updateMember = new frmMemberDetail
            {
                Text = "Update",
                UpdateOrInsert = true,
                MemberRepository = memberRepository
            };
            updateMember.ShowDialog();
            if (updateMember.DialogResult == DialogResult.OK)
            {
                List<Member> allMember = memberRepository.GetMembers().ToList();
                LoadMember(allMember);
                source.Position = source.Count - 1;
            }
        }

        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMemberList.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    txtID.Text = Convert.ToString(selectedRow.Cells["MemberID"].Value);
                    txtName.Text = Convert.ToString(selectedRow.Cells["MemberName"].Value);
                    txtPassword.Text = Convert.ToString(selectedRow.Cells["Password"].Value);
                    txtEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                    cbxCity.Text = Convert.ToString(selectedRow.Cells["City"].Value);
                    cbxCountry.Text = Convert.ToString(selectedRow.Cells["Country"].Value);
                }
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Clear();
            List<Member> sortList = memberRepository.SortDecending();
            LoadMember(sortList);
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            Member member = null;
            try
            {
                member = memberRepository.GetMemberByID(int.Parse(txtSearchByID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a number");
            }
            if (member != null)
            {
                List<Member> membersSearch = new List<Member> { member };
                LoadMember(membersSearch);
            }
        }

        private void btnSearchByName_TextChanged(object sender, EventArgs e)
        {
            Member findById = memberRepository.GetMemberByName(txtSearchByName.Text);
            List<Member> findById2 = new List<Member>();
            findById2.Add(findById);
            LoadMember(findById2);
        }
    }
}
