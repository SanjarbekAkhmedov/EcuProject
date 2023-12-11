using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfEditHistory
{
    public uint EditHistoryId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint EditUserId { get; set; }

    public uint EditDate { get; set; }

    public string OldText { get; set; } = null!;
}
