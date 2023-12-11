using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfReactionContent
{
    public uint ReactionContentId { get; set; }

    public uint ReactionId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint ReactionUserId { get; set; }

    public uint ReactionDate { get; set; }

    public uint ContentUserId { get; set; }

    public byte IsCounted { get; set; }
}
