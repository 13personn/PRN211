namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            TsmManager = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            TsmArrange = new ToolStripMenuItem();
            arrangeIconToolStripMenuItem = new ToolStripMenuItem();
            titleHorizontalToolStripMenuItem = new ToolStripMenuItem();
            titleVerticalToolStripMenuItem = new ToolStripMenuItem();
            TsmView = new ToolStripMenuItem();
            TsmProfile = new ToolStripMenuItem();
            TsmOrderHistory = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsmManager, TsmArrange, TsmView });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1019, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsmManager
            // 
            TsmManager.DropDownItems.AddRange(new ToolStripItem[] { membersToolStripMenuItem, productsToolStripMenuItem, ordersToolStripMenuItem });
            TsmManager.Name = "TsmManager";
            TsmManager.Size = new Size(98, 29);
            TsmManager.Text = "Manager";
            TsmManager.Click += TsmManager_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(270, 34);
            membersToolStripMenuItem.Text = "Members";
            membersToolStripMenuItem.Click += membersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(270, 34);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(270, 34);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // TsmArrange
            // 
            TsmArrange.DropDownItems.AddRange(new ToolStripItem[] { arrangeIconToolStripMenuItem, titleHorizontalToolStripMenuItem, titleVerticalToolStripMenuItem });
            TsmArrange.Name = "TsmArrange";
            TsmArrange.Size = new Size(91, 29);
            TsmArrange.Text = "Arrange";
            // 
            // arrangeIconToolStripMenuItem
            // 
            arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            arrangeIconToolStripMenuItem.Size = new Size(233, 34);
            arrangeIconToolStripMenuItem.Text = "Arrange Icon";
            arrangeIconToolStripMenuItem.Click += arrangeIconToolStripMenuItem_Click;
            // 
            // titleHorizontalToolStripMenuItem
            // 
            titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
            titleHorizontalToolStripMenuItem.Size = new Size(233, 34);
            titleHorizontalToolStripMenuItem.Text = "Title Horizontal";
            titleHorizontalToolStripMenuItem.Click += titleHorizontalToolStripMenuItem_Click;
            // 
            // titleVerticalToolStripMenuItem
            // 
            titleVerticalToolStripMenuItem.Name = "titleVerticalToolStripMenuItem";
            titleVerticalToolStripMenuItem.Size = new Size(233, 34);
            titleVerticalToolStripMenuItem.Text = "Title Vertical";
            titleVerticalToolStripMenuItem.Click += titleVerticalToolStripMenuItem_Click;
            // 
            // TsmView
            // 
            TsmView.DropDownItems.AddRange(new ToolStripItem[] { TsmProfile, TsmOrderHistory });
            TsmView.Name = "TsmView";
            TsmView.Size = new Size(65, 29);
            TsmView.Text = "View";
            // 
            // TsmProfile
            // 
            TsmProfile.Name = "TsmProfile";
            TsmProfile.Size = new Size(222, 34);
            TsmProfile.Text = "Profile";
            TsmProfile.Click += profileToolStripMenuItem_Click;
            // 
            // TsmOrderHistory
            // 
            TsmOrderHistory.Name = "TsmOrderHistory";
            TsmOrderHistory.Size = new Size(222, 34);
            TsmOrderHistory.Text = "Order History";
            TsmOrderHistory.Click += TsmOrderHistory_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 663);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Home";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TsmManager;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem TsmArrange;
        private ToolStripMenuItem arrangeIconToolStripMenuItem;
        private ToolStripMenuItem titleHorizontalToolStripMenuItem;
        private ToolStripMenuItem titleVerticalToolStripMenuItem;
        private ToolStripMenuItem TsmView;
        private ToolStripMenuItem TsmProfile;
        private ToolStripMenuItem TsmOrderHistory;
    }
}
