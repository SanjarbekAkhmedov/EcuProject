using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBanEmail
{
    public string BannedEmail { get; set; } = null!;

    public uint CreateUserId { get; set; }

    public uint CreateDate { get; set; }

    public string Reason { get; set; } = null!;

    public uint LastTriggeredDate { get; set; }
}
