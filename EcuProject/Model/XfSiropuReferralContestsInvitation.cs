using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsInvitation
{
    public string InvitationCode { get; set; } = null!;

    public uint UserId { get; set; }

    public string Recipient { get; set; } = null!;

    public string Message { get; set; } = null!;

    public uint RegisteredUserId { get; set; }

    public uint InvitationDate { get; set; }

    public uint ExpirationDate { get; set; }

    public byte[]? UserGroupIds { get; set; }
}
