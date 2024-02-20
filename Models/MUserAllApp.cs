using System;
using System.Collections.Generic;

namespace MasterRoleList.Models
{
    public partial class MUserAllApp
    {
        public string Nik { get; set; } = null!;
        public string? Username { get; set; }
        public string? UserAd { get; set; }
        public string? Remarks { get; set; }
        public string? Lob { get; set; }
        public string? LobDesc { get; set; }
        public string? OrgGroupName { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? EmailOthers { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public string? JobTtlName { get; set; }
        public string? Dept { get; set; }
        public string? OrgName { get; set; }
        public string? EmpType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? OrgCode { get; set; }
    }
}
