using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAttachment
{
    public uint AttachmentId { get; set; }

    public uint DataId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint AttachDate { get; set; }

    public string TempHash { get; set; } = null!;

    public byte Unassociated { get; set; }

    public uint ViewCount { get; set; }

    public byte XfmgIsMirrorHandler { get; set; }
}
