using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdminPermissionEntry
{
    public uint UserId { get; set; }

    public byte[] AdminPermissionId { get; set; } = null!;
}
