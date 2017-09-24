using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Little_Core_Book_app.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
