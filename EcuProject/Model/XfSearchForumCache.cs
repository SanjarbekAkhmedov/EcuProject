using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSearchForumCache
{
    public uint NodeId { get; set; }

    public byte[] Results { get; set; } = null!;

    public uint CacheDate { get; set; }
}
