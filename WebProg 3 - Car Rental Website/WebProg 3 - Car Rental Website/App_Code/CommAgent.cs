using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Mail;
using System.Linq;
/// <summary>
/// Summary description for CommAgent
/// </summary>
public  class CommAgent
{
    public CommAgent()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void SendConfirmationEmail(string userName, string userEmail, string userMsg)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.IsBodyHtml = true;
            mail.From = new MailAddress("info.rentacar1@gmail.com");
            mail.To.Add(userEmail);
            mail.Subject = "Contact Rental Car";
            mail.Body = "<div>Hello " + userName + "<br />Thank You for contacting Rental Car!<br>We will get back to You as soon as possible.<br /><br />Your message content:<br />" + userMsg + "</div>";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("info.rentacar1@gmail.com", "Qwerty12480");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {
        }
    }

    public static void SendEmailToAdmin(string userName, string userEmail, string userMsg)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.IsBodyHtml = true;
            mail.From = new MailAddress("info.rentacar1@gmail.com");
            mail.To.Add("s00132249@mail.itsligo.ie"); // DANA for testing change email to vasiloaica.dana@itsligo.ie
            mail.Subject = "User Contact Form Request";
            mail.Body = "<div>Hello Artur<br />Message from " + userName + ", email: " + userEmail + "<br /><br />" + userMsg + "</div>";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("info.rentacar1@gmail.com", "Qwerty12480");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {
        }
    }

    public static void SendInfoNewDealsUsers(int discount, int offeres)
    {
        if (offeres > 0) 
        {
            CarRentalDataContext db = new CarRentalDataContext();
            var users = from u in db.UserLinks
                        select new
                        {
                            UserName = u.FName + " " + u.LName,
                            u.Email
                        };

            foreach (var item in users)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.IsBodyHtml = true;
                    mail.From = new MailAddress("info.rentacar1@gmail.com");
                    mail.To.Add(item.Email);
                    mail.Subject = "Rental Car NEW OFFER!";
                    mail.Body = "<div>Hello " + item.UserName + "!<br />We have NEW " + discount + "% Limited offer for first " + offeres + " users!<br /> For more details visit our website.</div>";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("info.rentacar1@gmail.com", "Qwerty12480");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }

    public static void SendInfoNewDealsAdmin(int discount, int offeres)
    {
        string body = offeres <= 0 ? "<div>Hello Artur<br />Limited offer sold out. <br /> Update or add new offer" : "<div>Hello Artur<br />Previous limited offer sold out. New offer displayed on website: " + discount + "% discount.</div>";
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.IsBodyHtml = true;
            mail.From = new MailAddress("info.rentacar1@gmail.com");
            mail.To.Add("s00132249@mail.itsligo.ie"); // DANA for testing change email to vasiloaica.dana@itsligo.ie
            mail.Subject = "Limited offer update";
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("info.rentacar1@gmail.com", "Qwerty12480");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {
        }
    }

    public static void SendBookingConfirmationEmail(string userName, string userEmail)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.IsBodyHtml = true;
            mail.From = new MailAddress("info.rentacar1@gmail.com");
            mail.To.Add(userEmail);
            mail.Subject = "Rental Car Booking Confirmed";
            mail.Body = "<div>Hello " + userName + "<br />Thank You for hiring a car with Rental Car!<br>We have recieved your payment.<br /><br />Thank you - Rental Car Team</div>";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("info.rentacar1@gmail.com", "Qwerty12480");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {
        }
    }
}
