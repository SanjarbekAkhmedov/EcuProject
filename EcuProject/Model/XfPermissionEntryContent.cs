using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermissionEntryContent
{
    public uint PermissionEntryId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint UserGroupId { get; set; }

    public uint UserId { get; set; }

    public byte[] PermissionGroupId { get; set; } = null!;

    public byte[] PermissionId { get; set; } = null!;

    public string PermissionValue { get; set; } = null!;

    public int PermissionValueInt { get; set; }
}
