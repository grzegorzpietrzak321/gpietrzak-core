using System.Threading.Tasks;

namespace gpietrzak.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
