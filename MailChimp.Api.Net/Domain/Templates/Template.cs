﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Templates
{
    public class Template
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public bool drag_and_drop { get; set; }
        public bool responsive { get; set; }
        public string category { get; set; }
        public string date_created { get; set; }
        public string created_by { get; set; }
        public bool active { get; set; }
        public int folder_id { get; set; }
        public string thumbnail { get; set; }
        public string share_url { get; set; }
        public List<Link> _links { get; set; }
    }
}
