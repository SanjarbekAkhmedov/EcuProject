using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfIpMatch
{
    public string Ip { get; set; } = null!;

    public string MatchType { get; set; } = null!;

    public byte[] FirstByte { get; set; } = null!;

    public byte[] StartRange { get; set; } = null!;

    public byte[] EndRange { get; set; } = null!;

    public uint CreateUserId { get; set; }

    public uint CreateDate { get; set; }

    public string Reason { get; set; } = null!;

    public uint LastTriggeredDate { get; set; }
}
