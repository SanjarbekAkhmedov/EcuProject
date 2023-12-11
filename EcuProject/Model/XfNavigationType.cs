using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNavigationType
{
    public byte[] NavigationTypeId { get; set; } = null!;

    public string HandlerClass { get; set; } = null!;

    public uint DisplayOrder { get; set; }
}
