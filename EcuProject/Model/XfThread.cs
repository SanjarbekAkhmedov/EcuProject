using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThread
{
    public uint ThreadId { get; set; }

    public uint NodeId { get; set; }

    public string Title { get; set; } = null!;

    public uint ReplyCount { get; set; }

    public uint ViewCount { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint PostDate { get; set; }

    public byte Sticky { get; set; }

    public string DiscussionState { get; set; } = null!;

    public byte DiscussionOpen { get; set; }

    public string DiscussionType { get; set; } = null!;

    public byte[] TypeData { get; set; } = null!;

    public uint FirstPostId { get; set; }

    public int FirstPostReactionScore { get; set; }

    public byte[]? FirstPostReactions { get; set; }

    public uint LastPostDate { get; set; }

    public uint LastPostId { get; set; }

    public uint LastPostUserId { get; set; }

    public string LastPostUsername { get; set; } = null!;

    public uint PrefixId { get; set; }

    public byte[] Tags { get; set; } = null!;

    public byte[] CustomFields { get; set; } = null!;

    public int VoteScore { get; set; }

    public uint VoteCount { get; set; }

    public byte[]? SvPrefixIds { get; set; }

    public uint BriviumReviewCount { get; set; }

    public uint BriviumRatingCount { get; set; }

    public uint BriviumRatingSum { get; set; }

    public float BriviumRatingWeighted { get; set; }
}
