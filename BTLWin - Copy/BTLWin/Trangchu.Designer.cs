
namespace BTLWin
{
    partial class FormTrangChu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonExpenses = new FontAwesome.Sharp.IconButton();
            this.iconButtonAccounts = new FontAwesome.Sharp.IconButton();
            this.iconButtonUser = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ImgLoGo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.iconFormTitle = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoGo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormTitle)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonExpenses);
            this.panelMenu.Controls.Add(this.iconButtonAccounts);
            this.panelMenu.Controls.Add(this.iconButtonUser);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 865);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.Resize += new System.EventHandler(this.panelMenu_Resize);
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButtonSetting.IconColor = System.Drawing.Color.Black;
            this.iconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 475);
            this.iconButtonSetting.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButtonSetting.Size = new System.Drawing.Size(246, 75);
            this.iconButtonSetting.TabIndex = 5;
            this.iconButtonSetting.Text = "Setting";
            this.iconButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSetting.UseVisualStyleBackColor = false;
            this.iconButtonSetting.Click += new System.EventHandler(this.iconButtonSetting_Click);
            // 
            // iconButtonExpenses
            // 
            this.iconButtonExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonExpenses.FlatAppearance.BorderSize = 0;
            this.iconButtonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExpenses.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButtonExpenses.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonExpenses.IconColor = System.Drawing.Color.Black;
            this.iconButtonExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExpenses.Location = new System.Drawing.Point(0, 400);
            this.iconButtonExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonExpenses.Name = "iconButtonExpenses";
            this.iconButtonExpenses.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButtonExpenses.Size = new System.Drawing.Size(246, 75);
            this.iconButtonExpenses.TabIndex = 4;
            this.iconButtonExpenses.Text = "Expenses";
            this.iconButtonExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExpenses.UseVisualStyleBackColor = false;
            this.iconButtonExpenses.Click += new System.EventHandler(this.iconButtonExpenses_Click);
            // 
            // iconButtonAccounts
            // 
            this.iconButtonAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAccounts.FlatAppearance.BorderSize = 0;
            this.iconButtonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAccounts.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButtonAccounts.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.iconButtonAccounts.IconColor = System.Drawing.Color.Black;
            this.iconButtonAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccounts.Location = new System.Drawing.Point(0, 325);
            this.iconButtonAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonAccounts.Name = "iconButtonAccounts";
            this.iconButtonAccounts.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButtonAccounts.Size = new System.Drawing.Size(246, 75);
            this.iconButtonAccounts.TabIndex = 3;
            this.iconButtonAccounts.Text = "Accounts";
            this.iconButtonAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAccounts.UseVisualStyleBackColor = false;
            this.iconButtonAccounts.Click += new System.EventHandler(this.iconButtonAccounts_Click);
            // 
            // iconButtonUser
            // 
            this.iconButtonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonUser.FlatAppearance.BorderSize = 0;
            this.iconButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUser.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButtonUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonUser.IconColor = System.Drawing.Color.Black;
            this.iconButtonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.Location = new System.Drawing.Point(0, 250);
            this.iconButtonUser.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonUser.Name = "iconButtonUser";
            this.iconButtonUser.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButtonUser.Size = new System.Drawing.Size(246, 75);
            this.iconButtonUser.TabIndex = 2;
            this.iconButtonUser.Text = "User";
            this.iconButtonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUser.UseVisualStyleBackColor = false;
            this.iconButtonUser.Click += new System.EventHandler(this.iconButtonUser_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.Black;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 175);
            this.iconButtonHome.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButtonHome.Size = new System.Drawing.Size(246, 75);
            this.iconButtonHome.TabIndex = 1;
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = false;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.ImgLoGo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.panelLogo.Size = new System.Drawing.Size(246, 175);
            this.panelLogo.TabIndex = 0;
            // 
            // ImgLoGo
            // 
            this.ImgLoGo.Image = global::BTLWin.Properties.Resources.money_lover_591184e2bf9b7;
            this.ImgLoGo.Location = new System.Drawing.Point(4, 4);
            this.ImgLoGo.Margin = new System.Windows.Forms.Padding(4);
            this.ImgLoGo.Name = "ImgLoGo";
            this.ImgLoGo.Size = new System.Drawing.Size(239, 164);
            this.ImgLoGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLoGo.TabIndex = 0;
            this.ImgLoGo.TabStop = false;
            this.ImgLoGo.Click += new System.EventHandler(this.ImgLoGo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblFormTitle);
            this.panelTitleBar.Controls.Add(this.iconFormTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(246, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1556, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Image = global::BTLWin.Properties.Resources.window_maximize_icon_144029;
            this.btnMaximize.Location = new System.Drawing.Point(1475, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 35);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = global::BTLWin.Properties.Resources.icons8_minimize_window_35;
            this.btnMinimize.Location = new System.Drawing.Point(1430, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::BTLWin.Properties.Resources.close_1111521;
            this.btnExit.Location = new System.Drawing.Point(1520, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(71, 42);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(48, 20);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Hello";
            // 
            // iconFormTitle
            // 
            this.iconFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconFormTitle.ForeColor = System.Drawing.Color.Black;
            this.iconFormTitle.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconFormTitle.IconColor = System.Drawing.Color.Black;
            this.iconFormTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormTitle.IconSize = 40;
            this.iconFormTitle.Location = new System.Drawing.Point(24, 35);
            this.iconFormTitle.Margin = new System.Windows.Forms.Padding(4);
            this.iconFormTitle.Name = "iconFormTitle";
            this.iconFormTitle.Size = new System.Drawing.Size(40, 40);
            this.iconFormTitle.TabIndex = 0;
            this.iconFormTitle.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(246, 75);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1556, 11);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.lblTime);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(246, 86);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1556, 779);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::BTLWin.Properties.Resources.money_lover_591184e2bf9b7;
            this.pictureBox2.Location = new System.Drawing.Point(568, 192);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(545, 499);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 43);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(675, 429);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 42);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 695);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.iconButton1.Size = new System.Drawing.Size(246, 78);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 865);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.Resize += new System.EventHandler(this.FormTrangChu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoGo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormTitle)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonExpenses;
        private FontAwesome.Sharp.IconButton iconButtonAccounts;
        private FontAwesome.Sharp.IconButton iconButtonUser;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox ImgLoGo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconFormTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

