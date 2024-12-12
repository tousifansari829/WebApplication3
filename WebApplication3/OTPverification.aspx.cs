using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class OTPverification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string gotp = GenerateOTP();
            string Remail = TextBox1.Text;
            Session["OTP"]=gotp;
            sendOTP(gotp, Remail);

        }


        public string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(1001, 9999).ToString();
        }
        public void sendOTP(string em, string otp)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new MailAddress("tousifansari829@gmail.com");
            mail.To.Add(em);
            mail.Subject = "Generate OTP";
            mail.Body = $"Your OTP: {otp}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("tousifansari829@gmail.com", "hlwjuhqxmrmxzlyv");
            smtp.Send(mail);
            Response.Write("<script>alert('OTP Sent Successfully')</script>");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string votp = TextBox2.Text;
            if (Session["OTP"].ToString().Equals(votp))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Mail Sent Successfully')</script>");
            }
        }
    }
}