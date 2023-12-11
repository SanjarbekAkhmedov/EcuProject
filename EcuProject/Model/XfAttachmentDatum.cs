using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAttachmentDatum
{
    public uint DataId { get; set; }

    public uint UserId { get; set; }

    public uint UploadDate { get; set; }

    public string Filename { get; set; } = null!;

    public ulong FileSize { get; set; }

    public string FileHash { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public uint Width { get; set; }

    public uint Height { get; set; }

    public uint ThumbnailWidth { get; set; }

    public uint ThumbnailHeight { get; set; }

    public uint AttachCount { get; set; }

    public uint XfaDo { get; set; }

    public string XfaUrl { get; set; } = null!;

    public uint XfmgMirrorMediaId { get; set; }
}
