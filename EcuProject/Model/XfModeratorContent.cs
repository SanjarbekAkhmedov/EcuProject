using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfModeratorContent
{
    public uint ModeratorId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint UserId { get; set; }
}
