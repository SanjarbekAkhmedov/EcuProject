using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserIgnored
{
    public uint UserId { get; set; }

    public uint IgnoredUserId { get; set; }
}
