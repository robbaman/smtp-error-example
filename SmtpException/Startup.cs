using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace SmtpException {
	public class Startup {
		public void Configuration(IAppBuilder app) {
			app.Use(async (context, next) => {
				await next();
				// Properly getting here with statuscode 500 when exception happens
				var x = context.Response.StatusCode;
			});

			var config = new HttpConfiguration();
			config.MapHttpAttributeRoutes();
			app.UseWebApi(config);

		}
	}
}