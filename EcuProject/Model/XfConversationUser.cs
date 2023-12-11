using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfConversationUser
{
    public uint ConversationId { get; set; }

    public uint OwnerUserId { get; set; }

    public byte IsUnread { get; set; }

    public uint ReplyCount { get; set; }

    public uint LastMessageDate { get; set; }

    public uint LastMessageId { get; set; }

    public uint LastMessageUserId { get; set; }

    public string LastMessageUsername { get; set; } = null!;

    public byte IsStarred { get; set; }
}
