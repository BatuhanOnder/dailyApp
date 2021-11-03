using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily.FormPages
{
    public partial class Verification : Form
    {
        public bool isRealUser { get; set; }
        public Verification()
        {
            InitializeComponent();
        }

        private int code;
        private void Verification_Load(object sender, EventArgs e)
        {
            
            Random random = new Random();
            code = random.Next(100000, 999999);
            Email(code + "");

        }

        public static void Email(string htmlString)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("app.daily@yandex.com", "DailyApp");

                mail.To.Add("batuhanonderr@gmail.com");
                // mail.Bcc.Add("gizlialici@digersiteadi.com");

                mail.Subject = "Mail Konusu";
                mail.IsBodyHtml = true;
                mail.Body = htmlString;


                SmtpClient sc = new SmtpClient("smtp.yandex.com.tr", 587);
                sc.EnableSsl = true;


                sc.UseDefaultCredentials = false;
                sc.Credentials = new NetworkCredential("app.daily@yandex.com", "dailyapp");

                sc.Send(mail);
            }
            catch (Exception)
            {

            }
        }

        private void Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            if (Code.Text.Length == 6)
            {
                if (Convert.ToInt32(Code.Text) == code)
                {
                    this.Close();

                    isRealUser = true;

                }
                else
                {
                    isRealUser = false;
                    Code.ForeColor = Color.DarkRed;
                    Thread.Sleep(100);
                    Code.ForeColor = Color.Black;
                    Thread.Sleep(100);
                    Code.ForeColor = Color.DarkRed;
                    Thread.Sleep(100);
                    Code.Text = "";
                }
            }
        }
    }
}
