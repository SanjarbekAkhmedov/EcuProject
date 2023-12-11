using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgRating
{
    public uint RatingId { get; set; }

    public uint ContentId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public byte Rating { get; set; }

    public uint RatingDate { get; set; }
}
