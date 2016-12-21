using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SmtpException.Controllers {
	public class TestController : ApiController {

		[HttpGet, Route("test")]
		public async Task Test() {
			using (var client = new SmtpClient()) {
				var message = new MailMessage();
				message.To.Add("test@example.com");
				message.Body = "haha";
				message.Subject = "ohhh";
				await client.SendMailAsync(message);
			}
		}

		[HttpGet, Route("test2")]
		public async Task Test2() {
			throw new NotImplementedException();
		}
	}
}