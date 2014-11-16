using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Migration.Controllers
{
    public class PhoneApiController : ApiController
    {
		public IHttpActionResult Get()
		{
			var db = new Models.AppDB();
			return Ok(db.Phones.First());
		}
    }
}
