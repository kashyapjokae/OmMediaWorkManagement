﻿using System.ComponentModel.DataAnnotations;

namespace OmMediaWorkManagement.Web.Components.ViewModels
{
    public class OmEmployeeViewModels
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string? CompanyName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        public decimal SalaryAmount { get; set; }
        public bool IsSalaryPaid { get; set; }
        public string? Description { get; set; }
        public IFormFile? EmployeeProfile { get; set; }
        public List<IFormFile>? EmployeeDocuments { get; set; }

        public bool IsDeleted { get; set; }
    }
    public class OmEmployeeSalaryManagementViewModel
    {

        public int OmEmployeeId { get; set; }
        public decimal? AdvancePayment { get; set; }
        public DateTime? AdvancePaymentDate { get; set; }
        public decimal? OverTimeSalary { get; set; }
        public decimal? DueBalance { get; set; }
        public decimal? OverBalance { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;


    }
}
