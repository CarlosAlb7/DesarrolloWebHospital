﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class SendEmail
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }

}