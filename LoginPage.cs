using Daily.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Daily
{
    public partial class LoginPage : Form
    {
        private bool firstOpen = true;
        private DatabaseOperations db = new DatabaseOperations();
        public LoginPage()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void LabelEffect_Click(Object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X == 38)
            {
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 25);
                foreach (Control txt in panel2.Controls)
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

            foreach (Control ctrl in panel2.Controls)
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
                        ctrl.Font = new Font("Microsoft Sans Serif", 12);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 25);
                    }
                }
            }
        } 
        private void TextBox_Leave(Object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panel2.Controls)
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
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

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
            bool isSavedUser = db.login(txtName.Text, txtPass.Text);
            if (isSavedUser)
            {
                MessageBox.Show("Father!", "The Machine:");
            }
            else
            {
                MessageBox.Show("Admin is not admin.", "The Machine:",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

      
    }
}
