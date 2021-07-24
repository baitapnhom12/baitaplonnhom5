
namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaCa = new System.Windows.Forms.TextBox();
            this.btnThanhtien = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txt_inhoadon = new System.Windows.Forms.TextBox();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBt_Xoa = new System.Windows.Forms.RadioButton();
            this.radioBt_Sua = new System.Windows.Forms.RadioButton();
            this.radioBt_Them = new System.Windows.Forms.RadioButton();
            this.btn_ThucHien = new System.Windows.Forms.Button();
            this.btn_ReSet = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Bán";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(165, 93);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(179, 26);
            this.txtmasp.TabIndex = 4;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(165, 151);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(179, 26);
            this.txttensp.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(165, 220);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(179, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtGiaCa
            // 
            this.txtGiaCa.Location = new System.Drawing.Point(165, 276);
            this.txtGiaCa.Name = "txtGiaCa";
            this.txtGiaCa.Size = new System.Drawing.Size(179, 26);
            this.txtGiaCa.TabIndex = 7;
            // 
            // btnThanhtien
            // 
            this.btnThanhtien.Location = new System.Drawing.Point(38, 330);
            this.btnThanhtien.Name = "btnThanhtien";
            this.btnThanhtien.Size = new System.Drawing.Size(106, 60);
            this.btnThanhtien.TabIndex = 8;
            this.btnThanhtien.Text = "Tính Tiền";
            this.btnThanhtien.UseVisualStyleBackColor = true;
            this.btnThanhtien.Click += new System.EventHandler(this.btnThanhtien_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(165, 347);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(179, 26);
            this.txtThanhTien.TabIndex = 9;
            // 
            // txt_inhoadon
            // 
            this.txt_inhoadon.Location = new System.Drawing.Point(595, 90);
            this.txt_inhoadon.Multiline = true;
            this.txt_inhoadon.Name = "txt_inhoadon";
            this.txt_inhoadon.Size = new System.Drawing.Size(252, 122);
            this.txt_inhoadon.TabIndex = 10;
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Location = new System.Drawing.Point(475, 93);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(90, 63);
            this.btn_hoadon.TabIndex = 11;
            this.btn_hoadon.Text = "In Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(647, 278);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBt_Xoa);
            this.groupBox1.Controls.Add(this.radioBt_Sua);
            this.groupBox1.Controls.Add(this.radioBt_Them);
            this.groupBox1.Location = new System.Drawing.Point(614, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Tính Năng";
            // 
            // radioBt_Xoa
            // 
            this.radioBt_Xoa.AutoSize = true;
            this.radioBt_Xoa.Location = new System.Drawing.Point(37, 103);
            this.radioBt_Xoa.Name = "radioBt_Xoa";
            this.radioBt_Xoa.Size = new System.Drawing.Size(63, 24);
            this.radioBt_Xoa.TabIndex = 2;
            this.radioBt_Xoa.TabStop = true;
            this.radioBt_Xoa.Text = "Xóa";
            this.radioBt_Xoa.UseVisualStyleBackColor = true;
            // 
            // radioBt_Sua
            // 
            this.radioBt_Sua.AutoSize = true;
            this.radioBt_Sua.Location = new System.Drawing.Point(37, 67);
            this.radioBt_Sua.Name = "radioBt_Sua";
            this.radioBt_Sua.Size = new System.Drawing.Size(63, 24);
            this.radioBt_Sua.TabIndex = 1;
            this.radioBt_Sua.TabStop = true;
            this.radioBt_Sua.Text = "Sửa";
            this.radioBt_Sua.UseVisualStyleBackColor = true;
            // 
            // radioBt_Them
            // 
            this.radioBt_Them.AutoSize = true;
            this.radioBt_Them.Location = new System.Drawing.Point(37, 37);
            this.radioBt_Them.Name = "radioBt_Them";
            this.radioBt_Them.Size = new System.Drawing.Size(78, 24);
            this.radioBt_Them.TabIndex = 0;
            this.radioBt_Them.TabStop = true;
            this.radioBt_Them.Text = "Thêm ";
            this.radioBt_Them.UseVisualStyleBackColor = true;
            // 
            // btn_ThucHien
            // 
            this.btn_ThucHien.Location = new System.Drawing.Point(475, 302);
            this.btn_ThucHien.Name = "btn_ThucHien";
            this.btn_ThucHien.Size = new System.Drawing.Size(122, 53);
            this.btn_ThucHien.TabIndex = 14;
            this.btn_ThucHien.Text = "Thực Hiện ";
            this.btn_ThucHien.UseVisualStyleBackColor = true;
            this.btn_ThucHien.Click += new System.EventHandler(this.btn_ThucHien_Click);
            // 
            // btn_ReSet
            // 
            this.btn_ReSet.Location = new System.Drawing.Point(985, 276);
            this.btn_ReSet.Name = "btn_ReSet";
            this.btn_ReSet.Size = new System.Drawing.Size(103, 48);
            this.btn_ReSet.TabIndex = 15;
            this.btn_ReSet.Text = "Reset";
            this.btn_ReSet.UseVisualStyleBackColor = true;
            this.btn_ReSet.Click += new System.EventHandler(this.btn_ReSet_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(850, 276);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(101, 48);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(762, 465);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(122, 55);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(914, 472);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(161, 26);
            this.txt_timkiem.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quản Lý Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bảng Thống Kê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1145, 755);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ReSet);
            this.Controls.Add(this.btn_ThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_hoadon);
            this.Controls.Add(this.txt_inhoadon);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnThanhtien);
            this.Controls.Add(this.txtGiaCa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaCa;
        private System.Windows.Forms.Button btnThanhtien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txt_inhoadon;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBt_Xoa;
        private System.Windows.Forms.RadioButton radioBt_Sua;
        private System.Windows.Forms.RadioButton radioBt_Them;
        private System.Windows.Forms.Button btn_ThucHien;
        private System.Windows.Forms.Button btn_ReSet;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

