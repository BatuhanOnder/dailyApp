using Daily.FormPages;
using Daily.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Daily
{
    public partial class LoginPage : Form
    {
        private bool firstOpen = true;
        private UserSave SaveData;
        public bool isVerification = false;

        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isFileExists = File.Exists(Environment.CurrentDirectory + @"\reg.txt");
            if (!isFileExists)
            {
               
                lblEma.Visible = true;
                txtEma.Visible = true;
                pnlEma.Visible = true;
                lblEma.Enabled = true;
                txtEma.Enabled = true;
                pnlEma.Enabled = true;
                lblLoginBtn.Text = "Sign in";

            }
            else
            {
                LoginButtons.Location = new Point(35, 220);

            }
        }
        private void LabelEffect_Click(Object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X == 38)
            {
                lbl.Font = new Font("Microsoft Sans Serif", 11);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 25);
                foreach (Control txt in pnlLogin.Controls)
                {

                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }

        private void TextBox_Enter(Object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {

                    ctrl.BackColor = ColorTranslator.FromHtml("#DD7D8C");
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = ColorTranslator.FromHtml("#DD7D8C");
                    if (ctrl.Location.X != 35)
                    {
                        ctrl.Font = new Font("Microsoft Sans Serif", 11);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 25);
                    }

                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == txt.Name.Remove(0, 3) + "Warn")
                {
                    ctrl.Visible = false;
                }

            }
        }
        private void TextBox_Leave(Object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Silver;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Silver;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        ctrl.Font = new Font("Microsoft Sans Serif", 12);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 25);
                    }

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == txt.Name.Remove(0, 3) + "Warn")
                {
                    ctrl.Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButtonEffect(object sender, EventArgs e)
        {
            btnLogIn.BackColor = ColorTranslator.FromHtml("#DD7D8C");
        }

        private void LoginButtonEffectOut(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.LightGray;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string ButtonText = lblLoginBtn.Text;

            bool isChanged = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                isChanged = true;
                NameWarn.Visible = true;

            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                isChanged = true;
                PassWarn.Visible = true;

            }
            if (txtEma.Visible == true && string.IsNullOrEmpty(txtEma.Text))
            {
                isChanged = true;
                EmaWarn.Visible = true;

            }
            if (isChanged)
            {
                return;
            }
            string UserData = txtName.Text + "¥seulki¥" + txtPass.Text + "¥seulki¥" + txtEma.Text; ;
            if (ButtonText.Equals("Sign in"))
            {
                Verification v = new Verification();
                v.ShowDialog();
                if (v.isRealUser)
                {
                    MessageBox.Show("Correct");
                    this.SaveData = new UserSave(UserData, true);
                }
                else
                {
                    MessageBox.Show("Not user");
                }
                
            }
            else
            {
                this.SaveData = new UserSave(UserData,false );
            }
            
        }

        public void Reload()
        {

        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void lblForget_MouseEnter(object sender, EventArgs e)
        {
            lblForget.ForeColor = ColorTranslator.FromHtml("#DD7D8C");
        }

        private void lblForget_MouseLeave(object sender, EventArgs e)
        {
            lblForget.ForeColor = Color.Black;
        }


        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
