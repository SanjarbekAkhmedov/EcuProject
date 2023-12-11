using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceUpdate
{
    public uint ResourceUpdateId { get; set; }

    public uint ResourceId { get; set; }

    public uint TeamUserId { get; set; }

    public string TeamUsername { get; set; } = null!;

    /// <summary>
    /// Title field is optional, and is not used in the first post.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Supports BB code
    /// </summary>
    public string Message { get; set; } = null!;

    public string MessageState { get; set; } = null!;

    public uint PostDate { get; set; }

    public uint AttachCount { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint IpId { get; set; }

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public uint LastEditDate { get; set; }

    public uint LastEditUserId { get; set; }

    public uint EditCount { get; set; }

    public byte[]? EmbedMetadata { get; set; }
}
