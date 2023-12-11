using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaTemp
{
    public uint TempMediaId { get; set; }

    public string MediaHash { get; set; } = null!;

    public uint TempMediaDate { get; set; }

    public byte[] MediaType { get; set; } = null!;

    public uint UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint ThumbnailDate { get; set; }

    public uint PosterDate { get; set; }

    public uint? AttachmentId { get; set; }

    public byte RequiresTranscoding { get; set; }

    public byte[]? ExifData { get; set; }
}
