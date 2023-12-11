using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThDonateDonation
{
    public uint DonationId { get; set; }

    public uint UserId { get; set; }

    public uint CampaignId { get; set; }

    public uint DonationDate { get; set; }

    public uint Position { get; set; }

    public float Amount { get; set; }

    public string Message { get; set; } = null!;

    public sbyte Anonymous { get; set; }

    public sbyte DiscloseAmount { get; set; }

    public sbyte Recurring { get; set; }

    public byte[]? PurchaseRequestKey { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[]? ReactionUsers { get; set; }

    public uint LastCommentDate { get; set; }

    public uint CommentCount { get; set; }

    public byte[]? LatestCommentIds { get; set; }
}
