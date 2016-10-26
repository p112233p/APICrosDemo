using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrosAPI.Controllers
{
    //[EnableCors(origins: "http://localhost:16141", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            var v_str = "This is Get";
            return Json(v_str);
        }

        public IHttpActionResult Post()
        {
            var v_str = "This is Post";
            return Json(v_str);
        }
    }
}
