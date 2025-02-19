﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ServiceDepartmentModel
    {
        [Key]
        public int? ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public string? ServiceDepartmentShortName { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? IntegrationName { get; set; }
        public bool? IsActive { get; set; }
        public int? ParentServiceDepartmentId { get; set; }
        public virtual List<BillServiceItemModel>? BillItemPriceList { get; set; }
        public virtual DepartmentModel? Department { get; set; }
    }
}