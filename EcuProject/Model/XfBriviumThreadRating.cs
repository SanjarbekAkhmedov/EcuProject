using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBriviumThreadRating
{
    public int ThreadRatingId { get; set; }

    public uint ThreadId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte Rating { get; set; }

    public uint RatingDate { get; set; }

    public byte RatingStatus { get; set; }

    public string Message { get; set; } = null!;

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public byte IsAnonymous { get; set; }

    public string Encode { get; set; } = null!;

    public uint Likes { get; set; }

    public byte[] LikeUsers { get; set; } = null!;
}
