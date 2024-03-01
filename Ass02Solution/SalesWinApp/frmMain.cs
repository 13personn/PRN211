using BusinessObject;
using DataAccess.Repository;
namespace SalesWinApp;
    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    public MemberObject memberobject { get; set; }

    IMemberRepository memberRepository = new MemberRepository();
    BindingSource source;


    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void no1aToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void no1ToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void membersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmMembers member = new frmMembers { MemberObjecttest =memberobject};

        member.MdiParent = this;
        member.Show();
        member.BringToFront();


    }

    private void productsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmProducts product = new frmProducts();
        product.MdiParent = this;
        product.Show();
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmOrders order = new frmOrders();
        order.MdiParent = this;
        order.Show();
    }

    private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }

    private void profileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmMembers profile = new frmMembers { MemberObjecttest=memberobject};
        profile.MdiParent = this;
        profile.Show();

    }



    private void dgvhomeup_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void LoadMemberList()
    {
        var members = memberRepository.GetMembers;
        try
        {
            source = new BindingSource();
            source.DataSource = members;




            /*
                dgvMemberList.DataSource = null;
                dgvCarList.DataSource = source;
                if (cars.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }*/
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Load car list");
        }
    }

    private void TsmOrderHistory_Click(object sender, EventArgs e)
    {
        frmOrders order = new frmOrders { memberObjecttest = memberobject };
        order.MdiParent = this;
        order.Show();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        if (memberobject != null)
        {
            TsmManager.Enabled = false;
            TsmManager.Visible = false;
        }
        else
        {

            TsmView.Enabled = false;
            TsmView.Visible = false;

        }
    }

    private void TsmManager_Click(object sender, EventArgs e)
    {

    }
}

