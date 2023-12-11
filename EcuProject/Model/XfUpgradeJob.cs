using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUpgradeJob
{
    public byte[] UniqueKey { get; set; } = null!;

    public string ExecuteClass { get; set; } = null!;

    public byte[] ExecuteData { get; set; } = null!;

    public byte Immediate { get; set; }
}
