using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBookmarkItem
{
    public uint BookmarkId { get; set; }

    public uint UserId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint BookmarkDate { get; set; }

    public string Message { get; set; } = null!;

    public byte[] Labels { get; set; } = null!;
}
