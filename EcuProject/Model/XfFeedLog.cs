using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFeedLog
{
    public uint FeedId { get; set; }

    public byte[] UniqueId { get; set; } = null!;

    /// <summary>
    /// MD5(title + content)
    /// </summary>
    public string Hash { get; set; } = null!;

    public uint ThreadId { get; set; }
}
