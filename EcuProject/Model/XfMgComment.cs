using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgComment
{
    public uint CommentId { get; set; }

    public uint ContentId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public string Message { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint IpId { get; set; }

    public uint CommentDate { get; set; }

    public string CommentState { get; set; } = null!;

    public uint RatingId { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public uint LastEditDate { get; set; }

    public uint LastEditUserId { get; set; }

    public uint EditCount { get; set; }

    public byte[]? EmbedMetadata { get; set; }
}
