namespace Coffee_Shop_manager
{
    partial class fTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numricQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnInsertDrink = new Guna.UI2.WinForms.Guna2Button();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.numricGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiamGia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịViênToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịViênToolStripMenuItem
            // 
            this.quảnTrịViênToolStripMenuItem.Name = "quảnTrịViênToolStripMenuItem";
            this.quảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.quảnTrịViênToolStripMenuItem.Text = "Quản trị viên";
            this.quảnTrịViênToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịViênToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Thông tin cá nhân";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numricQuantity);
            this.panel1.Controls.Add(this.btnInsertDrink);
            this.panel1.Controls.Add(this.cbDrink);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(406, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 84);
            this.panel1.TabIndex = 1;
            // 
            // numricQuantity
            // 
            this.numricQuantity.Location = new System.Drawing.Point(223, 30);
            this.numricQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numricQuantity.Name = "numricQuantity";
            this.numricQuantity.Size = new System.Drawing.Size(80, 20);
            this.numricQuantity.TabIndex = 2;
            this.numricQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInsertDrink
            // 
            this.btnInsertDrink.CheckedState.Parent = this.btnInsertDrink;
            this.btnInsertDrink.CustomImages.Parent = this.btnInsertDrink;
            this.btnInsertDrink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertDrink.ForeColor = System.Drawing.Color.White;
            this.btnInsertDrink.HoverState.Parent = this.btnInsertDrink;
            this.btnInsertDrink.Location = new System.Drawing.Point(309, 17);
            this.btnInsertDrink.Name = "btnInsertDrink";
            this.btnInsertDrink.ShadowDecoration.Parent = this.btnInsertDrink;
            this.btnInsertDrink.Size = new System.Drawing.Size(73, 48);
            this.btnInsertDrink.TabIndex = 1;
            this.btnInsertDrink.Text = "Thêm món";
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(41, 44);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(161, 21);
            this.cbDrink.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(41, 17);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(161, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 24);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(400, 426);
            this.flpTable.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(406, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 247);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.numricGiamGia);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(406, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 68);
            this.panel3.TabIndex = 4;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(17, 44);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(80, 21);
            this.cbChuyenBan.TabIndex = 6;
            // 
            // numricGiamGia
            // 
            this.numricGiamGia.Location = new System.Drawing.Point(173, 45);
            this.numricGiamGia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numricGiamGia.Name = "numricGiamGia";
            this.numricGiamGia.Size = new System.Drawing.Size(80, 20);
            this.numricGiamGia.TabIndex = 5;
            this.numricGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.CheckedState.Parent = this.btnChuyenBan;
            this.btnChuyenBan.CustomImages.Parent = this.btnChuyenBan;
            this.btnChuyenBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.HoverState.Parent = this.btnChuyenBan;
            this.btnChuyenBan.Location = new System.Drawing.Point(17, 3);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.ShadowDecoration.Parent = this.btnChuyenBan;
            this.btnChuyenBan.Size = new System.Drawing.Size(80, 36);
            this.btnChuyenBan.TabIndex = 4;
            this.btnChuyenBan.Text = "Chuyển bàn";
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.CheckedState.Parent = this.btnGiamGia;
            this.btnGiamGia.CustomImages.Parent = this.btnGiamGia;
            this.btnGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiamGia.ForeColor = System.Drawing.Color.White;
            this.btnGiamGia.HoverState.Parent = this.btnGiamGia;
            this.btnGiamGia.Location = new System.Drawing.Point(173, 3);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.ShadowDecoration.Parent = this.btnGiamGia;
            this.btnGiamGia.Size = new System.Drawing.Size(80, 36);
            this.btnGiamGia.TabIndex = 4;
            this.btnGiamGia.Text = "Giảm giá";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(297, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(89, 62);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Thanh toán";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(394, 68);
            this.dataGridView2.TabIndex = 2;
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan lý coffee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numricQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numricGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numricQuantity;
        private Guna.UI2.WinForms.Guna2Button btnInsertDrink;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.NumericUpDown numricGiamGia;
        private Guna.UI2.WinForms.Guna2Button btnChuyenBan;
        private Guna.UI2.WinForms.Guna2Button btnGiamGia;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}