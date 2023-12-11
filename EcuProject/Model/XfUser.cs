using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUser
{
    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint UsernameDate { get; set; }

    public uint UsernameDateVisible { get; set; }

    public string Email { get; set; } = null!;

    public string CustomTitle { get; set; } = null!;

    public uint LanguageId { get; set; }

    /// <summary>
    /// 0 = use system default
    /// </summary>
    public uint StyleId { get; set; }

    /// <summary>
    /// Example: &apos;Europe/London&apos;
    /// </summary>
    public string Timezone { get; set; } = null!;

    /// <summary>
    /// Show browsing activity to others
    /// </summary>
    public byte Visible { get; set; }

    public byte ActivityVisible { get; set; }

    public uint UserGroupId { get; set; }

    public byte[] SecondaryGroupIds { get; set; } = null!;

    /// <summary>
    /// User group ID that provides user styling
    /// </summary>
    public uint DisplayStyleGroupId { get; set; }

    public uint PermissionCombinationId { get; set; }

    public uint MessageCount { get; set; }

    public uint QuestionSolutionCount { get; set; }

    public ushort ConversationsUnread { get; set; }

    public uint RegisterDate { get; set; }

    public uint LastActivity { get; set; }

    public uint? LastSummaryEmailDate { get; set; }

    public uint TrophyPoints { get; set; }

    public ushort AlertsUnviewed { get; set; }

    public ushort AlertsUnread { get; set; }

    public uint AvatarDate { get; set; }

    public ushort AvatarWidth { get; set; }

    public ushort AvatarHeight { get; set; }

    public byte AvatarHighdpi { get; set; }

    /// <summary>
    /// If specified, this is an email address corresponding to the user&apos;s &apos;Gravatar&apos;
    /// </summary>
    public string Gravatar { get; set; } = null!;

    public string UserState { get; set; } = null!;

    public string SecurityLock { get; set; } = null!;

    public byte IsModerator { get; set; }

    public byte IsAdmin { get; set; }

    public byte IsBanned { get; set; }

    public int ReactionScore { get; set; }

    public int VoteScore { get; set; }

    public uint WarningPoints { get; set; }

    public byte IsStaff { get; set; }

    public byte[] SecretKey { get; set; } = null!;

    public uint PrivacyPolicyAccepted { get; set; }

    public uint TermsAccepted { get; set; }

    public float ThdonateTotalDonation { get; set; }

    public float ThdonateTotalPublicDonation { get; set; }

    public float ThdonateTotalAnonymousDonation { get; set; }

    public uint ThdonateNumDonation { get; set; }

    public uint ThdonateNumPublicDonation { get; set; }

    public uint ThdonateNumAnonymousDonation { get; set; }

    public uint XfrmResourceCount { get; set; }

    public string? XfaRmmpUserCgv { get; set; }

    public uint XfaRmmpUserPurchases { get; set; }

    public uint XfaRmmpUserSales { get; set; }

    public decimal XfaRmmpUserSalesAmount { get; set; }

    public string XfaRmmpUserPaypal { get; set; } = null!;

    public byte XfaRmmpUserBlocked { get; set; }

    public uint XfmgAlbumCount { get; set; }

    public uint XfmgMediaCount { get; set; }

    public uint XfmgMediaQuota { get; set; }

    public uint MadLastCheck { get; set; }

    public uint SiropuReferrerId { get; set; }

    public uint SiropuReferralCount { get; set; }

    public byte SiropuReferrerCredit { get; set; }

    public uint DbtechCreditsLastdaily { get; set; }

    public uint DbtechCreditsLastinterest { get; set; }

    public uint DbtechCreditsLastpaycheck { get; set; }

    public uint DbtechCreditsLasttaxation { get; set; }

    public decimal DbtechCreditsRub { get; set; }

    public uint BratrReceiveRatings { get; set; }

    public uint BratrBeDonatedRatings { get; set; }

    public uint BratrRatings { get; set; }

    public uint BratrReceiveRatingCount { get; set; }

    public decimal DbtechCreditsUsd { get; set; }

    public decimal DbtechCreditsByn { get; set; }
}
