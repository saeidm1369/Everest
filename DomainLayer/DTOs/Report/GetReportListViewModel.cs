﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTOs.Report
{
    public class GetReportListViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Place { get; set; }
        public string? ReportContent { get; set; }
        public string? Image { get; set; }
        public string? DateOfHolding { get; set; }
    }
}
