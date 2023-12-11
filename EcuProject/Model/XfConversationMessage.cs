using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfConversationMessage
{
    public uint MessageId { get; set; }

    public uint ConversationId { get; set; }

    public uint MessageDate { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Message { get; set; } = null!;

    public ushort AttachCount { get; set; }

    public uint IpId { get; set; }

    public byte[]? EmbedMetadata { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;
}
