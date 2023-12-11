using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSearchForum
{
    public uint NodeId { get; set; }

    public byte[] SearchCriteria { get; set; } = null!;

    public string SortOrder { get; set; } = null!;

    public string SortDirection { get; set; } = null!;

    public ushort MaxResults { get; set; }

    public uint CacheTtl { get; set; }

    public uint DiscussionCount { get; set; }

    public uint MessageCount { get; set; }

    public uint LastPostId { get; set; }

    public uint LastPostDate { get; set; }

    public uint LastPostUserId { get; set; }

    public string LastPostUsername { get; set; } = null!;

    public uint LastThreadId { get; set; }

    public string LastThreadTitle { get; set; } = null!;

    public uint LastThreadPrefixId { get; set; }
}
