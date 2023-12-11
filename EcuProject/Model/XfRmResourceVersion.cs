using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceVersion
{
    public uint ResourceVersionId { get; set; }

    public uint ResourceId { get; set; }

    public uint TeamUserId { get; set; }

    public string TeamUsername { get; set; } = null!;

    public string VersionString { get; set; } = null!;

    public uint ReleaseDate { get; set; }

    public string DownloadUrl { get; set; } = null!;

    public uint DownloadCount { get; set; }

    public uint RatingCount { get; set; }

    public uint RatingSum { get; set; }

    public string VersionState { get; set; } = null!;

    public ushort FileCount { get; set; }
}
