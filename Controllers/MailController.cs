using EmailAPI.Data.Interface;
using EmailAPI.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IEmailSender emailSender;

        public MailController(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        /// <summary>
        /// Send Mail
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var message = new Message(new string[] { "wbarns700@gmail.com" }, "Test mail", "This is a test content to check the implementation in c#");
                emailSender.SendEmail(message);

                return StatusCode(StatusCodes.Status200OK);

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
