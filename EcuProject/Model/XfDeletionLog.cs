using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDeletionLog
{
    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint DeleteDate { get; set; }

    public uint DeleteUserId { get; set; }

    public string DeleteUsername { get; set; } = null!;

    public string DeleteReason { get; set; } = null!;
}
