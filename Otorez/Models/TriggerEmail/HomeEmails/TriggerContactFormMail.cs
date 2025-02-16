﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Otorez.Models.TriggerEmail.HomeEmails
{
    public class TriggerContactFormMail
    {

        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("helpdesk@otorez.com", "Otorez");
            var toAddress = new MailAddress("helpdesk@otorez.com");
            const string subject = "Otorez Yeni İletişim Formu Mesajı!";
            using (var smtp = new SmtpClient
            {
                Host = "mail.otorez.com",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "")
                //trololol kısmı e-posta adresinin şifresi
            })

            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }

        }

    }
}