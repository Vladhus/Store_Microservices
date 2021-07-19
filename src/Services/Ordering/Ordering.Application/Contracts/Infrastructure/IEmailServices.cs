using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructure
{
    public interface IEmailServices
    {
        Task<bool> SendMail(Email email);
    }
}
