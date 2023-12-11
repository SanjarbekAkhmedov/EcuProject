using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfContentSpamCache
{
    public uint SpamCacheId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public byte[] SpamParams { get; set; } = null!;

    public uint InsertDate { get; set; }
}
