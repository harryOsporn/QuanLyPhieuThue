namespace QuanLyPhieuThue
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
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.grbLoaiPhong = new System.Windows.Forms.GroupBox();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.grbLoaiPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(25, 24);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(110, 20);
            this.lblMaPT.TabIndex = 0;
            this.lblMaPT.Text = "Mã phiếu thuê";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(25, 78);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(103, 20);
            this.lblNgayBD.TabIndex = 1;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(25, 138);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(106, 20);
            this.lblNgayKT.TabIndex = 2;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(25, 195);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(185, 24);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(356, 26);
            this.txtMaPT.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(185, 195);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(356, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(185, 78);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(356, 26);
            this.dtNgayBD.TabIndex = 6;
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(185, 138);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(356, 26);
            this.dtNgayKT.TabIndex = 7;
            // 
            // grbLoaiPhong
            // 
            this.grbLoaiPhong.Controls.Add(this.rbtnD);
            this.grbLoaiPhong.Controls.Add(this.rbtnC);
            this.grbLoaiPhong.Controls.Add(this.rbtnB);
            this.grbLoaiPhong.Controls.Add(this.rbtnA);
            this.grbLoaiPhong.Location = new System.Drawing.Point(843, 39);
            this.grbLoaiPhong.Name = "grbLoaiPhong";
            this.grbLoaiPhong.Size = new System.Drawing.Size(145, 158);
            this.grbLoaiPhong.TabIndex = 8;
            this.grbLoaiPhong.TabStop = false;
            this.grbLoaiPhong.Text = "Loại phòng";
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(6, 116);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(46, 24);
            this.rbtnD.TabIndex = 3;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(7, 86);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(45, 24);
            this.rbtnC.TabIndex = 2;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(7, 56);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(45, 24);
            this.rbtnB.TabIndex = 1;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(7, 26);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(45, 24);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1030, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1030, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 39);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1030, 133);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 39);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1030, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 39);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu file";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvPT
            // 
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPT.Location = new System.Drawing.Point(29, 256);
            this.dgvPT.Name = "dgvPT";
            this.dgvPT.RowHeadersWidth = 62;
            this.dgvPT.RowTemplate.Height = 28;
            this.dgvPT.Size = new System.Drawing.Size(1109, 305);
            this.dgvPT.TabIndex = 13;
            this.dgvPT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPT_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPT";
            this.Column1.HeaderText = "Mã phiếu thuê";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBD";
            this.Column2.HeaderText = "Ngày bắt đầu";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKT";
            this.Column3.HeaderText = "Ngày kết thúc";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenKH";
            this.Column4.HeaderText = "Tên khách hàng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiPhong";
            this.Column5.HeaderText = "Loại phòng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "getSoNgayThue";
            this.Column6.HeaderText = "Số ngày thuê";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "soTienThue";
            this.Column7.HeaderText = "Tiền thuê";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(871, 203);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(108, 39);
            this.btnMoFile.TabIndex = 14;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 573);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.dgvPT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbLoaiPhong);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblNgayKT);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.lblMaPT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grbLoaiPhong.ResumeLayout(false);
            this.grbLoaiPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.GroupBox grbLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnMoFile;
    }
}

