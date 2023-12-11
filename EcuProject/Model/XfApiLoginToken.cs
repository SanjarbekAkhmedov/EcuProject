using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApiLoginToken
{
    public uint LoginTokenId { get; set; }

    public byte[] LoginToken { get; set; } = null!;

    public uint UserId { get; set; }

    public uint ExpiryDate { get; set; }

    public byte[]? LimitIp { get; set; }
}
