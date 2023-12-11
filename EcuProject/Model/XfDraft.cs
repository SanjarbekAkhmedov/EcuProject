using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDraft
{
    public uint DraftId { get; set; }

    public byte[] DraftKey { get; set; } = null!;

    public uint UserId { get; set; }

    public uint LastUpdate { get; set; }

    public string Message { get; set; } = null!;

    public byte[] ExtraData { get; set; } = null!;
}
