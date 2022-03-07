using College_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace College_Portal.Controllers
{
    public class ContactUsController : Controller
    {

        private readonly ILogger<ContactUsController> _logger;
        private readonly IConfiguration _config;
        public ContactUsController(ILogger<ContactUsController> logger,
                              IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(RegModel model)
        {
            string pwd = _config["pass"];
            
            var message = new MimeMessage();
            var message1 = new MimeMessage();
            message.From.Add(new MailboxAddress("SRF University", "hemanththaluru@gmail.com"));
            message1.From.Add(new MailboxAddress("SRF University", "hemanththaluru@gmail.com"));
            message.To.Add(new MailboxAddress("receiptent", model.mailId));
            message1.To.Add(new MailboxAddress("receiptent", "hemanththaluru@gmail.com"));
     
            message.Subject = "Thanks For writing to SRF University";
            message1.Subject = $" {model.Name} contacted SRF University";
            message.Body = new TextPart("plain")
            {
                Text = $"Hi {model.Name}, We from SRF university will try our best to reach you ASAP on this issue written to us."
            };
            message1.Body = new TextPart("plain")
            {
                Text = $"Hi SRF University , Name: {model.Name} , MailId : {model.mailId} , Phone : {model.MNo} have contacted your site on the Issue: {model.msg}"

            };

            //message1.setContent(
            //  "<h1>This is actual message embedded in HTML tags</h1>",
            // "text/html");

            //message1.setcontent = "<table>" +
            //  "<tr>" +
            //   "<td>Name</td>" +
            //   "<td>mailId</td>" +
            //   "<td>Phonenumber</td>" +
            //  "</tr>" +
            //  "<tr>" +
            //   "<td>" +model.Name  + "</td>" +
            //   "<td>" + model.mailId + "</td>" +
            //  "</tr>" +
            // "</table>";

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("hemanththaluru@gmail.com",pwd);
                client.Send(message);
                client.Disconnect(true);
            }

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("hemanththaluru@gmail.com", pwd);
                client.Send(message1);
                client.Disconnect(true);
            }


            return RedirectToAction("Index", "Home");
        }

    }
}
