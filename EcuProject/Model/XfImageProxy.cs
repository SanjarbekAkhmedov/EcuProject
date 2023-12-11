using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfImageProxy
{
    public uint ImageId { get; set; }

    public string Url { get; set; } = null!;

    public byte[] UrlHash { get; set; } = null!;

    public ulong FileSize { get; set; }

    public string FileName { get; set; } = null!;

    public string FileHash { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public uint FetchDate { get; set; }

    public uint FirstRequestDate { get; set; }

    public uint LastRequestDate { get; set; }

    public uint Views { get; set; }

    public uint Pruned { get; set; }

    public uint IsProcessing { get; set; }

    public uint FailedDate { get; set; }

    public ushort FailCount { get; set; }
}
