using _13_OOP_InterfaceMail;

internal class Program
{
    private static void Main(string[] args)
    {
            IMailService mailService = new MailToHotmail();

        mailService.From = "Furkan Kartal";
        mailService.To = "MERVE Turhan";
        mailService.Send();


    }
}