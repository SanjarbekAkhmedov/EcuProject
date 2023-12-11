using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRegistrationSpamCache
{
    public byte[] CacheKey { get; set; } = null!;

    public byte[] Result { get; set; } = null!;

    public uint Timeout { get; set; }
}
