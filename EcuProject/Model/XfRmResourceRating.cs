using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceRating
{
    public uint ResourceRatingId { get; set; }

    public uint ResourceVersionId { get; set; }

    public uint UserId { get; set; }

    public byte Rating { get; set; }

    public uint RatingDate { get; set; }

    public string Message { get; set; } = null!;

    public uint ResourceId { get; set; }

    public string VersionString { get; set; } = null!;

    public uint AuthorResponseTeamUserId { get; set; }

    public string AuthorResponseTeamUsername { get; set; } = null!;

    public string AuthorResponse { get; set; } = null!;

    public byte IsReview { get; set; }

    /// <summary>
    /// Whether this counts towards the global resource rating.
    /// </summary>
    public byte CountRating { get; set; }

    public string RatingState { get; set; } = null!;

    public uint WarningId { get; set; }

    public byte IsAnonymous { get; set; }

    public byte[] CustomFields { get; set; } = null!;

    public int VoteScore { get; set; }

    public uint VoteCount { get; set; }
}
