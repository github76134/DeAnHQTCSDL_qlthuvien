﻿namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlQLS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlQLS));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kt = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_dssach = new System.Windows.Forms.GroupBox();
            this.dtgv_sach = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grb_thongtinsach = new System.Windows.Forms.GroupBox();
            this.cmb_nxb = new System.Windows.Forms.ComboBox();
            this.cmb_ttg = new System.Windows.Forms.ComboBox();
            this.cmb_tl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nanxb = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grb_dssach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).BeginInit();
            this.grb_thongtinsach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập tên sách";
            // 
            // txt_kt
            // 
            this.txt_kt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kt.Location = new System.Drawing.Point(457, 198);
            this.txt_kt.Name = "txt_kt";
            this.txt_kt.Size = new System.Drawing.Size(368, 20);
            this.txt_kt.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1005, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 49);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // grb_dssach
            // 
            this.grb_dssach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dssach.Controls.Add(this.dtgv_sach);
            this.grb_dssach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dssach.Location = new System.Drawing.Point(12, 224);
            this.grb_dssach.Name = "grb_dssach";
            this.grb_dssach.Size = new System.Drawing.Size(1300, 265);
            this.grb_dssach.TabIndex = 16;
            this.grb_dssach.TabStop = false;
            this.grb_dssach.Text = "Danh Sách Các Cuốn Sách";
            // 
            // dtgv_sach
            // 
            this.dtgv_sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MASH,
            this.TENSH,
            this.MALOAISH,
            this.TENLOAISH,
            this.MATG,
            this.TENTG,
            this.NAMXB,
            this.MANXB,
            this.TENNXB,
            this.GIATIEN,
            this.KHO});
            this.dtgv_sach.Location = new System.Drawing.Point(6, 16);
            this.dtgv_sach.Name = "dtgv_sach";
            this.dtgv_sach.Size = new System.Drawing.Size(1297, 246);
            this.dtgv_sach.TabIndex = 0;
            // 
            // stt1
            // 
            this.stt1.FillWeight = 50F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MASH
            // 
            this.MASH.DataPropertyName = "MASH";
            this.MASH.FillWeight = 80F;
            this.MASH.HeaderText = "Mã sách";
            this.MASH.Name = "MASH";
            // 
            // TENSH
            // 
            this.TENSH.DataPropertyName = "TENSH";
            this.TENSH.FillWeight = 200F;
            this.TENSH.HeaderText = "Tên sách";
            this.TENSH.Name = "TENSH";
            // 
            // MALOAISH
            // 
            this.MALOAISH.DataPropertyName = "MALOAISH";
            this.MALOAISH.HeaderText = "Mã thể loại";
            this.MALOAISH.Name = "MALOAISH";
            this.MALOAISH.Visible = false;
            // 
            // TENLOAISH
            // 
            this.TENLOAISH.DataPropertyName = "TENLOAISH";
            this.TENLOAISH.HeaderText = "Thể loại";
            this.TENLOAISH.Name = "TENLOAISH";
            // 
            // MATG
            // 
            this.MATG.DataPropertyName = "MATG";
            this.MATG.FillWeight = 80F;
            this.MATG.HeaderText = "Mã tác giả";
            this.MATG.Name = "MATG";
            this.MATG.Visible = false;
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.Name = "TENTG";
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.HeaderText = "Năm xuất bản";
            this.NAMXB.Name = "NAMXB";
            // 
            // MANXB
            // 
            this.MANXB.DataPropertyName = "MANXB";
            this.MANXB.FillWeight = 110F;
            this.MANXB.HeaderText = "Mã nhà xuất bản";
            this.MANXB.Name = "MANXB";
            this.MANXB.Visible = false;
            // 
            // TENNXB
            // 
            this.TENNXB.DataPropertyName = "TENNXB";
            this.TENNXB.FillWeight = 200F;
            this.TENNXB.HeaderText = "Nhà xuất bản";
            this.TENNXB.Name = "TENNXB";
            // 
            // GIATIEN
            // 
            this.GIATIEN.DataPropertyName = "GIATiEN";
            this.GIATIEN.HeaderText = "Gía tiền";
            this.GIATIEN.Name = "GIATIEN";
            // 
            // KHO
            // 
            this.KHO.DataPropertyName = "SOLUONG";
            this.KHO.HeaderText = "Số lượng";
            this.KHO.Name = "KHO";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(842, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 49);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // grb_thongtinsach
            // 
            this.grb_thongtinsach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_thongtinsach.BackColor = System.Drawing.Color.Transparent;
            this.grb_thongtinsach.Controls.Add(this.cmb_nxb);
            this.grb_thongtinsach.Controls.Add(this.cmb_ttg);
            this.grb_thongtinsach.Controls.Add(this.cmb_tl);
            this.grb_thongtinsach.Controls.Add(this.label10);
            this.grb_thongtinsach.Controls.Add(this.txtgia);
            this.grb_thongtinsach.Controls.Add(this.label9);
            this.grb_thongtinsach.Controls.Add(this.label8);
            this.grb_thongtinsach.Controls.Add(this.label4);
            this.grb_thongtinsach.Controls.Add(this.label5);
            this.grb_thongtinsach.Controls.Add(this.label3);
            this.grb_thongtinsach.Controls.Add(this.label1);
            this.grb_thongtinsach.Controls.Add(this.txt_nanxb);
            this.grb_thongtinsach.Controls.Add(this.txtTen);
            this.grb_thongtinsach.Controls.Add(this.txtMa);
            this.grb_thongtinsach.Enabled = false;
            this.grb_thongtinsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_thongtinsach.Location = new System.Drawing.Point(3, 3);
            this.grb_thongtinsach.Name = "grb_thongtinsach";
            this.grb_thongtinsach.Size = new System.Drawing.Size(1262, 104);
            this.grb_thongtinsach.TabIndex = 17;
            this.grb_thongtinsach.TabStop = false;
            this.grb_thongtinsach.Text = "Thông tin sách";
            // 
            // cmb_nxb
            // 
            this.cmb_nxb.FormattingEnabled = true;
            this.cmb_nxb.Location = new System.Drawing.Point(1012, 31);
            this.cmb_nxb.Name = "cmb_nxb";
            this.cmb_nxb.Size = new System.Drawing.Size(190, 28);
            this.cmb_nxb.TabIndex = 3;
            // 
            // cmb_ttg
            // 
            this.cmb_ttg.FormattingEnabled = true;
            this.cmb_ttg.Location = new System.Drawing.Point(384, 69);
            this.cmb_ttg.Name = "cmb_ttg";
            this.cmb_ttg.Size = new System.Drawing.Size(176, 28);
            this.cmb_ttg.TabIndex = 5;
            // 
            // cmb_tl
            // 
            this.cmb_tl.FormattingEnabled = true;
            this.cmb_tl.Location = new System.Drawing.Point(670, 28);
            this.cmb_tl.Name = "cmb_tl";
            this.cmb_tl.Size = new System.Drawing.Size(176, 28);
            this.cmb_tl.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(903, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nhà xuất bản";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(670, 69);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(176, 26);
            this.txtgia.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên tác giả";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gía tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm xuất bản";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // txt_nanxb
            // 
            this.txt_nanxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nanxb.Location = new System.Drawing.Point(122, 69);
            this.txt_nanxb.Name = "txt_nanxb";
            this.txt_nanxb.Size = new System.Drawing.Size(143, 26);
            this.txt_nanxb.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(384, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(176, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(123, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(143, 26);
            this.txtMa.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(680, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 49);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(343, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 49);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(508, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 49);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // UserControlQLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kt);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_dssach);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grb_thongtinsach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "UserControlQLS";
            this.Size = new System.Drawing.Size(1315, 489);
            this.grb_dssach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).EndInit();
            this.grb_thongtinsach.ResumeLayout(false);
            this.grb_thongtinsach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kt;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_dssach;
        private System.Windows.Forms.DataGridView dtgv_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHO;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grb_thongtinsach;
        private System.Windows.Forms.ComboBox cmb_nxb;
        private System.Windows.Forms.ComboBox cmb_ttg;
        private System.Windows.Forms.ComboBox cmb_tl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nanxb;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}
