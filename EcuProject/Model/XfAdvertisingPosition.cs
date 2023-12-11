using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdvertisingPosition
{
    public byte[] PositionId { get; set; } = null!;

    public byte[] Arguments { get; set; } = null!;

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
