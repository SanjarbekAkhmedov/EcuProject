using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfContentVote
{
    public uint VoteId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint VoteUserId { get; set; }

    public uint ContentUserId { get; set; }

    public byte IsContentUserCounted { get; set; }

    public int Score { get; set; }

    public uint VoteDate { get; set; }
}
