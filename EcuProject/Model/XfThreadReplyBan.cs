using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadReplyBan
{
    public uint ThreadReplyBanId { get; set; }

    public uint ThreadId { get; set; }

    public uint UserId { get; set; }

    public uint BanDate { get; set; }

    public uint? ExpiryDate { get; set; }

    public string Reason { get; set; } = null!;

    public uint BanUserId { get; set; }
}
