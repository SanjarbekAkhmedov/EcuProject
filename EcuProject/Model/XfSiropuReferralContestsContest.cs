using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsContest
{
    public uint ContestId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint MinimumPosts { get; set; }

    public uint EndDate { get; set; }

    public byte[] Prizes { get; set; } = null!;

    public uint ReferralCount { get; set; }

    public uint WinnerUserId { get; set; }

    public uint StartDate { get; set; }

    public byte Enabled { get; set; }
}
