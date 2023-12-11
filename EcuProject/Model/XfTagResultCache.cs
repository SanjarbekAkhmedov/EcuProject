using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTagResultCache
{
    public uint ResultCacheId { get; set; }

    public uint TagId { get; set; }

    public uint UserId { get; set; }

    public uint CacheDate { get; set; }

    public uint ExpiryDate { get; set; }

    public byte[] Results { get; set; } = null!;
}
