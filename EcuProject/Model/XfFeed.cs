using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFeed
{
    public uint FeedId { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public uint Frequency { get; set; }

    public uint NodeId { get; set; }

    public uint UserId { get; set; }

    public uint PrefixId { get; set; }

    public string TitleTemplate { get; set; } = null!;

    public string MessageTemplate { get; set; } = null!;

    public byte DiscussionVisible { get; set; }

    public byte DiscussionOpen { get; set; }

    public byte DiscussionSticky { get; set; }

    public uint LastFetch { get; set; }

    public uint Active { get; set; }

    public byte[]? SvPrefixIds { get; set; }
}
