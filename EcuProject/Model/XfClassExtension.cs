using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfClassExtension
{
    public uint ExtensionId { get; set; }

    public string FromClass { get; set; } = null!;

    public string ToClass { get; set; } = null!;

    public uint ExecuteOrder { get; set; }

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
