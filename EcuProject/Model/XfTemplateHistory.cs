using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplateHistory
{
    public uint TemplateHistoryId { get; set; }

    public byte[] Type { get; set; } = null!;

    public byte[] Title { get; set; } = null!;

    public uint StyleId { get; set; }

    public string Template { get; set; } = null!;

    public uint EditDate { get; set; }

    public uint LogDate { get; set; }
}
