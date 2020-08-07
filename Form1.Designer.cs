namespace Project_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_hocphan = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diemChu = new System.Windows.Forms.TextBox();
            this.txt_diemCK = new System.Windows.Forms.TextBox();
            this.txt_diemQt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_danhmuc = new System.Windows.Forms.DataGridView();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRONGSO_GK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_monhoc = new System.Windows.Forms.DataGridView();
            this.lb_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmuc)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_result);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_maHP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_hocphan);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_diemChu);
            this.groupBox1.Controls.Add(this.txt_diemCK);
            this.groupBox1.Controls.Add(this.txt_diemQt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÍNH CPA";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HOẶC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã HP";
            // 
            // txt_maHP
            // 
            this.txt_maHP.Location = new System.Drawing.Point(71, 207);
            this.txt_maHP.Name = "txt_maHP";
            this.txt_maHP.Size = new System.Drawing.Size(122, 20);
            this.txt_maHP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "HỌC PHẦN";
            // 
            // cb_hocphan
            // 
            this.cb_hocphan.FormattingEnabled = true;
            this.cb_hocphan.Location = new System.Drawing.Point(6, 233);
            this.cb_hocphan.Name = "cb_hocphan";
            this.cb_hocphan.Size = new System.Drawing.Size(187, 21);
            this.cb_hocphan.TabIndex = 6;
            this.cb_hocphan.SelectedIndexChanged += new System.EventHandler(this.cb_hocphan_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 166);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(6, 394);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(186, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPA của bạn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm Chữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm CK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm QT";
            // 
            // txt_diemChu
            // 
            this.txt_diemChu.Location = new System.Drawing.Point(71, 328);
            this.txt_diemChu.Name = "txt_diemChu";
            this.txt_diemChu.Size = new System.Drawing.Size(122, 20);
            this.txt_diemChu.TabIndex = 0;
            // 
            // txt_diemCK
            // 
            this.txt_diemCK.Location = new System.Drawing.Point(71, 286);
            this.txt_diemCK.Name = "txt_diemCK";
            this.txt_diemCK.Size = new System.Drawing.Size(122, 20);
            this.txt_diemCK.TabIndex = 0;
            // 
            // txt_diemQt
            // 
            this.txt_diemQt.Location = new System.Drawing.Point(71, 260);
            this.txt_diemQt.Name = "txt_diemQt";
            this.txt_diemQt.Size = new System.Drawing.Size(122, 20);
            this.txt_diemQt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_danhmuc);
            this.groupBox2.Location = new System.Drawing.Point(228, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH MỤC HP IT2";
            // 
            // dgv_danhmuc
            // 
            this.dgv_danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHP,
            this.TENHP,
            this.SOTC,
            this.TRONGSO_GK});
            this.dgv_danhmuc.Location = new System.Drawing.Point(7, 20);
            this.dgv_danhmuc.Name = "dgv_danhmuc";
            this.dgv_danhmuc.Size = new System.Drawing.Size(547, 186);
            this.dgv_danhmuc.TabIndex = 0;
            // 
            // MAHP
            // 
            this.MAHP.DataPropertyName = "MAHP";
            this.MAHP.HeaderText = "Mã HP";
            this.MAHP.Name = "MAHP";
            // 
            // TENHP
            // 
            this.TENHP.DataPropertyName = "TENHP";
            this.TENHP.HeaderText = "Tên HP";
            this.TENHP.Name = "TENHP";
            this.TENHP.Width = 200;
            // 
            // SOTC
            // 
            this.SOTC.DataPropertyName = "SOTC";
            this.SOTC.HeaderText = "Số TC";
            this.SOTC.Name = "SOTC";
            // 
            // TRONGSO_GK
            // 
            this.TRONGSO_GK.DataPropertyName = "TRONGSO_GK";
            this.TRONGSO_GK.HeaderText = "Trọng Số";
            this.TRONGSO_GK.Name = "TRONGSO_GK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_monhoc);
            this.groupBox3.Location = new System.Drawing.Point(228, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CÁC MÔN ĐÃ HỌC";
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monhoc.Location = new System.Drawing.Point(7, 20);
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.Size = new System.Drawing.Size(547, 205);
            this.dgv_monhoc.TabIndex = 0;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.Red;
            this.lb_result.Location = new System.Drawing.Point(130, 419);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(55, 29);
            this.lb_result.TabIndex = 12;
            this.lb_result.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmuc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diemChu;
        private System.Windows.Forms.TextBox txt_diemCK;
        private System.Windows.Forms.TextBox txt_diemQt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRONGSO_GK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_monhoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_hocphan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lb_result;
    }
}

