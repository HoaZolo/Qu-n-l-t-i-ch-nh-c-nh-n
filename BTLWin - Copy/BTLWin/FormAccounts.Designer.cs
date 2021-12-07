
namespace BTLWin
{
    partial class FormAccounts
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
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.bttAccXoa = new System.Windows.Forms.Button();
            this.bttAccSua = new System.Windows.Forms.Button();
            this.bttAccThem = new System.Windows.Forms.Button();
            this.groupBoxAcc = new System.Windows.Forms.GroupBox();
            this.richTextBoxAcc = new System.Windows.Forms.RichTextBox();
            this.panelTime = new System.Windows.Forms.Panel();
            this.dateTimePickerAcc = new System.Windows.Forms.DateTimePicker();
            this.lblAccTime = new System.Windows.Forms.Label();
            this.panelAccSoTien = new System.Windows.Forms.Panel();
            this.textBoxAcc = new System.Windows.Forms.TextBox();
            this.lblAccSoTien = new System.Windows.Forms.Label();
            this.panelAccTheLoai = new System.Windows.Forms.Panel();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.lblAccTheLoai = new System.Windows.Forms.Label();
            this.dGVAccounts = new System.Windows.Forms.DataGridView();
            this.TheLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAccounts.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.groupBoxAcc.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelAccSoTien.SuspendLayout();
            this.panelAccTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccounts
            // 
            this.panelAccounts.Controls.Add(this.panelChucNang);
            this.panelAccounts.Controls.Add(this.groupBoxAcc);
            this.panelAccounts.Controls.Add(this.panelTime);
            this.panelAccounts.Controls.Add(this.panelAccSoTien);
            this.panelAccounts.Controls.Add(this.panelAccTheLoai);
            this.panelAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccounts.Location = new System.Drawing.Point(0, 0);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(517, 501);
            this.panelAccounts.TabIndex = 0;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.bttAccXoa);
            this.panelChucNang.Controls.Add(this.bttAccSua);
            this.panelChucNang.Controls.Add(this.bttAccThem);
            this.panelChucNang.Location = new System.Drawing.Point(3, 399);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(504, 62);
            this.panelChucNang.TabIndex = 4;
            // 
            // bttAccXoa
            // 
            this.bttAccXoa.Location = new System.Drawing.Point(344, 3);
            this.bttAccXoa.Name = "bttAccXoa";
            this.bttAccXoa.Size = new System.Drawing.Size(117, 56);
            this.bttAccXoa.TabIndex = 2;
            this.bttAccXoa.Text = "Xóa";
            this.bttAccXoa.UseVisualStyleBackColor = true;
            this.bttAccXoa.Click += new System.EventHandler(this.bttAccXoa_Click);
            // 
            // bttAccSua
            // 
            this.bttAccSua.Location = new System.Drawing.Point(195, 3);
            this.bttAccSua.Name = "bttAccSua";
            this.bttAccSua.Size = new System.Drawing.Size(117, 56);
            this.bttAccSua.TabIndex = 1;
            this.bttAccSua.Text = "Sửa";
            this.bttAccSua.UseVisualStyleBackColor = true;
            this.bttAccSua.Click += new System.EventHandler(this.bttAccSua_Click);
            // 
            // bttAccThem
            // 
            this.bttAccThem.Location = new System.Drawing.Point(45, 3);
            this.bttAccThem.Name = "bttAccThem";
            this.bttAccThem.Size = new System.Drawing.Size(117, 56);
            this.bttAccThem.TabIndex = 0;
            this.bttAccThem.Text = "Thêm";
            this.bttAccThem.UseVisualStyleBackColor = true;
            this.bttAccThem.Click += new System.EventHandler(this.bttAccThem_Click);
            // 
            // groupBoxAcc
            // 
            this.groupBoxAcc.Controls.Add(this.richTextBoxAcc);
            this.groupBoxAcc.Location = new System.Drawing.Point(3, 243);
            this.groupBoxAcc.Name = "groupBoxAcc";
            this.groupBoxAcc.Size = new System.Drawing.Size(484, 127);
            this.groupBoxAcc.TabIndex = 3;
            this.groupBoxAcc.TabStop = false;
            this.groupBoxAcc.Text = "Chi tiết thu nhập";
            // 
            // richTextBoxAcc
            // 
            this.richTextBoxAcc.Location = new System.Drawing.Point(18, 21);
            this.richTextBoxAcc.Name = "richTextBoxAcc";
            this.richTextBoxAcc.Size = new System.Drawing.Size(443, 100);
            this.richTextBoxAcc.TabIndex = 0;
            this.richTextBoxAcc.Text = "";
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.dateTimePickerAcc);
            this.panelTime.Controls.Add(this.lblAccTime);
            this.panelTime.Location = new System.Drawing.Point(3, 168);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(484, 57);
            this.panelTime.TabIndex = 2;
            // 
            // dateTimePickerAcc
            // 
            this.dateTimePickerAcc.Location = new System.Drawing.Point(152, 19);
            this.dateTimePickerAcc.Name = "dateTimePickerAcc";
            this.dateTimePickerAcc.Size = new System.Drawing.Size(309, 22);
            this.dateTimePickerAcc.TabIndex = 1;
            // 
            // lblAccTime
            // 
            this.lblAccTime.AutoSize = true;
            this.lblAccTime.Location = new System.Drawing.Point(3, 19);
            this.lblAccTime.Name = "lblAccTime";
            this.lblAccTime.Size = new System.Drawing.Size(71, 17);
            this.lblAccTime.TabIndex = 0;
            this.lblAccTime.Text = "Thời gian:";
            // 
            // panelAccSoTien
            // 
            this.panelAccSoTien.Controls.Add(this.textBoxAcc);
            this.panelAccSoTien.Controls.Add(this.lblAccSoTien);
            this.panelAccSoTien.Location = new System.Drawing.Point(3, 89);
            this.panelAccSoTien.Name = "panelAccSoTien";
            this.panelAccSoTien.Size = new System.Drawing.Size(484, 57);
            this.panelAccSoTien.TabIndex = 1;
            // 
            // textBoxAcc
            // 
            this.textBoxAcc.Location = new System.Drawing.Point(152, 19);
            this.textBoxAcc.Name = "textBoxAcc";
            this.textBoxAcc.Size = new System.Drawing.Size(309, 22);
            this.textBoxAcc.TabIndex = 1;
            // 
            // lblAccSoTien
            // 
            this.lblAccSoTien.AutoSize = true;
            this.lblAccSoTien.Location = new System.Drawing.Point(3, 19);
            this.lblAccSoTien.Name = "lblAccSoTien";
            this.lblAccSoTien.Size = new System.Drawing.Size(116, 17);
            this.lblAccSoTien.TabIndex = 0;
            this.lblAccSoTien.Text = "Số tiền thu nhập:";
            // 
            // panelAccTheLoai
            // 
            this.panelAccTheLoai.Controls.Add(this.comboBoxAcc);
            this.panelAccTheLoai.Controls.Add(this.lblAccTheLoai);
            this.panelAccTheLoai.Location = new System.Drawing.Point(3, 12);
            this.panelAccTheLoai.Name = "panelAccTheLoai";
            this.panelAccTheLoai.Size = new System.Drawing.Size(484, 57);
            this.panelAccTheLoai.TabIndex = 0;
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(152, 16);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(309, 24);
            this.comboBoxAcc.TabIndex = 1;
            // 
            // lblAccTheLoai
            // 
            this.lblAccTheLoai.AutoSize = true;
            this.lblAccTheLoai.Location = new System.Drawing.Point(3, 19);
            this.lblAccTheLoai.Name = "lblAccTheLoai";
            this.lblAccTheLoai.Size = new System.Drawing.Size(123, 17);
            this.lblAccTheLoai.TabIndex = 0;
            this.lblAccTheLoai.Text = "Thể loại thu nhập:";
            // 
            // dGVAccounts
            // 
            this.dGVAccounts.AllowUserToAddRows = false;
            this.dGVAccounts.AllowUserToDeleteRows = false;
            this.dGVAccounts.AllowUserToOrderColumns = true;
            this.dGVAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TheLoaiTN,
            this.SoTienTN,
            this.ThoiGian,
            this.ChiTiet});
            this.dGVAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVAccounts.Location = new System.Drawing.Point(517, 0);
            this.dGVAccounts.Name = "dGVAccounts";
            this.dGVAccounts.ReadOnly = true;
            this.dGVAccounts.RowHeadersWidth = 51;
            this.dGVAccounts.RowTemplate.Height = 24;
            this.dGVAccounts.Size = new System.Drawing.Size(457, 501);
            this.dGVAccounts.TabIndex = 1;
            this.dGVAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAccounts_CellContentClick);
            this.dGVAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAccounts_CellContentClick);
            // 
            // TheLoaiTN
            // 
            this.TheLoaiTN.DataPropertyName = "TenTheLoaiTN";
            this.TheLoaiTN.HeaderText = "Thể loại thu nhập";
            this.TheLoaiTN.MinimumWidth = 6;
            this.TheLoaiTN.Name = "TheLoaiTN";
            this.TheLoaiTN.ReadOnly = true;
            // 
            // SoTienTN
            // 
            this.SoTienTN.DataPropertyName = "SotienTN";
            this.SoTienTN.HeaderText = "Số tiền thu nhập";
            this.SoTienTN.MinimumWidth = 6;
            this.SoTienTN.Name = "SoTienTN";
            this.SoTienTN.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGianTN";
            this.ThoiGian.HeaderText = "Thời gian thu nhập";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.DataPropertyName = "ChiTietTN";
            this.ChiTiet.HeaderText = "Chi tiết thu nhập";
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 501);
            this.Controls.Add(this.dGVAccounts);
            this.Controls.Add(this.panelAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccounts";
            this.Text = "Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.panelAccounts.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.groupBoxAcc.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelAccSoTien.ResumeLayout(false);
            this.panelAccSoTien.PerformLayout();
            this.panelAccTheLoai.ResumeLayout(false);
            this.panelAccTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.Panel panelAccTheLoai;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label lblAccTheLoai;
        private System.Windows.Forms.Panel panelAccSoTien;
        private System.Windows.Forms.TextBox textBoxAcc;
        private System.Windows.Forms.Label lblAccSoTien;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcc;
        private System.Windows.Forms.Label lblAccTime;
        private System.Windows.Forms.GroupBox groupBoxAcc;
        private System.Windows.Forms.RichTextBox richTextBoxAcc;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button bttAccXoa;
        private System.Windows.Forms.Button bttAccSua;
        private System.Windows.Forms.Button bttAccThem;
        private System.Windows.Forms.DataGridView dGVAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoaiTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
    }
}