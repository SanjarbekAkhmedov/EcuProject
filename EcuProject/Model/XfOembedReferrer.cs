using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfOembedReferrer
{
    public uint ReferrerId { get; set; }

    public uint OembedId { get; set; }

    public byte[] ReferrerHash { get; set; } = null!;

    public string ReferrerUrl { get; set; } = null!;

    public uint Hits { get; set; }

    public uint FirstDate { get; set; }

    public uint LastDate { get; set; }
}
