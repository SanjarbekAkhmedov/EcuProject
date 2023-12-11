using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplateMap
{
    public uint TemplateMapId { get; set; }

    public uint StyleId { get; set; }

    public byte[] Type { get; set; } = null!;

    public byte[] Title { get; set; } = null!;

    public uint TemplateId { get; set; }
}
