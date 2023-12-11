using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThDonateCampaign
{
    public uint CampaignId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public uint MilestoneId { get; set; }

    public sbyte Active { get; set; }

    public sbyte AllowAnonymous { get; set; }

    public sbyte DonationsRecur { get; set; }

    public sbyte DonationsRecurByDefault { get; set; }

    public string Currency { get; set; } = null!;

    public sbyte FreeComment { get; set; }

    public sbyte HideAmounts { get; set; }

    public float Goal { get; set; }

    public sbyte LockWhenComplete { get; set; }

    public sbyte LimitToGoal { get; set; }

    public float MinDonation { get; set; }

    public uint StartDate { get; set; }

    public uint EndDate { get; set; }

    public byte[] Reset { get; set; } = null!;

    public uint ProgressStartDate { get; set; }

    public uint ProgressResetDate { get; set; }

    public float CurrentProgress { get; set; }

    public float TotalProgress { get; set; }

    public byte[] PaymentProfileIds { get; set; } = null!;

    public byte[]? PresetAmounts { get; set; }

    public sbyte AllowCustom { get; set; }

    public uint IconDate { get; set; }

    public uint CoverDate { get; set; }

    public string TagLine { get; set; } = null!;

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[]? ReactionUsers { get; set; }

    public sbyte AllowComments { get; set; }

    public uint LastCommentDate { get; set; }

    public uint CommentCount { get; set; }

    public uint DonationHideAge { get; set; }
}
