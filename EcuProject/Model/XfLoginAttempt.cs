using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfLoginAttempt
{
    public uint AttemptId { get; set; }

    public string Login { get; set; } = null!;

    public byte[] IpAddress { get; set; } = null!;

    public uint AttemptDate { get; set; }
}
