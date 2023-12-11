using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfIp
{
    public uint IpId { get; set; }

    public uint UserId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public byte[] Action { get; set; } = null!;

    public byte[] Ip { get; set; } = null!;

    public uint LogDate { get; set; }
}
