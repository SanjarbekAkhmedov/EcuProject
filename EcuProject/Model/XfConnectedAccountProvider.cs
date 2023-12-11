using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfConnectedAccountProvider
{
    public byte[] ProviderId { get; set; } = null!;

    public string ProviderClass { get; set; } = null!;

    public ushort DisplayOrder { get; set; }

    public byte[] Options { get; set; } = null!;
}
