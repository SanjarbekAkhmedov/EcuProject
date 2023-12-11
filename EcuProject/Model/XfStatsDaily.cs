using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfStatsDaily
{
    public uint StatsDate { get; set; }

    public byte[] StatsType { get; set; } = null!;

    public ulong Counter { get; set; }
}
