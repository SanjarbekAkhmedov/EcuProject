using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfLinkProxy
{
    public uint LinkId { get; set; }

    public string Url { get; set; } = null!;

    public byte[] UrlHash { get; set; } = null!;

    public uint FirstRequestDate { get; set; }

    public uint LastRequestDate { get; set; }

    public uint Hits { get; set; }
}
