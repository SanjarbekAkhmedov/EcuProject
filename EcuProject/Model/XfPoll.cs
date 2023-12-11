using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPoll
{
    public uint PollId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public string Question { get; set; } = null!;

    public byte[] Responses { get; set; } = null!;

    public uint VoterCount { get; set; }

    public byte PublicVotes { get; set; }

    public byte MaxVotes { get; set; }

    public uint CloseDate { get; set; }

    public byte ChangeVote { get; set; }

    public byte ViewResultsUnvoted { get; set; }
}
