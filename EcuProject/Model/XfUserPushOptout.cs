using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserPushOptout
{
    public uint UserId { get; set; }

    public byte[] Push { get; set; } = null!;
}
