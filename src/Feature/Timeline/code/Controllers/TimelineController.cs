﻿using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Timeline.Controllers
{
    public class TimelineController : BaseController
    {
        public ActionResult Listing()
        {
            return View();
        }
    }
}