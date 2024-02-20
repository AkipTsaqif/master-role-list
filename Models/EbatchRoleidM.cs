using System;
using System.Collections.Generic;

namespace MasterRoleList.Models
{
    public partial class EbatchRoleidM
    {
        public long RecordId { get; set; }
        public string Roleid { get; set; } = null!;
        public string? Roledescription { get; set; }
        public bool? Isactive { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
    }
}
