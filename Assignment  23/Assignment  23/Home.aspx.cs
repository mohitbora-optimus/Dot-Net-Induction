using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace Assignment__23
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var path = txtSelectfolder.Text;
            var directory = new DirectoryInfo(path);

            FileInfo[] files = directory.GetFiles();
            string DeletedFiles = "";

            foreach (FileInfo file in files)
            {
                if (file.Length > 1) 
                {
                    DeletedFiles = DeletedFiles + "," + (string)file.FullName;
                    file.Delete();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(file.FullName, true);
                    writer.WriteLine("Size is less than 100 byte");
                    writer.Close();
                }
            }


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("mohitsingh.bora@optimusinfo.com", "mypassword123");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mohitsingh.bora@optimusinfo.com");
            mail.To.Add(new MailAddress("imohitbora@gmail.com"));
            mail.Subject = "Deleted files";
            mail.Body = DeletedFiles;
            client.Send(mail);
        }


    }
}