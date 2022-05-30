using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace EmailSender
{
    class Program : Member
    {



        static void Main(string[] args)

        {

            string saMailer = "";
            string lesothoMailer = "";
            string tanzaniaMailer = "";
            //changes


            BusinessLogic businessLogic = new BusinessLogic();

            List<Member> saMembers = businessLogic.SaMembers();

            List<Member> lesothoMembers = businessLogic.LesothoMembers();

            List<Member> tanzaniaMembers = businessLogic.TanzaniaMembers();

            foreach (var mmbs in saMembers)
            {

                Console.WriteLine("{0} {1} ", mmbs.Email, mmbs.Region);


                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("Nicholusmaropeng@gmail.com");
                message.To.Add(new MailAddress(mmbs.Email));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("Nicholusmaropeng@gmail.com", "1964587912Amo!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }


            foreach (var mmbs in saMembers)
            {

                Console.WriteLine("{0} {1} ", mmbs.Email, mmbs.Region);


                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("Nicholusmaropeng@gmail.com");
                message.To.Add(new MailAddress(mmbs.Email));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("Nicholusmaropeng@gmail.com", "1964587912Amo!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }



            foreach (var mmbs in lesothoMembers)
            {

                Console.WriteLine("{0} {1} ", mmbs.Email, mmbs.Region);


                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("Nicholusmaropeng@gmail.com");
                message.To.Add(new MailAddress(mmbs.Email));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("Nicholusmaropeng@gmail.com", "1964587912Amo!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }

            foreach (var mmbs in tanzaniaMembers)
            {

                Console.WriteLine("{0} {1} ", mmbs.Email, mmbs.Region);


                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("Nicholusmaropeng@gmail.com");
                message.To.Add(new MailAddress(mmbs.Email));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("Nicholusmaropeng@gmail.com", "1964587912Amo!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            Console.ReadKey();

        }
        
    }
         
        }
      





 
    


