using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPollVote
{
    public uint UserId { get; set; }

    public uint PollResponseId { get; set; }

    public uint PollId { get; set; }

    public uint VoteDate { get; set; }
}
