using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_threee.Views.Customer.Demo
{
    public class DemoController : Demo
    {
        public ActionResult Customer()
        {
            return view();
        }
    }
}