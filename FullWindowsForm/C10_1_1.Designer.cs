namespace FullWindowsForm
{
    partial class C10_1_1
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
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnXemIn = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            dataGridView1 = new DataGridView();
            col_MaKhoa = new DataGridViewTextBoxColumn();
            col_TenKhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(136, 9);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(276, 9);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(410, 9);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXemIn
            // 
            btnXemIn.Location = new Point(540, 9);
            btnXemIn.Name = "btnXemIn";
            btnXemIn.Size = new Size(94, 29);
            btnXemIn.TabIndex = 4;
            btnXemIn.Text = "Xem in";
            btnXemIn.UseVisualStyleBackColor = true;
            btnXemIn.Click += btnXemIn_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(665, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 113);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(245, 56);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(389, 27);
            txtMaKhoa.TabIndex = 8;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(243, 110);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(389, 27);
            txtTenKhoa.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_MaKhoa, col_TenKhoa });
            dataGridView1.Location = new Point(16, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(772, 267);
            dataGridView1.TabIndex = 10;

            // 
            // col_MaKhoa
            // 
            col_MaKhoa.DataPropertyName = "MaKhoa";
            col_MaKhoa.HeaderText = "Mã khoa";
            col_MaKhoa.MinimumWidth = 6;
            col_MaKhoa.Name = "col_MaKhoa";
            // 
            // col_TenKhoa
            // 
            col_TenKhoa.DataPropertyName = "TenKhoa";
            col_TenKhoa.HeaderText = "Tên khoa";
            col_TenKhoa.MinimumWidth = 6;
            col_TenKhoa.Name = "col_TenKhoa";
            // 
            // C10_1_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnXemIn);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "C10_1_1";
            Text = "C10_1_1";
            Load += C10_1_1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXemIn;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_MaKhoa;
        private DataGridViewTextBoxColumn col_TenKhoa;
    }
}