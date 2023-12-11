using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMadUserMultiAccount
{
    public uint MultiAccountId { get; set; }

    public uint UserId { get; set; }

    public uint MultiAccountDate { get; set; }

    public byte IsClosed { get; set; }

    public string? CloseReason { get; set; }
}
