
namespace Daily.FormPages
{
    partial class LoginScreen
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.LoginButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogIn = new System.Windows.Forms.Panel();
            this.lblLoginBtn = new System.Windows.Forms.Label();
            this.lblForget = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            this.LoginButtons.SuspendLayout();
            this.btnLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.LoginButtons);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.pnlPass);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.lblName);
            this.pnlLogin.Controls.Add(this.pnlName);
            this.pnlLogin.Controls.Add(this.txtName);
            this.pnlLogin.Location = new System.Drawing.Point(3, 2);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(394, 463);
            this.pnlLogin.TabIndex = 1;
            // 
            // LoginButtons
            // 
            this.LoginButtons.ColumnCount = 3;
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginButtons.Controls.Add(this.btnLogIn, 2, 0);
            this.LoginButtons.Controls.Add(this.lblForget, 0, 0);
            this.LoginButtons.Location = new System.Drawing.Point(50, 262);
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
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlLogin);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(399, 469);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.LoginButtons.ResumeLayout(false);
            this.LoginButtons.PerformLayout();
            this.btnLogIn.ResumeLayout(false);
            this.btnLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}
