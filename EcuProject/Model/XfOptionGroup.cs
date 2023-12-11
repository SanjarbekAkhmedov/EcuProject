using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfOptionGroup
{
    public byte[] GroupId { get; set; } = null!;

    /// <summary>
    /// Optional icon
    /// </summary>
    public string Icon { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte DebugOnly { get; set; }

    public byte Advanced { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
