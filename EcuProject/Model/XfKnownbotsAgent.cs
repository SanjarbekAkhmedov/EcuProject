using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfKnownbotsAgent
{
    public byte[] UserAgent { get; set; } = null!;

    public string? RobotKey { get; set; }

    public uint LastUpdated { get; set; }

    public sbyte Sent { get; set; }
}
