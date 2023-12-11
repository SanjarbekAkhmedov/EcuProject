using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCssCache
{
    public uint CacheId { get; set; }

    public uint StyleId { get; set; }

    public uint LanguageId { get; set; }

    public byte[] Title { get; set; } = null!;

    public byte[] ModifierKey { get; set; } = null!;

    public byte[] Output { get; set; } = null!;

    public uint CacheDate { get; set; }
}
