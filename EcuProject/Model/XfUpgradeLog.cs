using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUpgradeLog
{
    public uint VersionId { get; set; }

    public ushort? LastStep { get; set; }

    public uint CompletionDate { get; set; }

    public string LogType { get; set; } = null!;
}
