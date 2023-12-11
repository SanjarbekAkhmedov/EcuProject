using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsUnconfirmed
{
    public uint UserId { get; set; }

    public uint ReferrerId { get; set; }

    public string InvitationCode { get; set; } = null!;
}
