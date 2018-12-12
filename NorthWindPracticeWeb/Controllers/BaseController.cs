using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWindPracticeWeb.FilterAttribute;

namespace NorthWindPracticeWeb.Controllers
{
    [ExceptionLog]
    public class BaseController : Controller
    {

    }
}