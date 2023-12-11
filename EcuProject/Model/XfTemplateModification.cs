using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplateModification
{
    public uint ModificationId { get; set; }

    public byte[] AddonId { get; set; } = null!;

    public byte[] Type { get; set; } = null!;

    public byte[] Template { get; set; } = null!;

    public byte[] ModificationKey { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint ExecutionOrder { get; set; }

    public byte Enabled { get; set; }

    public string Action { get; set; } = null!;

    public string Find { get; set; } = null!;

    public string Replace { get; set; } = null!;
}
