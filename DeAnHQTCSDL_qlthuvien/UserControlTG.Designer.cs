namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlTG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTG));
            this.grb_tk = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mtg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tk = new System.Windows.Forms.Button();
            this.grb_tg = new System.Windows.Forms.GroupBox();
            this.lbl_matg = new System.Windows.Forms.Label();
            this.txt_Matg = new System.Windows.Forms.TextBox();
            this.lbl_tentg = new System.Windows.Forms.Label();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_dssach = new System.Windows.Forms.GroupBox();
            this.dtgv_tacgia = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ttg = new System.Windows.Forms.TextBox();
            this.grb_tk.SuspendLayout();
            this.grb_tg.SuspendLayout();
            this.grb_dssach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_tk
            // 
            this.grb_tk.Controls.Add(this.txt_ttg);
            this.grb_tk.Controls.Add(this.label1);
            this.grb_tk.Controls.Add(this.txt_mtg);
            this.grb_tk.Controls.Add(this.label2);
            this.grb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_tk.Location = new System.Drawing.Point(160, 146);
            this.grb_tk.Name = "grb_tk";
            this.grb_tk.Size = new System.Drawing.Size(982, 66);
            this.grb_tk.TabIndex = 47;
            this.grb_tk.TabStop = false;
            this.grb_tk.Text = "Tra cứu thông tin tác giả";
            this.grb_tk.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã tác giả";
            // 
            // txt_mtg
            // 
            this.txt_mtg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mtg.Location = new System.Drawing.Point(255, 22);
            this.txt_mtg.Multiline = true;
            this.txt_mtg.Name = "txt_mtg";
            this.txt_mtg.Size = new System.Drawing.Size(193, 24);
            this.txt_mtg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên tác giả";
            // 
            // btn_tk
            // 
            this.btn_tk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_tk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tk.BackgroundImage")));
            this.btn_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.Location = new System.Drawing.Point(819, 85);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(119, 55);
            this.btn_tk.TabIndex = 48;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.UseVisualStyleBackColor = false;
            // 
            // grb_tg
            // 
            this.grb_tg.Controls.Add(this.lbl_matg);
            this.grb_tg.Controls.Add(this.txt_Matg);
            this.grb_tg.Controls.Add(this.lbl_tentg);
            this.grb_tg.Controls.Add(this.txt_tentg);
            this.grb_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_tg.Location = new System.Drawing.Point(106, 3);
            this.grb_tg.Name = "grb_tg";
            this.grb_tg.Size = new System.Drawing.Size(1007, 76);
            this.grb_tg.TabIndex = 46;
            this.grb_tg.TabStop = false;
            this.grb_tg.Text = "Thông tin tác giả";
            // 
            // lbl_matg
            // 
            this.lbl_matg.AutoSize = true;
            this.lbl_matg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matg.Location = new System.Drawing.Point(50, 31);
            this.lbl_matg.Name = "lbl_matg";
            this.lbl_matg.Size = new System.Drawing.Size(95, 24);
            this.lbl_matg.TabIndex = 27;
            this.lbl_matg.Text = "Mã tác giả";
            // 
            // txt_Matg
            // 
            this.txt_Matg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Matg.Location = new System.Drawing.Point(157, 31);
            this.txt_Matg.Multiline = true;
            this.txt_Matg.Name = "txt_Matg";
            this.txt_Matg.Size = new System.Drawing.Size(346, 24);
            this.txt_Matg.TabIndex = 0;
            // 
            // lbl_tentg
            // 
            this.lbl_tentg.AutoSize = true;
            this.lbl_tentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentg.Location = new System.Drawing.Point(505, 31);
            this.lbl_tentg.Name = "lbl_tentg";
            this.lbl_tentg.Size = new System.Drawing.Size(103, 24);
            this.lbl_tentg.TabIndex = 25;
            this.lbl_tentg.Text = "Tên tác giả";
            // 
            // txt_tentg
            // 
            this.txt_tentg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tentg.Location = new System.Drawing.Point(614, 31);
            this.txt_tentg.Multiline = true;
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(320, 24);
            this.txt_tentg.TabIndex = 1;
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_luu.BackgroundImage")));
            this.btn_luu.Enabled = false;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(664, 85);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(119, 55);
            this.btn_luu.TabIndex = 45;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(345, 85);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(119, 55);
            this.btn_sua.TabIndex = 44;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(501, 85);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(119, 55);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(971, 85);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 55);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // grb_dssach
            // 
            this.grb_dssach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dssach.Controls.Add(this.dtgv_tacgia);
            this.grb_dssach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dssach.Location = new System.Drawing.Point(40, 218);
            this.grb_dssach.Name = "grb_dssach";
            this.grb_dssach.Size = new System.Drawing.Size(1213, 268);
            this.grb_dssach.TabIndex = 40;
            this.grb_dssach.TabStop = false;
            this.grb_dssach.Text = "Sach";
            // 
            // dtgv_tacgia
            // 
            this.dtgv_tacgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_tacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MATG,
            this.TENTG});
            this.dtgv_tacgia.Location = new System.Drawing.Point(10, 21);
            this.dtgv_tacgia.Name = "dtgv_tacgia";
            this.dtgv_tacgia.Size = new System.Drawing.Size(1197, 241);
            this.dtgv_tacgia.TabIndex = 0;
            // 
            // stt1
            // 
            this.stt1.FillWeight = 60F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MATG
            // 
            this.MATG.DataPropertyName = "MATG";
            this.MATG.FillWeight = 150F;
            this.MATG.HeaderText = "Mã tác giả";
            this.MATG.Name = "MATG";
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.FillWeight = 200F;
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.Name = "TENTG";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(187, 85);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(119, 55);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // txt_ttg
            // 
            this.txt_ttg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ttg.Location = new System.Drawing.Point(646, 22);
            this.txt_ttg.Multiline = true;
            this.txt_ttg.Name = "txt_ttg";
            this.txt_ttg.Size = new System.Drawing.Size(307, 24);
            this.txt_ttg.TabIndex = 28;
            // 
            // UserControlTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grb_tk);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.grb_tg);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_dssach);
            this.Controls.Add(this.btn_them);
            this.Name = "UserControlTG";
            this.Size = new System.Drawing.Size(1315, 489);
            this.grb_tk.ResumeLayout(false);
            this.grb_tk.PerformLayout();
            this.grb_tg.ResumeLayout(false);
            this.grb_tg.PerformLayout();
            this.grb_dssach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_tk;
        private System.Windows.Forms.TextBox txt_ttg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mtg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.GroupBox grb_tg;
        private System.Windows.Forms.Label lbl_matg;
        private System.Windows.Forms.TextBox txt_Matg;
        private System.Windows.Forms.Label lbl_tentg;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_dssach;
        private System.Windows.Forms.DataGridView dtgv_tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.Button btn_them;
    }
}
