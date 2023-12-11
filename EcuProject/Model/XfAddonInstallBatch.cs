using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAddonInstallBatch
{
    public uint BatchId { get; set; }

    public uint StartDate { get; set; }

    public uint CompleteDate { get; set; }

    public byte[] AddonIds { get; set; } = null!;

    public byte[] Results { get; set; } = null!;
}
