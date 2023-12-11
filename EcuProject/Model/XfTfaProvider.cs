using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTfaProvider
{
    public byte[] ProviderId { get; set; } = null!;

    public string ProviderClass { get; set; } = null!;

    public ushort Priority { get; set; }

    public byte Active { get; set; }

    public byte[]? Options { get; set; }
}
