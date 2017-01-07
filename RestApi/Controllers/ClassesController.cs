using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CodeTest.Models;

namespace RestApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClassesController : ApiController
    {
        public JsonResultData Get()
        {
            using (DataContext ctx = new DataContext())
            {
                return new JsonResultData
                {
                    isOK = true,
                    data = ctx.Classes.ToList()
                };
            }
        }
    }
}
