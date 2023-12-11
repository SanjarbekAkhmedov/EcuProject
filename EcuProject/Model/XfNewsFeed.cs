using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNewsFeed
{
    public uint NewsFeedId { get; set; }

    /// <summary>
    /// The user who performed the action
    /// </summary>
    public uint UserId { get; set; }

    /// <summary>
    /// Corresponds to user_id
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// eg: thread
    /// </summary>
    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    /// <summary>
    /// eg: edit
    /// </summary>
    public string Action { get; set; } = null!;

    public uint EventDate { get; set; }

    /// <summary>
    /// Serialized. Stores any extra data relevant to the action
    /// </summary>
    public byte[] ExtraData { get; set; } = null!;
}
