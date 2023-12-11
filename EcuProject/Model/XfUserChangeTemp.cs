using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserChangeTemp
{
    public uint UserChangeTempId { get; set; }

    public uint UserId { get; set; }

    public byte[]? ChangeKey { get; set; }

    public byte[] ActionType { get; set; } = null!;

    public byte[]? ActionModifier { get; set; }

    public byte[]? NewValue { get; set; }

    public byte[]? OldValue { get; set; }

    public uint? CreateDate { get; set; }

    public uint? ExpiryDate { get; set; }
}
