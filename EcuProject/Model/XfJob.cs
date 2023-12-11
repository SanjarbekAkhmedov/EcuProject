using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfJob
{
    public uint JobId { get; set; }

    public byte[]? UniqueKey { get; set; }

    public string ExecuteClass { get; set; } = null!;

    public byte[] ExecuteData { get; set; } = null!;

    public byte ManualExecute { get; set; }

    public uint TriggerDate { get; set; }

    public uint? LastRunDate { get; set; }
}
