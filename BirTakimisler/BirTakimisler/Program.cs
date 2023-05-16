
using Utility;

MailSender.DefineSenderInformation("Gönderen Mail", "Gönderen Şifre");

MailSender.SendMail("Gönderilen Mail", "Başlık", "Mesaj");

Console.WriteLine("Mail gönderildi");
