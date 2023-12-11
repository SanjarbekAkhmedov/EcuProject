using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserTrophy
{
    public uint UserId { get; set; }

    public uint TrophyId { get; set; }

    public uint AwardDate { get; set; }
}
