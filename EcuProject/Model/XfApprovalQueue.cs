using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApprovalQueue
{
    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint ContentDate { get; set; }
}
