using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfChangeLog
{
    public uint LogId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint EditUserId { get; set; }

    public uint EditDate { get; set; }

    public string Field { get; set; } = null!;

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public byte Protected { get; set; }
}
