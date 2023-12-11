using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermissionCacheContent
{
    public uint PermissionCombinationId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public byte[] CacheValue { get; set; } = null!;
}
