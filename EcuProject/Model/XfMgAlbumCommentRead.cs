using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgAlbumCommentRead
{
    public uint CommentReadId { get; set; }

    public uint UserId { get; set; }

    public uint AlbumId { get; set; }

    public uint CommentReadDate { get; set; }
}
