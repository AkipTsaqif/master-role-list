using System;
using System.Collections.Generic;

namespace MasterRoleList.Models
{
    public partial class EbatchUserroleidT
    {
        public long RecordId { get; set; }
        public string? Nik { get; set; }
        public string? RoleidFk { get; set; }
        public string? Description { get; set; }
        public DateTime? Creationdate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Updatedate { get; set; }
        public string? Updateby { get; set; }
    }
}
