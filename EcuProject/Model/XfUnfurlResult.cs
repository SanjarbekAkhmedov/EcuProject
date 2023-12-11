using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUnfurlResult
{
    public uint ResultId { get; set; }

    public string Url { get; set; } = null!;

    public byte[] UrlHash { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? FaviconUrl { get; set; }

    public uint LastRequestDate { get; set; }

    public byte Pending { get; set; }

    public uint ErrorCount { get; set; }
}
