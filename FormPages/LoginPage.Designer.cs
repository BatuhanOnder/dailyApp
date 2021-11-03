
namespace Daily
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pnl = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.EmaWarn = new System.Windows.Forms.Label();
            this.PassWarn = new System.Windows.Forms.Label();
            this.lblEma = new System.Windows.Forms.Label();
            this.NameWarn = new System.Windows.Forms.Label();
            this.LoginButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogIn = new System.Windows.Forms.Panel();
            this.lblLoginBtn = new System.Windows.Forms.Label();
            this.lblForget = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlEma = new System.Windows.Forms.Panel();
            this.txtEma = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Cover = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.LoginButtons.SuspendLayout();
            this.btnLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.ColumnCount = 3;
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl.Controls.Add(this.pnlLogin, 1, 1);
            this.pnl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 167);
            this.pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl.Name = "pnl";
            this.pnl.RowCount = 3;
            this.pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnl.Size = new System.Drawing.Size(1136, 584);
            this.pnl.TabIndex = 1;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.EmaWarn);
            this.pnlLogin.Controls.Add(this.PassWarn);
            this.pnlLogin.Controls.Add(this.lblEma);
            this.pnlLogin.Controls.Add(this.NameWarn);
            this.pnlLogin.Controls.Add(this.LoginButtons);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.pnlEma);
            this.pnlLogin.Controls.Add(this.txtEma);
            this.pnlLogin.Controls.Add(this.pnlPass);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.lblName);
            this.pnlLogin.Controls.Add(this.pnlName);
            this.pnlLogin.Controls.Add(this.txtName);
            this.pnlLogin.Location = new System.Drawing.Point(371, 60);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(394, 463);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // EmaWarn
            // 
            this.EmaWarn.Image = global::Daily.Properties.Resources.warning_16;
            this.EmaWarn.Location = new System.Drawing.Point(310, 262);
            this.EmaWarn.Name = "EmaWarn";
            this.EmaWarn.Size = new System.Drawing.Size(40, 30);
            this.EmaWarn.TabIndex = 10;
            this.EmaWarn.Visible = false;
            // 
            // PassWarn
            // 
            this.PassWarn.Image = global::Daily.Properties.Resources.warning_16;
            this.PassWarn.Location = new System.Drawing.Point(310, 156);
            this.PassWarn.Name = "PassWarn";
            this.PassWarn.Size = new System.Drawing.Size(40, 30);
            this.PassWarn.TabIndex = 9;
            this.PassWarn.Visible = false;
            // 
            // lblEma
            // 
            this.lblEma.AutoSize = true;
            this.lblEma.Enabled = false;
            this.lblEma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEma.ForeColor = System.Drawing.Color.Silver;
            this.lblEma.Location = new System.Drawing.Point(51, 262);
            this.lblEma.Name = "lblEma";
            this.lblEma.Size = new System.Drawing.Size(90, 31);
            this.lblEma.TabIndex = 6;
            this.lblEma.Text = "E-Mail";
            this.lblEma.Visible = false;
            this.lblEma.Click += new System.EventHandler(this.LabelEffect_Click);
            // 
            // NameWarn
            // 
            this.NameWarn.Image = global::Daily.Properties.Resources.warning_16;
            this.NameWarn.Location = new System.Drawing.Point(310, 50);
            this.NameWarn.Name = "NameWarn";
            this.NameWarn.Size = new System.Drawing.Size(40, 30);
            this.NameWarn.TabIndex = 1;
            this.NameWarn.Visible = false;
            // 
            // LoginButtons
            // 
            this.LoginButtons.ColumnCount = 3;
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.Controls.Add(this.btnLogIn, 2, 0);
            this.LoginButtons.Controls.Add(this.lblForget, 0, 0);
            this.LoginButtons.Location = new System.Drawing.Point(50, 368);
            this.LoginButtons.Name = "LoginButtons";
            this.LoginButtons.RowCount = 1;
            this.LoginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.LoginButtons.Size = new System.Drawing.Size(300, 45);
            this.LoginButtons.TabIndex = 5;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.LightGray;
            this.btnLogIn.Controls.Add(this.lblLoginBtn);
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.Location = new System.Drawing.Point(203, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(94, 39);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            this.btnLogIn.MouseEnter += new System.EventHandler(this.LoginButtonEffect);
            this.btnLogIn.MouseLeave += new System.EventHandler(this.LoginButtonEffectOut);
            // 
            // lblLoginBtn
            // 
            this.lblLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginBtn.AutoSize = true;
            this.lblLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLoginBtn.Location = new System.Drawing.Point(24, 12);
            this.lblLoginBtn.Name = "lblLoginBtn";
            this.lblLoginBtn.Size = new System.Drawing.Size(47, 17);
            this.lblLoginBtn.TabIndex = 0;
            this.lblLoginBtn.Text = "Log in";
            this.lblLoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginBtn.Click += new System.EventHandler(this.btnLogIn_Click);
            this.lblLoginBtn.MouseEnter += new System.EventHandler(this.LoginButtonEffect);
            this.lblLoginBtn.MouseLeave += new System.EventHandler(this.LoginButtonEffectOut);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblForget.Location = new System.Drawing.Point(3, 0);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(94, 45);
            this.lblForget.TabIndex = 1;
            this.lblForget.Text = "Are you forgetful?";
            this.lblForget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForget.MouseEnter += new System.EventHandler(this.lblForget_MouseEnter);
            this.lblForget.MouseLeave += new System.EventHandler(this.lblForget_MouseLeave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPass.ForeColor = System.Drawing.Color.Silver;
            this.lblPass.Location = new System.Drawing.Point(50, 156);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(134, 31);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            this.lblPass.Click += new System.EventHandler(this.LabelEffect_Click);
            // 
            // pnlEma
            // 
            this.pnlEma.BackColor = System.Drawing.Color.Silver;
            this.pnlEma.Enabled = false;
            this.pnlEma.Location = new System.Drawing.Point(51, 295);
            this.pnlEma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEma.Name = "pnlEma";
            this.pnlEma.Size = new System.Drawing.Size(300, 2);
            this.pnlEma.TabIndex = 8;
            this.pnlEma.Visible = false;
            this.pnlEma.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtEma
            // 
            this.txtEma.BackColor = System.Drawing.Color.White;
            this.txtEma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEma.Enabled = false;
            this.txtEma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEma.Location = new System.Drawing.Point(51, 262);
            this.txtEma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEma.Multiline = true;
            this.txtEma.Name = "txtEma";
            this.txtEma.Size = new System.Drawing.Size(300, 31);
            this.txtEma.TabIndex = 7;
            this.txtEma.Visible = false;
            this.txtEma.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtEma.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.Silver;
            this.pnlPass.Location = new System.Drawing.Point(50, 188);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(300, 2);
            this.pnlPass.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPass.Location = new System.Drawing.Point(51, 156);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(300, 31);
            this.txtPass.TabIndex = 3;
            this.txtPass.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtPass.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtPass.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(50, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.Click += new System.EventHandler(this.LabelEffect_Click);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Silver;
            this.pnlName.Location = new System.Drawing.Point(50, 82);
            this.pnlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(300, 2);
            this.pnlName.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(51, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 31);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtName.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // Cover
            // 
            this.Cover.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Cover.BackgroundImage = global::Daily.Properties.Resources._1100x300_AC_MKC_DI_Cover_Art;
            this.Cover.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cover.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cover.Location = new System.Drawing.Point(0, 0);
            this.Cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(1136, 167);
            this.Cover.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 751);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.Cover);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.LoginButtons.ResumeLayout(false);
            this.LoginButtons.PerformLayout();
            this.btnLogIn.ResumeLayout(false);
            this.btnLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cover;
        private System.Windows.Forms.TableLayoutPanel pnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TableLayoutPanel LoginButtons;
        private System.Windows.Forms.Panel btnLogIn;
        private System.Windows.Forms.Label lblLoginBtn;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEma;
        private System.Windows.Forms.Panel pnlEma;
        private System.Windows.Forms.TextBox txtEma;
        private System.Windows.Forms.Label NameWarn;
        private System.Windows.Forms.Label EmaWarn;
        private System.Windows.Forms.Label PassWarn;
    }
}

