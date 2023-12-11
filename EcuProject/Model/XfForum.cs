using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfForum
{
    public uint NodeId { get; set; }

    public uint DiscussionCount { get; set; }

    public uint MessageCount { get; set; }

    /// <summary>
    /// Most recent post_id
    /// </summary>
    public uint LastPostId { get; set; }

    /// <summary>
    /// Date of most recent post
    /// </summary>
    public uint LastPostDate { get; set; }

    /// <summary>
    /// User_id of user posting most recently
    /// </summary>
    public uint LastPostUserId { get; set; }

    /// <summary>
    /// Username of most recently-posting user
    /// </summary>
    public string LastPostUsername { get; set; } = null!;

    /// <summary>
    /// Most recent thread_id
    /// </summary>
    public uint LastThreadId { get; set; }

    /// <summary>
    /// Title of thread most recent post is in
    /// </summary>
    public string LastThreadTitle { get; set; } = null!;

    public uint LastThreadPrefixId { get; set; }

    public byte[] ForumTypeId { get; set; } = null!;

    public byte[] TypeConfig { get; set; } = null!;

    public byte ModerateThreads { get; set; }

    public byte ModerateReplies { get; set; }

    public byte AllowPosting { get; set; }

    /// <summary>
    /// If not set, messages posted (directly) within this forum will not contribute to user message totals.
    /// </summary>
    public byte CountMessages { get; set; }

    /// <summary>
    /// Include posts from this forum when running /find-new/threads
    /// </summary>
    public byte FindNew { get; set; }

    public string AllowIndex { get; set; } = null!;

    public byte[] IndexCriteria { get; set; } = null!;

    /// <summary>
    /// Serialized data from xf_thread_field
    /// </summary>
    public byte[] FieldCache { get; set; } = null!;

    /// <summary>
    /// Serialized data from xf_forum_prefix, [group_id][prefix_id] =&gt; prefix_id
    /// </summary>
    public byte[] PrefixCache { get; set; } = null!;

    /// <summary>
    /// JSON data from xf_forum_prompt
    /// </summary>
    public byte[] PromptCache { get; set; } = null!;

    public uint DefaultPrefixId { get; set; }

    public string DefaultSortOrder { get; set; } = null!;

    public string DefaultSortDirection { get; set; } = null!;

    public ushort ListDateLimitDays { get; set; }

    public byte RequirePrefix { get; set; }

    public string AllowedWatchNotifications { get; set; } = null!;

    public ushort MinTags { get; set; }

    public uint XfmgMediaMirrorCategoryId { get; set; }

    public uint SvMinPrefixes { get; set; }

    public uint SvMaxPrefixes { get; set; }

    public byte[]? SvDefaultPrefixIds { get; set; }
}
