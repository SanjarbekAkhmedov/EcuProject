using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermissionEntry
{
    public uint PermissionEntryId { get; set; }

    public uint UserGroupId { get; set; }

    public uint UserId { get; set; }

    public byte[] PermissionGroupId { get; set; } = null!;

    public byte[] PermissionId { get; set; } = null!;

    public string PermissionValue { get; set; } = null!;

    public int PermissionValueInt { get; set; }
}
