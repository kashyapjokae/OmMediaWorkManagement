﻿using System.ComponentModel.DataAnnotations;

namespace OmMediaWorkManagement.ApiService.ViewModels
{
    public class OmEmployeeResponseViewModel
    {
        public int Id { get; set; }
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
        public string? EmployeeProfilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<string> EmployeeDocuments { get; set; }
    }
}
