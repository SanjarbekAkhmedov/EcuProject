using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfConversationRecipient
{
    public uint ConversationId { get; set; }

    public uint UserId { get; set; }

    public string RecipientState { get; set; } = null!;

    public uint LastReadDate { get; set; }
}
