using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpFeaturingDuration
{
    public uint DurationId { get; set; }

    public uint Value { get; set; }

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public byte Active { get; set; }

    public uint DisplayOrder { get; set; }
}
