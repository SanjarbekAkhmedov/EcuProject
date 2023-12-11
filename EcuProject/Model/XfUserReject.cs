using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserReject
{
    public uint UserId { get; set; }

    public uint RejectDate { get; set; }

    public uint RejectUserId { get; set; }

    public string RejectReason { get; set; } = null!;
}
