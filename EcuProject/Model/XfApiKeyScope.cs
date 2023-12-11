using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApiKeyScope
{
    public uint ApiKeyId { get; set; }

    public byte[] ApiScopeId { get; set; } = null!;
}
