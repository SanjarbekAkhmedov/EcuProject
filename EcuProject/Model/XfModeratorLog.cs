using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfModeratorLog
{
    public uint ModeratorLogId { get; set; }

    public uint LogDate { get; set; }

    public uint UserId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint ContentUserId { get; set; }

    public string ContentUsername { get; set; } = null!;

    public string ContentTitle { get; set; } = null!;

    public string ContentUrl { get; set; } = null!;

    public string DiscussionContentType { get; set; } = null!;

    public uint DiscussionContentId { get; set; }

    public string Action { get; set; } = null!;

    public byte[] ActionParams { get; set; } = null!;
}
