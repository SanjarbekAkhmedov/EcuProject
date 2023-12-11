using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFindNew
{
    public uint FindNewId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public byte[] Filters { get; set; } = null!;

    public byte[] FilterHash { get; set; } = null!;

    public uint UserId { get; set; }

    public byte[] Results { get; set; } = null!;

    public uint CacheDate { get; set; }
}
