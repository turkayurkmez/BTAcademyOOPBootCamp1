namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesne ..................... olmadan çalışmaz
             * Bilgisayar RAM olmadan çalışmaz
             * Mouse Pil olmadan çalışmaz
             * 
             * 
             */
            ISender mailSender = new MailSender();
            WhatsappSender whatsappSender = new WhatsappSender();
            SlackSender slackSender = new SlackSender();
            ReportService reportService = new ReportService(whatsappSender);
            reportService.Send("X");
        }
    }

    public class ReportService
    {
        private ISender sender;
        public ReportService(ISender sender)
        {
            this.sender = sender;
        }
        public void Send(string to)
        {
            //MailSender sender = new MailSender();
            sender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }

    public class MailSender : ISender
    {
        public void Send(string to) => Console.WriteLine("Mail gönderildi");
    }

    public class WhatsappSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("WS ile gönderildi");
        }
    }


    public class SlackSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Slack ile gönderildi");
        }
    }
}