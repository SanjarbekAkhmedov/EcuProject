using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfOembed
{
    public uint OembedId { get; set; }

    public byte[] MediaSiteId { get; set; } = null!;

    public byte[] MediaId { get; set; } = null!;

    public byte[] MediaHash { get; set; } = null!;

    public string? Title { get; set; }

    public uint FetchDate { get; set; }

    public uint FirstRequestDate { get; set; }

    public uint LastRequestDate { get; set; }

    public uint Views { get; set; }

    public uint Pruned { get; set; }

    public uint IsProcessing { get; set; }

    public uint FailedDate { get; set; }

    public ushort FailCount { get; set; }
}
