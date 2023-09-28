namespace ListViewBT1
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã 1",
            "Giày",
            "1000"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã 2",
            "Áo",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã 3",
            "Quần",
            "400"}, -1);
            this.livHang = new System.Windows.Forms.ListView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSluong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Mahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbSluong = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // livHang
            // 
            this.livHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mahang,
            this.Tenhang,
            this.Soluong});
            this.livHang.FullRowSelect = true;
            this.livHang.GridLines = true;
            this.livHang.HideSelection = false;
            this.livHang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.livHang.Location = new System.Drawing.Point(38, 31);
            this.livHang.Name = "livHang";
            this.livHang.Size = new System.Drawing.Size(424, 342);
            this.livHang.TabIndex = 0;
            this.livHang.UseCompatibleStateImageBehavior = false;
            this.livHang.View = System.Windows.Forms.View.Details;
            this.livHang.SelectedIndexChanged += new System.EventHandler(this.livHang_SelectedIndexChanged);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(561, 41);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(203, 22);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(561, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(203, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtSluong
            // 
            this.txtSluong.Location = new System.Drawing.Point(561, 151);
            this.txtSluong.Name = "txtSluong";
            this.txtSluong.Size = new System.Drawing.Size(203, 22);
            this.txtSluong.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(516, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(656, 250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(656, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Mahang
            // 
            this.Mahang.Text = "Mã hàng";
            this.Mahang.Width = 120;
            // 
            // Tenhang
            // 
            this.Tenhang.Text = "Tên hàng";
            this.Tenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tenhang.Width = 200;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số lượng";
            this.Soluong.Width = 100;
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(480, 44);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(59, 16);
            this.lbMa.TabIndex = 3;
            this.lbMa.Text = "Mã hàng";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(480, 93);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(64, 16);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên hàng";
            // 
            // lbSluong
            // 
            this.lbSluong.AutoSize = true;
            this.lbSluong.Location = new System.Drawing.Point(480, 154);
            this.lbSluong.Name = "lbSluong";
            this.lbSluong.Size = new System.Drawing.Size(60, 16);
            this.lbSluong.TabIndex = 3;
            this.lbSluong.Text = "Số lượng";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(516, 320);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(104, 36);
            this.btnLammoi.TabIndex = 2;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSluong);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSluong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.livHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livHang;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ColumnHeader Mahang;
        private System.Windows.Forms.ColumnHeader Tenhang;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSluong;
        private System.Windows.Forms.Button btnLammoi;
    }
}

