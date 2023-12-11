using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThDonateCampaignUser
{
    public uint CampaignUserId { get; set; }

    public uint CampaignId { get; set; }

    public uint UserId { get; set; }

    public float TotalDonation { get; set; }

    public float TotalPublicDonation { get; set; }

    public float TotalAnonymousDonation { get; set; }
}
