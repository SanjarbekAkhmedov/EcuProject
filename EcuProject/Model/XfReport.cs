using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfReport
{
    public uint ReportId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint ContentUserId { get; set; }

    public byte[] ContentInfo { get; set; } = null!;

    public uint FirstReportDate { get; set; }

    public string ReportState { get; set; } = null!;

    public uint AssignedUserId { get; set; }

    public uint CommentCount { get; set; }

    public uint LastModifiedDate { get; set; }

    public uint LastModifiedUserId { get; set; }

    public string LastModifiedUsername { get; set; } = null!;

    public uint ReportCount { get; set; }
}
