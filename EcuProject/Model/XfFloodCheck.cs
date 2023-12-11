using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFloodCheck
{
    public uint UserId { get; set; }

    public string FloodAction { get; set; } = null!;

    public uint FloodTime { get; set; }
}
