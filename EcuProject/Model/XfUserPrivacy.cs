using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserPrivacy
{
    public uint UserId { get; set; }

    public string AllowViewProfile { get; set; } = null!;

    public string AllowPostProfile { get; set; } = null!;

    public string AllowSendPersonalConversation { get; set; } = null!;

    public string AllowViewIdentities { get; set; } = null!;

    public string AllowReceiveNewsFeed { get; set; } = null!;

    public string ThdonateAllowViewDonationStats { get; set; } = null!;
}
