using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserTfa
{
    public uint UserTfaId { get; set; }

    public uint UserId { get; set; }

    public byte[] ProviderId { get; set; } = null!;

    public byte[] ProviderData { get; set; } = null!;

    public uint LastUsedDate { get; set; }
}
