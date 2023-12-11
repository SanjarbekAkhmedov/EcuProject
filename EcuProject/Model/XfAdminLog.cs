using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdminLog
{
    public uint AdminLogId { get; set; }

    public uint UserId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public uint RequestDate { get; set; }

    public string RequestUrl { get; set; } = null!;

    public byte[] RequestData { get; set; } = null!;
}
