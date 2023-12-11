using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermissionCombination
{
    public uint PermissionCombinationId { get; set; }

    public uint UserId { get; set; }

    public byte[] UserGroupList { get; set; } = null!;

    public byte[] CacheValue { get; set; } = null!;
}
