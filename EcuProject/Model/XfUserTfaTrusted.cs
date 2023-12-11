using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserTfaTrusted
{
    public uint TfaTrustedId { get; set; }

    public uint UserId { get; set; }

    public byte[] TrustedKey { get; set; } = null!;

    public uint TrustedUntil { get; set; }
}
