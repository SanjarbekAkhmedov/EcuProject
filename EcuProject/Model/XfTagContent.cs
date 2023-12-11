using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTagContent
{
    public uint TagContentId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint TagId { get; set; }

    public uint AddUserId { get; set; }

    public uint AddDate { get; set; }

    public byte Visible { get; set; }

    public uint ContentDate { get; set; }
}
