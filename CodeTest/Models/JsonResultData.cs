using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.Models
{
    public class JsonResultData
    {
        public bool isOK { get; set; }

        public object data { get; set; }
    }
}