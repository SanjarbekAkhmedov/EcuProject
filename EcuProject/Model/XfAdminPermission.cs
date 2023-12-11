using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdminPermission
{
    public byte[] AdminPermissionId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
