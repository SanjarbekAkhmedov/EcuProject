using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPollResponse
{
    public uint PollResponseId { get; set; }

    public uint PollId { get; set; }

    public string Response { get; set; } = null!;

    public uint ResponseVoteCount { get; set; }

    public byte[] Voters { get; set; } = null!;
}
