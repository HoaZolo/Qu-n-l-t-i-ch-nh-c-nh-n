
namespace BTLWin
{
    partial class FormExpenses
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
            this.panelExpenses = new System.Windows.Forms.Panel();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.bttExpenXoa = new System.Windows.Forms.Button();
            this.bttExpenSua = new System.Windows.Forms.Button();
            this.bttExpenThem = new System.Windows.Forms.Button();
            this.groupBoxExpen = new System.Windows.Forms.GroupBox();
            this.richTextBoxExpen = new System.Windows.Forms.RichTextBox();
            this.panelTime = new System.Windows.Forms.Panel();
            this.datatimeExpen = new System.Windows.Forms.DateTimePicker();
            this.lblExpenTime = new System.Windows.Forms.Label();
            this.panelAccSoTien = new System.Windows.Forms.Panel();
            this.txtBExpenSotien = new System.Windows.Forms.TextBox();
            this.lblExpenSoTien = new System.Windows.Forms.Label();
            this.panelAccTheLoai = new System.Windows.Forms.Panel();
            this.cbbExpenTheLoai = new System.Windows.Forms.ComboBox();
            this.lblExpenTheLoai = new System.Windows.Forms.Label();
            this.dGVExpenses = new System.Windows.Forms.DataGridView();
            this.TheLoaiCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoigianCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelExpenses.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.groupBoxExpen.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelAccSoTien.SuspendLayout();
            this.panelAccTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExpenses
            // 
            this.panelExpenses.BackColor = System.Drawing.Color.White;
            this.panelExpenses.Controls.Add(this.panelChucNang);
            this.panelExpenses.Controls.Add(this.groupBoxExpen);
            this.panelExpenses.Controls.Add(this.panelTime);
            this.panelExpenses.Controls.Add(this.panelAccSoTien);
            this.panelExpenses.Controls.Add(this.panelAccTheLoai);
            this.panelExpenses.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExpenses.Location = new System.Drawing.Point(0, 0);
            this.panelExpenses.Name = "panelExpenses";
            this.panelExpenses.Size = new System.Drawing.Size(514, 501);
            this.panelExpenses.TabIndex = 1;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.bttExpenXoa);
            this.panelChucNang.Controls.Add(this.bttExpenSua);
            this.panelChucNang.Controls.Add(this.bttExpenThem);
            this.panelChucNang.Location = new System.Drawing.Point(3, 399);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(504, 62);
            this.panelChucNang.TabIndex = 4;
            // 
            // bttExpenXoa
            // 
            this.bttExpenXoa.Location = new System.Drawing.Point(344, 3);
            this.bttExpenXoa.Name = "bttExpenXoa";
            this.bttExpenXoa.Size = new System.Drawing.Size(117, 56);
            this.bttExpenXoa.TabIndex = 6;
            this.bttExpenXoa.Text = "Xóa";
            this.bttExpenXoa.UseVisualStyleBackColor = true;
            this.bttExpenXoa.Click += new System.EventHandler(this.bttExpenXoa_Click);
            // 
            // bttExpenSua
            // 
            this.bttExpenSua.Location = new System.Drawing.Point(195, 3);
            this.bttExpenSua.Name = "bttExpenSua";
            this.bttExpenSua.Size = new System.Drawing.Size(117, 56);
            this.bttExpenSua.TabIndex = 5;
            this.bttExpenSua.Text = "Sửa";
            this.bttExpenSua.UseVisualStyleBackColor = true;
            this.bttExpenSua.Click += new System.EventHandler(this.bttExpenSua_Click);
            // 
            // bttExpenThem
            // 
            this.bttExpenThem.Location = new System.Drawing.Point(45, 3);
            this.bttExpenThem.Name = "bttExpenThem";
            this.bttExpenThem.Size = new System.Drawing.Size(117, 56);
            this.bttExpenThem.TabIndex = 4;
            this.bttExpenThem.Text = "Thêm";
            this.bttExpenThem.UseVisualStyleBackColor = true;
            this.bttExpenThem.Click += new System.EventHandler(this.bttExpenThem_Click);
            // 
            // groupBoxExpen
            // 
            this.groupBoxExpen.Controls.Add(this.richTextBoxExpen);
            this.groupBoxExpen.Location = new System.Drawing.Point(3, 243);
            this.groupBoxExpen.Name = "groupBoxExpen";
            this.groupBoxExpen.Size = new System.Drawing.Size(484, 127);
            this.groupBoxExpen.TabIndex = 3;
            this.groupBoxExpen.TabStop = false;
            this.groupBoxExpen.Text = "Chi tiết chi tiêu";
            // 
            // richTextBoxExpen
            // 
            this.richTextBoxExpen.Location = new System.Drawing.Point(18, 21);
            this.richTextBoxExpen.Name = "richTextBoxExpen";
            this.richTextBoxExpen.Size = new System.Drawing.Size(443, 100);
            this.richTextBoxExpen.TabIndex = 3;
            this.richTextBoxExpen.Text = "";
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.datatimeExpen);
            this.panelTime.Controls.Add(this.lblExpenTime);
            this.panelTime.Location = new System.Drawing.Point(3, 168);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(484, 57);
            this.panelTime.TabIndex = 2;
            // 
            // datatimeExpen
            // 
            this.datatimeExpen.Location = new System.Drawing.Point(152, 19);
            this.datatimeExpen.Name = "datatimeExpen";
            this.datatimeExpen.Size = new System.Drawing.Size(309, 22);
            this.datatimeExpen.TabIndex = 2;
            // 
            // lblExpenTime
            // 
            this.lblExpenTime.AutoSize = true;
            this.lblExpenTime.Location = new System.Drawing.Point(3, 19);
            this.lblExpenTime.Name = "lblExpenTime";
            this.lblExpenTime.Size = new System.Drawing.Size(71, 17);
            this.lblExpenTime.TabIndex = 0;
            this.lblExpenTime.Text = "Thời gian:";
            // 
            // panelAccSoTien
            // 
            this.panelAccSoTien.Controls.Add(this.txtBExpenSotien);
            this.panelAccSoTien.Controls.Add(this.lblExpenSoTien);
            this.panelAccSoTien.Location = new System.Drawing.Point(3, 89);
            this.panelAccSoTien.Name = "panelAccSoTien";
            this.panelAccSoTien.Size = new System.Drawing.Size(484, 57);
            this.panelAccSoTien.TabIndex = 1;
            // 
            // txtBExpenSotien
            // 
            this.txtBExpenSotien.Location = new System.Drawing.Point(152, 19);
            this.txtBExpenSotien.Name = "txtBExpenSotien";
            this.txtBExpenSotien.Size = new System.Drawing.Size(309, 22);
            this.txtBExpenSotien.TabIndex = 1;
            // 
            // lblExpenSoTien
            // 
            this.lblExpenSoTien.AutoSize = true;
            this.lblExpenSoTien.Location = new System.Drawing.Point(3, 19);
            this.lblExpenSoTien.Name = "lblExpenSoTien";
            this.lblExpenSoTien.Size = new System.Drawing.Size(105, 17);
            this.lblExpenSoTien.TabIndex = 0;
            this.lblExpenSoTien.Text = "Số tiền chi tiêu:";
            // 
            // panelAccTheLoai
            // 
            this.panelAccTheLoai.Controls.Add(this.cbbExpenTheLoai);
            this.panelAccTheLoai.Controls.Add(this.lblExpenTheLoai);
            this.panelAccTheLoai.Location = new System.Drawing.Point(3, 12);
            this.panelAccTheLoai.Name = "panelAccTheLoai";
            this.panelAccTheLoai.Size = new System.Drawing.Size(484, 57);
            this.panelAccTheLoai.TabIndex = 0;
            // 
            // cbbExpenTheLoai
            // 
            this.cbbExpenTheLoai.FormattingEnabled = true;
            this.cbbExpenTheLoai.Location = new System.Drawing.Point(152, 16);
            this.cbbExpenTheLoai.Name = "cbbExpenTheLoai";
            this.cbbExpenTheLoai.Size = new System.Drawing.Size(309, 24);
            this.cbbExpenTheLoai.TabIndex = 0;
            // 
            // lblExpenTheLoai
            // 
            this.lblExpenTheLoai.AutoSize = true;
            this.lblExpenTheLoai.Location = new System.Drawing.Point(3, 19);
            this.lblExpenTheLoai.Name = "lblExpenTheLoai";
            this.lblExpenTheLoai.Size = new System.Drawing.Size(112, 17);
            this.lblExpenTheLoai.TabIndex = 0;
            this.lblExpenTheLoai.Text = "Thể loại chi tiêu:";
            // 
            // dGVExpenses
            // 
            this.dGVExpenses.AllowUserToAddRows = false;
            this.dGVExpenses.AllowUserToDeleteRows = false;
            this.dGVExpenses.AllowUserToOrderColumns = true;
            this.dGVExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TheLoaiCT,
            this.SoTienCT,
            this.ThoigianCT,
            this.ChiTietCT});
            this.dGVExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVExpenses.Location = new System.Drawing.Point(514, 0);
            this.dGVExpenses.Name = "dGVExpenses";
            this.dGVExpenses.ReadOnly = true;
            this.dGVExpenses.RowHeadersWidth = 51;
            this.dGVExpenses.RowTemplate.Height = 24;
            this.dGVExpenses.Size = new System.Drawing.Size(460, 501);
            this.dGVExpenses.TabIndex = 2;
            this.dGVExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVExpenses_CellContentClick);
            this.dGVExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVExpenses_CellContentClick);
            // 
            // TheLoaiCT
            // 
            this.TheLoaiCT.DataPropertyName = "TenTheLoaiCT";
            this.TheLoaiCT.HeaderText = "Thể loại chi tiêu";
            this.TheLoaiCT.MinimumWidth = 6;
            this.TheLoaiCT.Name = "TheLoaiCT";
            this.TheLoaiCT.ReadOnly = true;
            // 
            // SoTienCT
            // 
            this.SoTienCT.DataPropertyName = "SotienCT";
            this.SoTienCT.HeaderText = "Số tiền chi tiêu";
            this.SoTienCT.MinimumWidth = 6;
            this.SoTienCT.Name = "SoTienCT";
            this.SoTienCT.ReadOnly = true;
            // 
            // ThoigianCT
            // 
            this.ThoigianCT.DataPropertyName = "ThoiGianCT";
            this.ThoigianCT.HeaderText = "Thời gian chi tiêu";
            this.ThoigianCT.MinimumWidth = 6;
            this.ThoigianCT.Name = "ThoigianCT";
            this.ThoigianCT.ReadOnly = true;
            // 
            // ChiTietCT
            // 
            this.ChiTietCT.DataPropertyName = "ChiTietCT";
            this.ChiTietCT.HeaderText = "Chi tiết chi tiêu";
            this.ChiTietCT.MinimumWidth = 6;
            this.ChiTietCT.Name = "ChiTietCT";
            this.ChiTietCT.ReadOnly = true;
            // 
            // FormExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 501);
            this.Controls.Add(this.dGVExpenses);
            this.Controls.Add(this.panelExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExpenses";
            this.Text = "Expenses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormExpenses_Load);
            this.panelExpenses.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.groupBoxExpen.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelAccSoTien.ResumeLayout(false);
            this.panelAccSoTien.PerformLayout();
            this.panelAccTheLoai.ResumeLayout(false);
            this.panelAccTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExpenses;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button bttExpenXoa;
        private System.Windows.Forms.Button bttExpenSua;
        private System.Windows.Forms.Button bttExpenThem;
        private System.Windows.Forms.GroupBox groupBoxExpen;
        private System.Windows.Forms.RichTextBox richTextBoxExpen;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.DateTimePicker datatimeExpen;
        private System.Windows.Forms.Label lblExpenTime;
        private System.Windows.Forms.Panel panelAccSoTien;
        private System.Windows.Forms.TextBox txtBExpenSotien;
        private System.Windows.Forms.Label lblExpenSoTien;
        private System.Windows.Forms.Panel panelAccTheLoai;
        private System.Windows.Forms.ComboBox cbbExpenTheLoai;
        private System.Windows.Forms.Label lblExpenTheLoai;
        private System.Windows.Forms.DataGridView dGVExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoaiCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoigianCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietCT;
    }
}