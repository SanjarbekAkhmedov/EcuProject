using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPost
{
    public uint PostId { get; set; }

    public uint ThreadId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint PostDate { get; set; }

    public string Message { get; set; } = null!;

    public uint IpId { get; set; }

    public string MessageState { get; set; } = null!;

    public ushort AttachCount { get; set; }

    public uint Position { get; set; }

    public byte[] TypeData { get; set; } = null!;

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public int VoteScore { get; set; }

    public uint VoteCount { get; set; }

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public uint LastEditDate { get; set; }

    public uint LastEditUserId { get; set; }

    public uint EditCount { get; set; }

    public byte[]? EmbedMetadata { get; set; }

    public byte BratrStar { get; set; }

    public byte ThreadRatingId { get; set; }
}
