using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfConversationMaster
{
    public uint ConversationId { get; set; }

    public string Title { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint StartDate { get; set; }

    public byte OpenInvite { get; set; }

    public byte ConversationOpen { get; set; }

    public uint ReplyCount { get; set; }

    public uint RecipientCount { get; set; }

    public uint FirstMessageId { get; set; }

    public uint LastMessageDate { get; set; }

    public uint LastMessageId { get; set; }

    public uint LastMessageUserId { get; set; }

    public string LastMessageUsername { get; set; } = null!;

    public byte[] Recipients { get; set; } = null!;
}
