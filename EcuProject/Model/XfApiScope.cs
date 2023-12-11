using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApiScope
{
    public byte[] ApiScopeId { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
