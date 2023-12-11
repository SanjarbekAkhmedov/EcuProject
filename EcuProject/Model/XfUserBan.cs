using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserBan
{
    public uint UserId { get; set; }

    public uint BanUserId { get; set; }

    public uint BanDate { get; set; }

    public uint EndDate { get; set; }

    public string UserReason { get; set; } = null!;

    public byte Triggered { get; set; }
}
