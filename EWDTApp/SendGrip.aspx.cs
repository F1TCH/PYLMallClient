using SendGrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class SendGrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void sendMail(/*List<String> recipients*/)
        {
            //Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();

            //Add the message properties

            myMessage.From = new MailAddress("john@example.com");



            //Add multiple addresses to the To Field.
            List<String> recipients = new List<String>

            {
                @"Phee Yong Xiang <pheeyx123@gmail.com",
                @"Phee Yong han <pheeyonghan@gmail.com>",
                @"Tim Lim <timlim_95@yahooo.com>",
            };


            myMessage.AddTo(recipients);

            myMessage.Subject = "Testing the SendGrid library";

            //Add the HTML and Text bodies

            myMessage.Html = "<p>Hello World!</p>";
            myMessage.Text = "Hello World plain text!";

            //Create network credentials to access your SendGrid account

            var username = "your_sendgrid_password";
            var pswd = "your_sendgrid_password";

            /* Alternatively, you may store these credentials via your Azure portal by clicking CONFIGURE and adding the key/value pairs under "app settings", Then, you may access them as follows: 
         
             var username = System.Environment.GetEnvironmentVariable("SENDGRID_USER"):
             var pswd = System.Environment.GetEnvironmentVariable("SENDGRID_PASS");
             assuming you need your keys SENDGRID_USER and SENDGRID */

            var credentials = new NetworkCredential(username, pswd);

        }

        public void sendMailByAPI()
        {
            /* The following examples show how to send a message using the web API */

            // Create the email object first, then add the properties.
            SendGridMessage myMessage1 = new SendGridMessage();
            myMessage1.AddTo("anna@example.com");
            myMessage1.From = new MailAddress("john@example.com", "John Smith");
            myMessage1.Subject = "Testing the SendGrid Library";
            myMessage1.Text = "Hello World!";

            // Create credentials, specifying your user name and password.
            var credentials1 = new NetworkCredential("username", "password");

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials1);

            // Send the email.
            // You can also use the **DeliverAsync** method, which returns an awaitable task.
            transportWeb.Deliver(myMessage1);
        }

        public void miscFunc()
        {
            /* Attachments can be added to a message by calling the AddAttachment method and specifying the name and path of the file you want to attach. You can include multiple attachments by calling this method once for each file you wish to attach. The following example demonstrates adding an attachment to a message:*/
            SendGridMessage myMessage2 = new SendGridMessage();
            myMessage2.AddTo("anna@example.com");
            myMessage2.From = new MailAddress("john@example.com", "John Smith");
            myMessage2.Subject = "Testing the SendGrid Library";
            myMessage2.Text = "Hello World!";

            myMessage2.AddAttachment(@"C:\file1.txt");

            /* You can also add attachments from the data's Stream. It can be done by calling the same method as above, AddAttachment, but by passing in the Stream of the data, and the filename you want it to show as in the message. In this case you will need to add the System.IO library.*/

            SendGridMessage myMessage3 = new SendGridMessage();
            myMessage3.AddTo("anna@example.com");
            myMessage3.From = new MailAddress("john@example.com", "John Smith");
            myMessage3.Subject = "Testing the SendGrid Library";
            myMessage3.Text = "Hello World!";

            using (var attachmentFileStream = new FileStream(@"C:\file.txt", FileMode.Open))
            {
                myMessage3.AddAttachment(attachmentFileStream, "My Cool File.txt");
            }

            /* How to: Use apps to enable footers, tracking, and analytics
    SendGrid provides additional email functionality through the use of apps. These are settings that can be added to an email message to enable specific functionality such as click tracking, Google analytics, subscription tracking, and so on. For a full list of apps, see App Settings.

    Apps can be applied to SendGrid email messages using methods implemented as part of the SendGrid class.

    The following examples demonstrate the footer and click tracking filters:

    Footer*/
            // Create the email object first, then add the properties.
            SendGridMessage myMessage4 = new SendGridMessage();
            myMessage4.AddTo("anna@example.com");
            myMessage4.From = new MailAddress("john@example.com", "John Smith");
            myMessage4.Subject = "Testing the SendGrid Library";
            myMessage4.Text = "Hello World!";

            // Add a footer to the message.
            myMessage4.EnableFooter("PLAIN TEXT FOOTER", "<p><em>HTML FOOTER</em></p>");

            /*Click tracking*/

            // Create the email object first, then add the properties.
            SendGridMessage myMessage5 = new SendGridMessage();
            myMessage5.AddTo("anna@example.com");
            myMessage5.From = new MailAddress("john@example.com", "John Smith");
            myMessage5.Subject = "Testing the SendGrid Library";
            myMessage5.Html = "<p><a href=\"http://www.example.com\">Hello World Link!</a></p>";
            myMessage5.Text = "Hello World!";

            // true indicates that links in plain text portions of the email 
            // should also be overwritten for link tracking purposes. 
            myMessage5.EnableClickTracking(true);
        }
    }
}