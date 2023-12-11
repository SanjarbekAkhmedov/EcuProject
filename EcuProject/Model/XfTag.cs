using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTag
{
    public uint TagId { get; set; }

    public string Tag { get; set; } = null!;

    public string TagUrl { get; set; } = null!;

    public uint UseCount { get; set; }

    public uint LastUseDate { get; set; }

    public byte Permanent { get; set; }
}
