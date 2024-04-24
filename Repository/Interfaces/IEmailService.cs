using Microsoft.AspNetCore.Http;
using OA.Domain.Settings;
using System.Threading.Tasks;

namespace OA.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(string mailTo,string subject,string body);

    }
}
