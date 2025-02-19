﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class LabResultTemplates
    {
        public int? TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateType { get; set; }
        public string TemplateHtml { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
        public string TemplateColumns { get; set; }
        public object Tests { get; set; }
        public int? DisplaySequence { get; set; }
    }
}
