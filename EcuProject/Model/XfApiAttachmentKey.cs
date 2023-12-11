using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApiAttachmentKey
{
    public byte[] AttachmentKey { get; set; } = null!;

    public uint CreateDate { get; set; }

    public uint UserId { get; set; }

    public byte[] TempHash { get; set; } = null!;

    public byte[] ContentType { get; set; } = null!;

    public byte[] Context { get; set; } = null!;
}
