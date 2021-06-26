using EmailAPI.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailAPI.Data.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
