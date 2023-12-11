using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPreRegAction
{
    public uint ActionId { get; set; }

    public byte[]? GuestKey { get; set; }

    public uint? UserId { get; set; }

    public uint ContentId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public uint LastUpdate { get; set; }

    public string ActionClass { get; set; } = null!;

    public byte[] ActionData { get; set; } = null!;
}
