using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsRewardType
{
    public uint RewardTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Currency { get; set; } = null!;
}
