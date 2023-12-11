using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaWatch
{
    public uint UserId { get; set; }

    public uint MediaId { get; set; }

    public string NotifyOn { get; set; } = null!;

    public byte SendAlert { get; set; }

    public byte SendEmail { get; set; }
}
