using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTrophy
{
    public uint TrophyId { get; set; }

    public uint TrophyPoints { get; set; }

    public byte[] UserCriteria { get; set; } = null!;
}
