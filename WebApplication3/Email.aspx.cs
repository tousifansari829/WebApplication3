using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("tousifansari829@gmail.com");
            mailMessage.To.Add(TextBox1.Text);
            mailMessage.Subject = TextBox2.Text;
            mailMessage.Body = TextBox3.Text;   

            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.FileName);
                string filePath = Path.Combine(Server.MapPath("Attachment"),fileName);
                FileUpload1.SaveAs(filePath);
                mailMessage.Attachments.Add(new Attachment(filePath));
            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("tousifansari829@gmail.com", "hlwjuhqxmrmxzlyv");
            smtp.Send(mailMessage); 
            Response.Write("<script>alert('Mail Sent Successfully')</script>");


        }
    }
}