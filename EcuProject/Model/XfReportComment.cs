using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfReportComment
{
    public uint ReportCommentId { get; set; }

    public uint ReportId { get; set; }

    public uint CommentDate { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string StateChange { get; set; } = null!;

    public byte IsReport { get; set; }
}
