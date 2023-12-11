using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaCommentRead
{
    public uint CommentReadId { get; set; }

    public uint UserId { get; set; }

    public uint MediaId { get; set; }

    public uint CommentReadDate { get; set; }
}
