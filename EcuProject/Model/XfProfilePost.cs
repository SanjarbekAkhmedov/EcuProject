using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfProfilePost
{
    public uint ProfilePostId { get; set; }

    public uint ProfileUserId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint PostDate { get; set; }

    public string Message { get; set; } = null!;

    public uint IpId { get; set; }

    public string MessageState { get; set; } = null!;

    public ushort AttachCount { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint CommentCount { get; set; }

    public uint FirstCommentDate { get; set; }

    public uint LastCommentDate { get; set; }

    public byte[] LatestCommentIds { get; set; } = null!;

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public byte[]? EmbedMetadata { get; set; }
}
