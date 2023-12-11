using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdmin
{
    public uint UserId { get; set; }

    public byte[] ExtraUserGroupIds { get; set; } = null!;

    public uint LastLogin { get; set; }

    public byte[]? PermissionCache { get; set; }

    public uint AdminLanguageId { get; set; }

    public byte Advanced { get; set; }

    public byte IsSuperAdmin { get; set; }
}
