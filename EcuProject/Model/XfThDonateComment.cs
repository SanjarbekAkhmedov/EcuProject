using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThDonateComment
{
    public uint CommentId { get; set; }

    public uint UserId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public string Username { get; set; } = null!;

    public uint PostDate { get; set; }

    public string Message { get; set; } = null!;

    public uint IpId { get; set; }

    public string MessageState { get; set; } = null!;

    public byte[] EmbedMetadata { get; set; } = null!;

    public uint Position { get; set; }

    public uint AttachCount { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public uint LastEditDate { get; set; }

    public uint LastEditUserId { get; set; }

    public uint EditCount { get; set; }
}
