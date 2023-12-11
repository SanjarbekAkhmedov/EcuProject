using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadType
{
    public byte[] ThreadTypeId { get; set; } = null!;

    public string HandlerClass { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
