using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfStylePropertyMap
{
    public uint PropertyMapId { get; set; }

    public uint StyleId { get; set; }

    public byte[] PropertyName { get; set; } = null!;

    public uint PropertyId { get; set; }

    public uint? ParentPropertyId { get; set; }
}
