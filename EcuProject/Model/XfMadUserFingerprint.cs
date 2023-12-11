using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMadUserFingerprint
{
    public uint FingerprintId { get; set; }

    public byte[] Fingerprint { get; set; } = null!;

    public uint UserId { get; set; }

    public uint FingerprintDate { get; set; }

    public byte IsPro { get; set; }
}
