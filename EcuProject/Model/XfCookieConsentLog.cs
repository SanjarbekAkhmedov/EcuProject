using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCookieConsentLog
{
    public uint CookieConsentLogId { get; set; }

    public uint LogDate { get; set; }

    public uint UserId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public byte[] ConsentedGroups { get; set; } = null!;
}
