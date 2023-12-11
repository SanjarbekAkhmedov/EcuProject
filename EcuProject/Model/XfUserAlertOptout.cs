using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserAlertOptout
{
    public uint UserId { get; set; }

    public byte[] Alert { get; set; } = null!;
}
