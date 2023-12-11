using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfForumWatch
{
    public uint UserId { get; set; }

    public uint NodeId { get; set; }

    public string NotifyOn { get; set; } = null!;

    public byte SendAlert { get; set; }

    public byte SendEmail { get; set; }
}
