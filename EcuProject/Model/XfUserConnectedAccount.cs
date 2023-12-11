using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserConnectedAccount
{
    public uint UserId { get; set; }

    public byte[] Provider { get; set; } = null!;

    public byte[] ProviderKey { get; set; } = null!;

    public byte[] ExtraData { get; set; } = null!;
}
