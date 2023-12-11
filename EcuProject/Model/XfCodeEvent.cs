using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCodeEvent
{
    public byte[] EventId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
