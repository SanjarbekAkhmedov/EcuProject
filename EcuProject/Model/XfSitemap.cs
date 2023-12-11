using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSitemap
{
    public uint SitemapId { get; set; }

    public byte IsActive { get; set; }

    public ushort FileCount { get; set; }

    public uint EntryCount { get; set; }

    public byte IsCompressed { get; set; }

    public uint? CompleteDate { get; set; }
}
